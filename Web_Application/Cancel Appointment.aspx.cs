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
    public partial class Cancel_Appointment : System.Web.UI.Page
    {
        //Field variables
        public SqlConnection conn;
        public SqlCommand comm;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Validate sessions
            if (Session["Connection"] != null && Session["PatientID"] != null)
            {
                //Set connection here (saves code)
                conn = new SqlConnection(Session["Connection"].ToString());

                //For first time page loads
                if (!IsPostBack)
                    //Display patient's bookings
                    Display_Booked_Appointments();
            }
            else
            {
                //Display error in label
                lblCancelOrError.ForeColor = System.Drawing.Color.Red;
                lblCancelOrError.Text = "Session failed";
            }
        }

        protected void Display_Booked_Appointments()
        {
            try
            {
                //SQL command (Display patient's booked appointments)
                conn.Open();
                comm = new SqlCommand($"SELECT AppointmentID, Date_Time, Doctor, Type, Price, Status FROM tblAppointments WHERE PatientID = '{Session["PatientID"]}' AND Status = 'Booked'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();
                adapter.SelectCommand = comm;
                adapter.Fill(dataset);
                grdBookedAppointments.DataSource = dataset;
                grdBookedAppointments.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                //Display SQL error in label
                lblCancelOrError.ForeColor = System.Drawing.Color.Red;
                lblCancelOrError.Text = ex.Message;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            //Check that an appointment is selected
            if (grdBookedAppointments.SelectedIndex != -1)
            {
                try
                {
                    //SQL command (Cancel appointment)
                    conn.Open();
                    comm = new SqlCommand($"UPDATE tblAppointments SET PatientID = null, Type = null, Price = null, Status = 'Available' WHERE AppointmentID = {grdBookedAppointments.SelectedRow.Cells[1].Text}", conn);
                    comm.ExecuteNonQuery();

                    //Display cancelled appointment
                    lblCancelOrError.ForeColor = System.Drawing.Color.Green;
                    lblCancelOrError.Text = "Your appointment has been cancelled successfully.";                    
                    Display_Booked_Appointments();
                }
                catch (SqlException ex)
                {
                    //Display SQL error in label
                    lblCancelOrError.ForeColor = System.Drawing.Color.Red;
                    lblCancelOrError.Text = ex.Message;
                }
            }
            else
            {
                //Display error in label
                lblCancelOrError.ForeColor = System.Drawing.Color.Red;
                lblCancelOrError.Text = "Please ensure that an appointment is selected.";
            }
        }
    }
}