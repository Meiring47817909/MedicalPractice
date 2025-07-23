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
    public partial class frmAdministrator : MaterialForm
    {
        public frmAdministrator()
        {
            InitializeComponent();
            //Credit to https://www.nuget.org/packages/MaterialSkin.2
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.Blue600, Accent.Blue400, TextShade.WHITE);
        }

        //Declare field variables
        public string fName;
        public string fSurname;
        public SqlConnection fConn;
        public string[] fTimes = { "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00" };
        private SqlCommand comm;

        private void frmAdministrator_Load(object sender, EventArgs e)
        {
            //Welcome administrator
            this.Text = "Welcome " + fName + " " + fSurname;
            DisplayAppoitments();
        }

        public void DisplayAppoitments()
        {
            try
            {
                //SQL command (Display appointments)
                fConn.Open();
                comm = new SqlCommand(@"SELECT AppointmentID, PatientID, Date_Time, Doctor, Status, Complete, Cancelled FROM tblAppointments", fConn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();
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

        private void dtgAppointments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //Credit to https://www.youtube.com/watch?v=lVYvDJn-r9E
            //Change cell colour based on status
            if (e.Value != null)
            {
                if (e.ColumnIndex == 4)
                {
                    e.CellStyle.ForeColor = Color.White;

                    if (e.Value.ToString() == "Available")
                        e.CellStyle.BackColor = Color.LimeGreen;
                    else if (e.Value.ToString() == "Booked")
                        e.CellStyle.BackColor = Color.Green;
                    else if (e.Value.ToString() == "Complete")
                        e.CellStyle.BackColor = Color.DarkGreen;
                    else if (e.Value.ToString() == "Invoiced")
                    {
                        e.CellStyle.ForeColor = Color.Black;
                        e.CellStyle.BackColor = Color.Yellow;
                    }                      
                    else
                        e.CellStyle.BackColor = Color.Red;
                }
            }
        }

        private void EditDatabase(string sQuery)
        {
            try
            {
                //SQL command (Invoice appointment)
                fConn.Open();
                comm = new SqlCommand(sQuery, fConn);
                comm.ExecuteNonQuery();
                fConn.Close();

                //Display appointments
                DisplayAppoitments();
            }
            catch (SqlException ex)
            {
                //Display SQL error in label
                MessageBox.Show(ex.Message, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validate input
            if (dtgAppointments.CurrentRow != null)
            {
                //Change status to complete if complete checked
                if (e.ColumnIndex == 5 && (bool)dtgAppointments.Rows[dtgAppointments.CurrentRow.Index].Cells[5].Value == false && (bool)dtgAppointments.Rows[dtgAppointments.CurrentRow.Index].Cells[6].Value == false && dtgAppointments.Rows[dtgAppointments.CurrentRow.Index].Cells[4].Value.ToString() == "Booked")
                {
                    dtgAppointments.Rows[dtgAppointments.CurrentRow.Index].Cells[5].ReadOnly = true;
                    EditDatabase($"UPDATE tblAppointments SET Status = 'Complete', Complete = 1 WHERE AppointmentID = {dtgAppointments.Rows[e.RowIndex].Cells[0].Value}");
                }
                //Change status to cancelled if cancelled checked
                else if (e.ColumnIndex == 6 && (bool)dtgAppointments.Rows[dtgAppointments.CurrentRow.Index].Cells[6].Value == false && (bool)dtgAppointments.Rows[dtgAppointments.CurrentRow.Index].Cells[5].Value == false && dtgAppointments.Rows[dtgAppointments.CurrentRow.Index].Cells[4].Value.ToString() != "Invoiced")
                {
                    dtgAppointments.Rows[e.RowIndex].Cells[6].ReadOnly = true;
                    EditDatabase($"UPDATE tblAppointments SET Status = 'Cancelled', Cancelled = 1 WHERE AppointmentID = {dtgAppointments.Rows[e.RowIndex].Cells[0].Value}");
                }
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            //Only invoice appointment if selected appointment is completed
            if (dtgAppointments.CurrentRow != null)
                if (dtgAppointments.CurrentRow.Cells[4].Value.ToString() == "Complete")
                    EditDatabase($"UPDATE tblAppointments SET Status = 'Invoiced' WHERE AppointmentID = {dtgAppointments.CurrentRow.Cells[0].Value.ToString()}");
                else
                    //Display input error
                    MessageBox.Show("Please ensure that a complete appointment is selected", "Insufficient information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Only delete possible cancelled appointments if there are records
            if (dtgAppointments.RowCount > 0)
                EditDatabase(@"DELETE FROM tblAppointments WHERE Status = 'Cancelled'");
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Credit to https://stackoverflow.com/questions/38768737/interaction-between-forms-how-to-change-a-control-of-a-form-from-another-form
            //Open frmCreateAppointment
            var myAdminForm = new frmCreateAppointment(this);
            myAdminForm.fConn = fConn;
            myAdminForm.ShowDialog();
        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Credit to https://stackoverflow.com/questions/38768737/interaction-between-forms-how-to-change-a-control-of-a-form-from-another-form
            //Open frmCreateAppointment
            var myMoveForm = new frmMoveAppointment(this);
            myMoveForm.fConn = fConn;
            myMoveForm.ShowDialog();
        }

        private void registerPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Credit to https://stackoverflow.com/questions/38768737/interaction-between-forms-how-to-change-a-control-of-a-form-from-another-form
            //Open frmCreateAppointment
            var myRegisterForm = new frmRegisterPatient(this);
            myRegisterForm.fConn = fConn;
            myRegisterForm.ShowDialog();
        }

        private void dtgAppointments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dtgAppointments.CurrentRow != null)
            {
                //Only view more detail for booked, complete or invoiced appointments
                if (dtgAppointments.Rows[dtgAppointments.CurrentRow.Index].Cells[4].Value.ToString() != "Available")
                {
                    //Credit to https://stackoverflow.com/questions/38768737/interaction-between-forms-how-to-change-a-control-of-a-form-from-another-form
                    //Open frmCreateAppointment
                    var myViewForm = new frmViewDetails(this);
                    myViewForm.fConn = fConn;
                    myViewForm.fAppointmentID = int.Parse(dtgAppointments.Rows[dtgAppointments.CurrentRow.Index].Cells[0].Value.ToString());
                    myViewForm.fPatientID = dtgAppointments.Rows[dtgAppointments.CurrentRow.Index].Cells[1].Value.ToString();
                    myViewForm.ShowDialog();
                }
            }
        }

        private void frmAdministrator_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }        
    }
}
