//Meiring van Niekerk, 47817909
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Desktop_Application
{
    public partial class frmViewDetails : MaterialForm
    {
        //Credit to https://stackoverflow.com/questions/38768737/interaction-between-forms-how-to-change-a-control-of-a-form-from-another-form
        frmAdministrator AdministratorForm;
        public frmViewDetails(frmAdministrator myViewForm)
        {
            InitializeComponent();
            //Credit to https://www.nuget.org/packages/MaterialSkin.2
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.Blue600, Accent.Blue400, TextShade.WHITE);
            AdministratorForm = myViewForm;
        }

        //Declare field variables
        public SqlConnection fConn;
        public string fPatientID;
        public int fAppointmentID;

        private void frmViewDetails_Load(object sender, EventArgs e)
        {
            try
            {
                //Credit to https://www.youtube.com/watch?v=tEEUevb_cJI
                //SQL command (Get patient's and appointment's details)
                fConn.Open();
                SqlCommand comm = new SqlCommand($"SELECT Name, Surname, Email, Contact, EmergencyContact, Avatar, Type, Price FROM tblPatients, tblAppointments WHERE tblPatients.PatientID = tblAppointments.PatientID AND AppointmentID = {fAppointmentID} AND tblPatients.PatientID = '{fPatientID}'", fConn);               
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                fConn.Close();

                //Display patient's and appointment's information
                txtName.Text = dt.Rows[0][0].ToString();
                txtSurname.Text = dt.Rows[0][1].ToString();
                txtEmail.Text = dt.Rows[0][2].ToString();
                txtContact.Text = dt.Rows[0][3].ToString();
                txtEmergencyContact.Text = dt.Rows[0][4].ToString();
                txtProcedure.Text = dt.Rows[0][6].ToString();
                txtPrice.Text = decimal.Parse((dt.Rows[0][7]).ToString()).ToString("C");
                //Credit to https://stackoverflow.com/questions/8084590/how-to-load-image-from-sql-server-into-picture-box
                picAvatar.BackgroundImage = Image.FromStream(new MemoryStream((Byte[])(dt.Rows[0][5])));
            }
            catch (SqlException ex)
            {
                //Display SQL error in label
                MessageBox.Show(ex.Message, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
