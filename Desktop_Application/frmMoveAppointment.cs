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
    public partial class frmMoveAppointment : MaterialForm
    {
        //Credit to https://stackoverflow.com/questions/38768737/interaction-between-forms-how-to-change-a-control-of-a-form-from-another-form
        frmAdministrator AdministratorForm;
        public frmMoveAppointment(frmAdministrator myMoveForm)
        {
            InitializeComponent();
            //Credit to https://www.nuget.org/packages/MaterialSkin.2
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.Blue600, Accent.Blue400, TextShade.WHITE);
            AdministratorForm = myMoveForm;
        }

        //Declare field variables
        public SqlConnection fConn;
        private SqlCommand comm;
        private DataSet dataset;

        private void frmMoveAppointment_Load(object sender, EventArgs e)
        {
            cmbAppointmentID.Items.Clear();

            try
            {
                //Populate combobox with Appointment ID of booked appointments
                fConn.Open();
                SqlCommand comm = new SqlCommand(@"SELECT AppointmentID FROM tblAppointments WHERE Status = 'Booked'", fConn);
                SqlDataReader reader;
                reader = comm.ExecuteReader();
                while (reader.Read())
                    cmbAppointmentID.Items.Add(reader.GetValue(0).ToString());
                fConn.Close();

                //SQL command (Select all available appointments later than current date and time)
                fConn.Open();
                comm = new SqlCommand($"SELECT AppointmentID, Date_Time, Doctor, Status FROM tblAppointments WHERE Status = 'Available' AND Date_Time > '{DateTime.Now}'", fConn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = comm;
                adapter.Fill(dataset, "tblAppointments");
                dtgAppointments.DataSource = dataset;
                dtgAppointments.DataMember = "tblAppointments";
                fConn.Close();
            }
            catch (SqlException ex)
            {
                //Display SQL error in label
                MessageBox.Show(ex.Message, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            //If there are available appointments and a timeslot is selected
            if (dtgAppointments.CurrentRow != null && dtgAppointments.CurrentRow.Index != -1 && cmbAppointmentID.SelectedIndex != -1)
                try
                {
                    //SQL command (Select patient and appointment info to be moved)
                    fConn.Open();
                    comm = new SqlCommand($"SELECT PatientID, Type, Price FROM tblAppointments WHERE AppointmentID = {int.Parse(cmbAppointmentID.Text)}", fConn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    dataset = new DataSet();
                    adapter.SelectCommand = comm;
                    adapter.Fill(dataset, "tblAppointments");
                    fConn.Close();

                    //Exctract the patient's ID and the procedure
                    string sPatientID = dataset.Tables["tblAppointments"].Rows[0][0].ToString();
                    string sProcedure = dataset.Tables["tblAppointments"].Rows[0][1].ToString();
                    decimal dPrice = decimal.Parse(dataset.Tables["tblAppointments"].Rows[0][2].ToString());

                    //SQL command (Update selected available appointment with booked details)
                    fConn.Open();
                    comm = new SqlCommand($"UPDATE tblAppointments SET PatientID = '{sPatientID}', Type = '{sProcedure}', Price = @PRICE, Status = 'Booked' WHERE AppointmentID = {dtgAppointments.CurrentRow.Cells[0].Value.ToString()}", fConn);
                    comm.Parameters.AddWithValue("@PRICE", dPrice);
                    comm.ExecuteNonQuery();
                    fConn.Close();

                    //SQL command (Delete previous booked appointment)
                    fConn.Open();
                    comm = new SqlCommand($"DELETE FROM tblAppointments WHERE AppointmentID = {int.Parse(cmbAppointmentID.Text)}", fConn);
                    comm.ExecuteNonQuery();
                    fConn.Close();

                    //Show moved booking
                    MessageBox.Show("Appointment moved successfully", "Record moved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdministratorForm.DisplayAppoitments();
                    //update combobox and grid
                    frmMoveAppointment_Load(sender, e);
                }
                catch (SqlException ex)
                {
                    //Display SQL error in label
                    MessageBox.Show(ex.Message, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            else
                //Display error message
                MessageBox.Show("1. Please check that a timeslot is selected.\n" +
                                "2. Please check that a Appointment ID is selected.\n" +
                                "3. It may also be that there are no available appointments to move to.", "Insufficient information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}