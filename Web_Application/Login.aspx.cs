//Meiring van Niekerk, 47817909
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;
using System.Security.Policy;

namespace Web_Application
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //Initialise variables
            string sPatientID = "", sPassword = "", sName = "", sSurname = "";
            bool bJustRegistered = false;

            //Create session connection
            Session["Connection"] = @System.Configuration.ConfigurationManager.ConnectionStrings["WebConnection"].ConnectionString;

            try
            {
                //Set connection
                SqlConnection conn = new SqlConnection(Session["Connection"].ToString());
                conn.Open();
                //Search for Patient ID on system
                SqlCommand comm = new SqlCommand($"SELECT PatientID, Password, Name, Surname, JustRegistered FROM tblPatients WHERE PatientID = '{txtPatientID.Text}'", conn);
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    sPatientID = reader.GetValue(0).ToString();
                    sPassword = reader.GetValue(1).ToString();
                    sName = reader.GetValue(2).ToString();
                    sSurname = reader.GetValue(3).ToString();
                    bJustRegistered = (bool)reader.GetValue(4);
                }
                conn.Close();

                //If entered details match with database
                if (txtPatientID.Text == sPatientID && txtPassword.Text == sPassword)
                {
                    //Create session
                    Session["PatientID"] = sPatientID;

                    if (bJustRegistered)
                    {
                        Session["JustRegistered"] = true;
                        //Open Change password web form
                        Response.Redirect("Change password.aspx");
                    }
                    else
                    {
                        Session["JustRegistered"] = null;
                        //Create cookie with user information
                        HttpCookie Patient = new HttpCookie("Patient");
                        Patient["Name"] = sName;
                        Patient["Surname"] = sSurname;
                        Response.Cookies.Add(Patient);
                        //Open Dashboard web form
                        Response.Redirect("Dashboard.aspx");
                    }
                }
                else
                    //Display error in label
                    lblError.Text = "Incorrect details";
            }
            catch (SqlException ex)
            {
                //Display SQL error in label
                lblError.Text = ex.Message;
            }
        }
    }
}