//Meiring van Niekerk, 47817909
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Application
{
    public partial class frmRegisterPatient : MaterialForm
    {
        //Credit to https://stackoverflow.com/questions/38768737/interaction-between-forms-how-to-change-a-control-of-a-form-from-another-form
        frmAdministrator AdministratorForm;
        public frmRegisterPatient(frmAdministrator myRegisterForm)
        {
            InitializeComponent();
            //Credit to https://www.nuget.org/packages/MaterialSkin.2
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.Blue600, Accent.Blue400, TextShade.WHITE);
            AdministratorForm = myRegisterForm;
        }

        //Declare field variables
        public SqlConnection fConn;
        private bool bRegister;
     
        private void mtxtAllergy_TextChanged(object sender, EventArgs e)
        {
            //Validate input
            if (mtxtAllergy.Text != "")
            {
                Name_Surname_Allergy_CorrectInput(sender, e);
                erpRegister.SetError(mtxtAllergy, "");                
            }               
            else
                erpRegister.SetError(mtxtAllergy, "Enter allergy");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Validate input
            if (mtxtAllergy.Text != "")
            {
                //Add allergy to listbox, clear input and set cursor to input
                lstAllergies.Items.Add(mtxtAllergy.Text);
                mtxtAllergy.Clear();
                erpRegister.SetError(mtxtAllergy, "");
                mtxtAllergy.Focus();
            }
            else
                erpRegister.SetError(mtxtAllergy, "Enter allergy");
        }

        private void lstAllergies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remove allergy
            if (lstAllergies.SelectedIndex != -1)
                lstAllergies.Items.RemoveAt(lstAllergies.SelectedIndex);
        }

        private void MaskInput_Click(object sender, EventArgs e)
        {
            //Credit to https://learn.microsoft.com/en-us/dotnet/desktop/wpf/controls/position-the-cursor-at-the-beginning-or-end-of-text?view=netframeworkdesktop-4.8
            //Helps correct input
            if (((MaskedTextBox)sender).SelectionStart > ((MaskedTextBox)sender).Text.Length)
                ((MaskedTextBox)sender).Select(((MaskedTextBox)sender).Text.Length, 0);
        }

        private void Name_Surname_Allergy_CorrectInput(object sender, EventArgs e)
        {
            //Deletes dubble spaces
            while (((MaskedTextBox)sender).Text.IndexOf("  ") != -1)
                ((MaskedTextBox)sender).Text = ((MaskedTextBox)sender).Text.Replace("  ", "");                               
        }

        private void mtxtName_TextChanged(object sender, EventArgs e)
        {
            //If register button clicked
            if (sender == btnRegister)
            {
                //Check if able to register
                if (mtxtName.Text == "")
                {
                    bRegister = false;
                    erpRegister.SetError(mtxtName, "Enter name");
                }                   
            }
            //Else if its not empty correct user input
            else if (mtxtName.Text != "")
            {
                erpRegister.SetError(mtxtName, "");
                Name_Surname_Allergy_CorrectInput(sender, e);
            }               
            else //Else input is null display error          
                erpRegister.SetError(mtxtName, "Enter name");            
        }

        private void mtxtSurname_TextChanged(object sender, EventArgs e)
        {
            //If register button clicked
            if (sender == btnRegister)
            {
                //Check if able to register
                if (mtxtSurname.Text == "")
                {
                    bRegister = false;
                    erpRegister.SetError(mtxtSurname, "Enter surname");
                }
            }
            //Else if its not empty correct user input
            else if (mtxtSurname.Text != "")
            {
                erpRegister.SetError(mtxtSurname, "");
                Name_Surname_Allergy_CorrectInput(sender, e);
            }
            else //Else input is null display error  
                erpRegister.SetError(mtxtSurname, "Enter surname");

        }

        private void mtxtEmail_TextChanged(object sender, EventArgs e)
        {
            //Initialise variables
            bool bValidSigns = true;
            int iAtSign = 0;
            int iDotSign = 0;

            //Validate input
            if (mtxtEmail.Text != "")
            {
                erpRegister.SetError(mtxtEmail, "");
                /*Credit to https://stackoverflow.com/questions/26198085/while-looping-an-array
                Validate each character in the email address*/
                foreach (char cCharacter in mtxtEmail.Text)
                {
                    if (char.IsLetterOrDigit(cCharacter) || cCharacter == '@' || cCharacter == '.')
                    {
                        if (cCharacter == '@')
                            iAtSign++;
                        if (cCharacter == '.')
                            iDotSign++;
                    }
                    else
                    {
                        bValidSigns = false;
                        break;
                    }
                }
                /*If there is an invalid character or more than 1 @ or . sign or
                  the @ or . sign is at the beginning or end or
                  the @ and . sign is next to each other or
                  the @ sign is after the . sign then the email is invalid*/
                if (!bValidSigns || iAtSign != 1 || iDotSign != 1 ||
                    mtxtEmail.Text.IndexOf('@') == 0 || mtxtEmail.Text.IndexOf('@') == mtxtEmail.Text.Length - 1 ||
                    mtxtEmail.Text.IndexOf('.') == 0 || mtxtEmail.Text.IndexOf('.') == mtxtEmail.Text.Length - 1 ||
                    mtxtEmail.Text[mtxtEmail.Text.IndexOf('.') + 1] == '@' || mtxtEmail.Text[mtxtEmail.Text.IndexOf('.') - 1] == '@' ||
                    mtxtEmail.Text.IndexOf('@') > mtxtEmail.Text.IndexOf('.'))
                {
                    erpRegister.SetError(mtxtEmail, "Invalid email address");
                    bRegister = false;
                }
            }
            else
            {
                erpRegister.SetError(mtxtEmail, "Enter email address");
                bRegister = false;
            }
        }

        private void mtxtContact_TextChanged(object sender, EventArgs e)
        {
            //Validate contact number
            if (mtxtContact.Text.Length != 10)
            {
                bRegister = false;
                erpRegister.SetError(mtxtContact, "Enter contact number");
            }
            else
                erpRegister.SetError(mtxtContact, "");
        }

        private void mtxtEmergencyContact_TextChanged(object sender, EventArgs e)
        {
            //Validate emergency contact number
            if (mtxtEmergencyContact.Text.Length != 10)
            {
                bRegister = false;
                erpRegister.SetError(mtxtEmergencyContact, "Enter emergency number");
            }
            else
                erpRegister.SetError(mtxtEmergencyContact, "");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Assume that correct input is provided
            bRegister = true;

            //Validate input
            mtxtName_TextChanged(sender, e);
            mtxtSurname_TextChanged(sender, e);
            mtxtEmail_TextChanged(sender, e);
            mtxtContact_TextChanged(sender, e);
            mtxtEmergencyContact_TextChanged(sender, e);           

            //If input valid
            if (bRegister)
            {
                //SQL command (Count amount of records)
                fConn.Open();
                SqlCommand comm = new SqlCommand($"SELECT Count(*) FROM tblPatients", fConn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();
                adapter.SelectCommand = comm;
                adapter.Fill(dataset, "tblPatients");
                fConn.Close();

                //Create patientID by taking the name and surname initial, add an underscore and the record number
                string sPatientID = (mtxtName.Text.Substring(0, 1) + mtxtSurname.Text.Substring(0, 1)).ToUpper() + "_" + dataset.Tables["tblPatients"].Rows[0][0].ToString();
                //Create temporay password by taking the email initial, underscore, first 3 contact digits, underscore and the last 4 emergency digits
                string sTempPassword = mtxtEmail.Text.Substring(0, 1) + "_" + mtxtContact.Text.Substring(0, 3) + "_" + mtxtEmergencyContact.Text.Substring(6, 4);

                //SQL command (Insert new patient)
                fConn.Open();
                comm = new SqlCommand($"INSERT INTO tblPatients(PatientID, Password, Name, Surname, Contact, Email, EmergencyContact, JustRegistered) VALUES('{sPatientID}', '{sTempPassword}', '{mtxtName.Text}', '{mtxtSurname.Text}', '{mtxtContact.Text}', '{mtxtEmail.Text}', '{mtxtEmergencyContact.Text}', 1)", fConn);
                comm.ExecuteNonQuery();
                fConn.Close();

                //SQL command (Insert patient's allergies)
                foreach (string sAllergy in lstAllergies.Items)
                {
                    fConn.Open();
                    comm = new SqlCommand($"INSERT INTO tblAllergies(PatientID, Allergy) VALUES('{sPatientID}', '{sAllergy}')", fConn);
                    comm.ExecuteNonQuery();
                    fConn.Close();
                }

                //Display patient added
                MessageBox.Show("Patient registered with ID and temporary password:\nPatient ID: " + sPatientID + "\nPassword: " + sTempPassword, "Patient registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset input fields
                mtxtName.Clear(); erpRegister.SetError(mtxtName, "");
                mtxtSurname.Clear(); erpRegister.SetError(mtxtSurname, "");
                mtxtContact.Clear(); erpRegister.SetError(mtxtContact, "");
                mtxtEmail.Clear(); erpRegister.SetError(mtxtEmail, "");
                mtxtEmergencyContact.Clear(); erpRegister.SetError(mtxtEmergencyContact, "");
                lstAllergies.Items.Clear(); erpRegister.SetError(lstAllergies, "");
                //Set cursor to first input field
                mtxtName.Focus();
            }
        }        
    }
}
