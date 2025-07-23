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

namespace Desktop_Application
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            //Credit to https://www.nuget.org/packages/MaterialSkin.2
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue900, Accent.Blue700, TextShade.WHITE);
        }

        //Declare fields
        private bool bLogin;
        private int checkLoad = 0;

        private void picBackground_Resize(object sender, EventArgs e)
        {
            int width = this.Width / 2 - pnlLogin.Width / 2;
            int heigth = this.Height / 2 - pnlLogin.Height / 2;
            pnlLogin.Location = new Point(width, heigth);
        }

        private void txtAdministratorID_TextChanged(object sender, EventArgs e)
        {
            //material skin 2's textboxes set text at beginning which activates textchanged event
            checkLoad++;
            if (txtAdministratorID.Text == "" && checkLoad >= 2)
            {
                erpLogin.SetError(txtAdministratorID, "Please enter ID");
                bLogin = false;
            }
            else
                erpLogin.SetError(txtAdministratorID, "");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //material skin 2's textboxes set text at beginning which activates textchanged event
            checkLoad++;
            if (txtPassword.Text == "" && checkLoad >= 2)
            {
                erpLogin.SetError(txtPassword, "Please enter password");
                bLogin = false;
            }
            else
                erpLogin.SetError(txtPassword, "");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Assume input is correct
            bLogin = true;

            //Validate input
            txtAdministratorID_TextChanged(sender, e);
            txtPassword_TextChanged(sender, e);

            //Validate input
            if (bLogin)
                try
                {
                    //Declare variables
                    string sAdministratorID = "";
                    string sPassword = "";
                    string sName = "";
                    string sSurname = "";

                    //Set connection to web application's database
                    SqlConnection conn = new SqlConnection(@System.Configuration.ConfigurationManager.ConnectionStrings["AppConnection"].ConnectionString);
                    conn.Open();
                    //Search for Administrator on system
                    SqlCommand comm = new SqlCommand($"SELECT AdministratorID, Password, Name, Surname FROM tblAdministrators WHERE AdministratorID = '{txtAdministratorID.Text}'", conn);
                    SqlDataReader reader;
                    reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        sAdministratorID = reader.GetValue(0).ToString();
                        sPassword = reader.GetValue(1).ToString();
                        sName = reader.GetValue(2).ToString();
                        sSurname = reader.GetValue(3).ToString();
                    }
                    conn.Close();

                    //If entered details match with database
                    if (txtAdministratorID.Text == sAdministratorID && txtPassword.Text == sPassword)
                    {
                        //Open frmAdministrator
                        frmAdministrator AdministratorForm = new frmAdministrator();
                        //Transfer the connection and the administrator's name and surname
                        AdministratorForm.fConn = conn;
                        AdministratorForm.fName = sName;
                        AdministratorForm.fSurname = sSurname;
                        AdministratorForm.Show();
                        //Hide frmLogin
                        this.Hide();
                    }
                    else
                    {
                        //Display error in label
                        MessageBox.Show("Administrator ID or password is incorrect.", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (SqlException ex)
                {
                    //Display SQL error in label
                    MessageBox.Show(ex.Message, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }     
    }
}
