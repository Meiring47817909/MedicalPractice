//Meiring van Niekerk, 47817909
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;

namespace Web_Application
{
    public partial class Change_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If first time page loads
            if (!IsPostBack)
                //If already change password can go back to dashboard
                if (Session["JustRegistered"] != null)
                {
                    //Must first change password otherwise logout
                    hplLoginOrDashboard.Text = "Logout";
                    hplLoginOrDashboard.NavigateUrl = "~/Login.aspx";                  
                }
                else
                {
                    hplLoginOrDashboard.Text = "Dashboard";
                    hplLoginOrDashboard.NavigateUrl = "~/Dashboard.aspx";
                }
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            //Validate sessions
            if (Session["PatientID"] != null && Session["Connection"] != null)
            {
                try
                {
                    SqlCommand comm;
                    SqlConnection conn = new SqlConnection(Session["Connection"].ToString());
                    conn.Open();
                    //SQL command (Update patient password)
                    if (Session["JustRegistered"] == null)
                        comm = new SqlCommand($"UPDATE tblPatients SET Password = '{txtPassword.Text}' WHERE PatientID = '{Session["PatientID"]}'", conn);
                    else
                    {
                        //Credit to https://www.youtube.com/watch?v=mxjeE9no06w for writing image to database
                        //Set user's avatar to 'other'
                        byte[] data = System.IO.File.ReadAllBytes(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory) + @"\Images\Other.jpg");
                        comm = new SqlCommand($"UPDATE tblPatients SET Password = '{txtPassword.Text}', JustRegistered = '0', Avatar = @PIC WHERE PatientID = '{Session["PatientID"]}'", conn);
                        comm.Parameters.AddWithValue("@PIC", data);
                    }
                    comm.ExecuteNonQuery();
                    conn.Close();

                    //Display patient password updated                    
                    lblChangeOrError.ForeColor = System.Drawing.Color.Green;
                    lblChangeOrError.Text = "Your password has successfully been updated to: " + txtPassword.Text;
                    txtPassword.Text = "";
                }
                catch (SqlException ex)
                {
                    //Display SQL error in label
                    lblChangeOrError.ForeColor = System.Drawing.Color.Red;
                    lblChangeOrError.Text = ex.Message;
                }
            }
            else
            {
                //Display error in label
                lblChangeOrError.ForeColor = System.Drawing.Color.Red;
                lblChangeOrError.Text = "Session failed";
            }
        }
    }
}