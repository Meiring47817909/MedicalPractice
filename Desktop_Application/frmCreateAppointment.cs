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
    public partial class frmCreateAppointment : MaterialForm
    {
        //Credit to https://stackoverflow.com/questions/38768737/interaction-between-forms-how-to-change-a-control-of-a-form-from-another-form
        frmAdministrator AdministratorForm;
        public frmCreateAppointment(frmAdministrator myAdminForm)
        {
            InitializeComponent();
            //Credit to https://www.nuget.org/packages/MaterialSkin.2
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.Blue600, Accent.Blue400, TextShade.WHITE);
            AdministratorForm = myAdminForm;
        }

        //Declare field variables
        public SqlConnection fConn;

        private void frmCreateAppointment_Load(object sender, EventArgs e)
        {
            //Set date picker to today's date and call the date picker changed event to populate combobox
            dtpAppointment.MinDate = DateTime.Today.Date;
            dtpAppointment_ValueChanged(sender, e);
        }

        private void dtpAppointment_ValueChanged(object sender, EventArgs e)
        {
            cmbTime.Items.Clear();

            //If today's date is selected 
            if (dtpAppointment.Value.Date == DateTime.Today.Date)
            {
                //Credit to https://stackoverflow.com/questions/26198085/while-looping-an-array
                foreach (var time in AdministratorForm.fTimes)
                {
                    //Only display remaining time slots of today
                    if ((time.CompareTo(DateTime.Now.ToString("HH:mm")) >= 0))
                    {
                        cmbTime.Items.Add(time);
                    }
                }
            }
            else
            {
                //Credit to https://stackoverflow.com/questions/26198085/while-looping-an-array
                foreach (var time in AdministratorForm.fTimes)
                {
                    cmbTime.Items.Add(time);
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Validate that a docter was selected and that there are available timeslots
            if ((rbtnGoosen.Checked || rbtnVisagie.Checked || rbtnEngelbrecht.Checked || rbtnVisser.Checked) && cmbTime.SelectedIndex != -1)
            {
                string sDocter = "";

                //Get selected docter
                if (rbtnGoosen.Checked)
                    sDocter = rbtnGoosen.Text;
                else if (rbtnVisagie.Checked)
                    sDocter = rbtnVisagie.Text;
                else if (rbtnEngelbrecht.Checked)
                    sDocter = rbtnEngelbrecht.Text;
                else
                    sDocter = rbtnVisser.Text;

                try
                {
                    //Validate that the appointment does not already exist
                    fConn.Open();
                    //SQL command (Select all records)
                    SqlCommand comm = new SqlCommand($"SELECT Date_Time, Doctor FROM tblAppointments WHERE Doctor = '{sDocter}' AND Date_Time = '{dtpAppointment.Value.Date.ToShortDateString() + " " + cmbTime.Text}'", fConn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet dataset = new DataSet();
                    adapter.SelectCommand = comm;
                    adapter.Fill(dataset, "tblAppointments");
                    fConn.Close();

                    //If no exact record of this appointment exists continue
                    if (dataset.Tables["tblAppointments"].Rows.Count == 0)
                    {
                        fConn.Open();
                        //SQL command (Insert new record)
                        SqlCommand command = new SqlCommand($"INSERT INTO tblAppointments(Date_Time, Doctor, Status, Complete, Cancelled) VALUES('{dtpAppointment.Value.Date.ToShortDateString() + " " + cmbTime.Text}', '{sDocter}', 'Available', 0, 0)", fConn);
                        command.ExecuteNonQuery();
                        fConn.Close();

                        //Display added available appointment in frmAdministrator  
                        AdministratorForm.DisplayAppoitments();
                    }
                    else
                        //Display detailed error message that the appointment already exists
                        MessageBox.Show("Dr. " + dataset.Tables["tblAppointments"].Rows[0][1].ToString() + " is already scheduled for an appointment on " + ((DateTime)dataset.Tables["tblAppointments"].Rows[0][0]).ToShortDateString() + " at " + ((DateTime)dataset.Tables["tblAppointments"].Rows[0][0]).ToString("HH:mm"), "Appointment exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (SqlException ex)
                {
                    //Display SQL error in label
                    MessageBox.Show(ex.Message, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Display error message
                MessageBox.Show("Please check that a doctor and timeslot is selected", "Insufficient information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
