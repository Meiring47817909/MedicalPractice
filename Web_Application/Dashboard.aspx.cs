//Meiring van Niekerk, 47817909
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application
{
    public partial class Dashboard : System.Web.UI.Page
    {
        private SqlConnection conn;
        private SqlCommand comm;

        protected void Page_Load(object sender, EventArgs e)
        {
            //validate sessions
            if (Session["Connection"] != null && Session["PatientID"] != null)
            {
                //Set connection here (saves code)
                conn = new SqlConnection(Session["Connection"].ToString());

                //For first time page loads
                if (!IsPostBack)
                {
                    //Get cookie
                    HttpCookie Patient = Request.Cookies["Patient"];

                    //validate cookie
                    if (Patient != null)
                    {
                        //Welcome logged in patient               
                        lblWelcomeOrError.Text = "Welcome dearest " + Patient["Name"] + " " + Patient["Surname"] + "!";
                        Display_Avatar();
                    }
                    else
                    {
                        //Display error in label
                        lblWelcomeOrError.ForeColor = System.Drawing.Color.Red;
                        lblWelcomeOrError.Text = "Cookie failed";
                    }
                }
            }
            else
            {
                //Display error in label
                lblWelcomeOrError.ForeColor = System.Drawing.Color.Red;
                lblWelcomeOrError.Text = "Session failed";
            }
        }

        protected void Display_Avatar()
        {
            try
            {
                //Get user's avatar
                conn.Open();
                comm = new SqlCommand($"SELECT Avatar FROM tblPatients WHERE PatientID = '{Session["PatientID"]}'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();
                adapter.SelectCommand = comm;
                adapter.Fill(dataset, "tblPatients");
                conn.Close();

                //Credit to https://www.codeproject.com/Questions/1183317/How-to-display-image-on-aspx-page-from-database-in
                //Display avatar
                imgProfilePicture.ImageUrl = String.Format("data:image/jpg;base64,{0}", Convert.ToBase64String((byte[])(dataset.Tables["tblPatients"].Rows[0][0])));
            }
            catch (SqlException ex)
            {
                //Display SQL error in label
                lblWelcomeOrError.ForeColor = System.Drawing.Color.Red;
                lblWelcomeOrError.Text = ex.Message;
            }
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("Change password.aspx");
        }

        protected void btnBookAppointment_Click(object sender, EventArgs e)
        {
            Response.Redirect("Book Appointment.aspx");
        }

        protected void btnMyAppointments_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cancel Appointment.aspx");
        }

        protected void btnUpdateDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("Personal details.aspx");
        }

        protected void btnViewInvoices_Click(object sender, EventArgs e)
        {
            Response.Redirect("View invoices.aspx");
        }

        protected void drpAvatar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Credit to https://www.youtube.com/watch?v=mxjeE9no06w for writing image to database
                //On avatar selection change save the avatar image in the database
                byte[] data;
                conn.Open();
                if (drpAvatar.SelectedIndex == 0)
                    data = System.IO.File.ReadAllBytes(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory) + @"\Images\Other.jpg");
                else if (drpAvatar.SelectedIndex == 1)
                    data = System.IO.File.ReadAllBytes(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory) + @"\Images\Male.jpg");
                else
                    data = System.IO.File.ReadAllBytes(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory) + @"\Images\Female.jpg");
                comm = new SqlCommand($"UPDATE tblPatients SET Avatar = @PIC WHERE PatientID = '{Session["PatientID"]}'", conn);
                comm.Parameters.AddWithValue("@PIC", data);
                comm.ExecuteNonQuery();
                conn.Close();

                //Display new avatar
                Display_Avatar();
            }
            catch (SqlException ex)
            {
                //Display SQL error in label
                lblWelcomeOrError.ForeColor = System.Drawing.Color.Red;
                lblWelcomeOrError.Text = ex.Message;
            }
        }
    }
}