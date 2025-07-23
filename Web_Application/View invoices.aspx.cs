//Meiring van Niekerk, 47817909
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application
{
    public partial class View_invoices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Validate sessions
            if (Session["Connection"] != null && Session["PatientID"] != null)
            {    
                try
                {
                    //SQL command (Display invoiced appointments)
                    SqlConnection conn = new SqlConnection(Session["Connection"].ToString());
                    conn.Open();
                    SqlCommand comm = new SqlCommand($"SELECT AppointmentID, Date_Time, Doctor, Type, Price, Status FROM tblAppointments WHERE PatientID = '{Session["PatientID"]}' AND Status = 'Invoiced'", conn);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet dataset = new DataSet();
                    adapter.SelectCommand = comm;
                    adapter.Fill(dataset);
                    grdViewInvoices.DataSource = dataset;
                    grdViewInvoices.DataBind();
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    //Display SQL error in label
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = ex.Message;
                }
            }
            else
            {
                //Display error in label
                lblError.ForeColor = System.Drawing.Color.Red;
                lblError.Text = "Session failed";
            }
        }
    }
}