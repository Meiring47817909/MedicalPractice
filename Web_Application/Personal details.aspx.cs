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
    public partial class Personal_details : System.Web.UI.Page
    {
        //Field variables
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
                    //Display the patient's allergies
                    Display_Allergies();
            }
            else
            {
                //Display error in label
                lblUpdateOrError.ForeColor = System.Drawing.Color.Red;
                lblUpdateOrError.Text = "Session failed.";
            }
        }

        protected void Display_Allergies()
        {
            try
            {
                //SQL command (Display the patient's allergies)
                conn.Open();
                comm = new SqlCommand($"SELECT Allergy FROM tblAllergies WHERE PatientID = '{Session["PatientID"]}'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();
                adapter.SelectCommand = comm;
                adapter.Fill(dataset);
                grdAllergies.DataSource = dataset;
                grdAllergies.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                //Display SQL error in label
                lblUpdateOrError.ForeColor = System.Drawing.Color.Red;
                lblUpdateOrError.Text = ex.Message;
            }
        }

        protected void Change_Database(string sCommand)
        {
            try
            {
                //SQL command (Perform selected operation)
                conn.Open();
                comm = new SqlCommand(sCommand, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                //Display SQL error in label
                lblUpdateOrError.ForeColor = System.Drawing.Color.Red;
                lblUpdateOrError.Text = ex.Message;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //SQL command (Update patient details)
            Change_Database($"UPDATE tblPatients SET Name = '{txtName.Text}', Surname = '{txtSurname.Text}', Contact = '{txtContact.Text}', Email = '{txtEmail.Text}', EmergencyContact = '{txtEmergencyContact.Text}' WHERE PatientID = '{Session["PatientID"]}'");

            //Display details updated and clear input
            txtName.Text = "";
            txtSurname.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtEmergencyContact.Text = "";
            lblUpdateOrError.ForeColor = System.Drawing.Color.Green;
            lblUpdateOrError.Text = "Your details have been changed successfully.";
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //SQL command (Add allergy)
            Change_Database($"INSERT INTO tblAllergies(PatientID, Allergy) VALUES('{Session["PatientID"]}', '{txtAllergy.Text}')");

            //Display allergies after operation
            Display_Allergies();

            //Display message allergy added
            txtAllergy.Text = "";
            lblUpdateOrError.ForeColor = System.Drawing.Color.Green;
            lblUpdateOrError.Text = "Your allergy has been added successfully.";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            //Validate input
            if (grdAllergies.SelectedIndex != -1)
            {
                //SQL command (Delete allergy)
                Change_Database($"DELETE FROM tblAllergies WHERE PatientID = '{Session["PatientID"]}' AND Allergy = '{grdAllergies.SelectedRow.Cells[1].Text}'");

                //Display allergies after deleted allergy
                Display_Allergies();

                //Display allergy deleted
                lblUpdateOrError.ForeColor = System.Drawing.Color.Green;
                lblUpdateOrError.Text = "Your allergy has been deleted successfully.";
            }
            else
            {
                //Display error in label
                lblUpdateOrError.ForeColor = System.Drawing.Color.Red;
                lblUpdateOrError.Text = "Please select an allergy.";
            }
        }
    }
}