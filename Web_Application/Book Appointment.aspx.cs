//Meiring van Niekerk, 47817909
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application
{
    public partial class Book_Appointment : System.Web.UI.Page
    {
        //Field variables
        private SqlConnection conn;
        private SqlCommand comm;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Validate sessions
            if (Session["Connection"] != null && Session["PatientID"] != null)
            {
                //Set connection here (saves code)
                conn = new SqlConnection(Session["Connection"].ToString());

                //For first time page loads
                if (!IsPostBack)
                    //Display available appointments
                    Display_Available_Appointments();
            }
            else
            {
                //Display error in label
                lblAddOrError.ForeColor = System.Drawing.Color.Red;
                lblAddOrError.Text = "Session failed";
            }
        }

        protected void Display_Available_Appointments()
        {
            try
            {
                //SQL command (Display available appointments)
                conn.Open();
                comm = new SqlCommand(@"SELECT AppointmentID, Date_Time, Doctor, Status FROM tblAppointments WHERE Status = 'Available'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();
                adapter.SelectCommand = comm;
                adapter.Fill(dataset);
                grdAvailableAppointments.DataSource = dataset;
                grdAvailableAppointments.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                //Display SQL error in label
                lblAddOrError.ForeColor = System.Drawing.Color.Red;
                lblAddOrError.Text = ex.Message;
            }
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            //Validate input
            if (grdAvailableAppointments.SelectedIndex != -1 && rlstProcedure.SelectedIndex != -1)
            {
                try
                {
                    //SQL command (Book appointment)
                    conn.Open();
                    comm = new SqlCommand($"UPDATE tblAppointments SET PatientID = '{Session["PatientID"]}', Type = '{rlstProcedure.SelectedValue}', Price = {rlstProcedure.SelectedItem.Text.Substring(rlstProcedure.SelectedItem.Text.LastIndexOf('R') + 1)}, Status = 'Booked' WHERE AppointmentID = {grdAvailableAppointments.SelectedRow.Cells[1].Text}", conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    //Display appointment booked
                    lblAddOrError.ForeColor = System.Drawing.Color.Green;
                    lblAddOrError.Text = "Your appointment has been booked successfully";
                    //Remove the booked appointment from the avialable displayed appointments
                    Display_Available_Appointments();
                }
                catch (SqlException ex)
                {
                    //Display SQL error in label
                    lblAddOrError.ForeColor = System.Drawing.Color.Red;
                    lblAddOrError.Text = ex.Message;
                }
            }
            else
            {
                //Display error in label
                lblAddOrError.ForeColor = System.Drawing.Color.Red;
                lblAddOrError.Text = "Please ensure that a doctor and timeslot is selected.";
            }
        }
    }
}