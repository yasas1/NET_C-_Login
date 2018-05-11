using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginApp
{
    public partial class FormLogin : Form
    {
        //public static string SetValueForUsername = "";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Dell\\source\\C#\\DB\\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");

            string query = "select * from users where username='" + tUsername.Text.Trim() + "' and  password = '" + tPassword.Text.Trim() + "' ";

            SqlDataAdapter sda = new SqlDataAdapter(query,sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                string SetValueForUsername = "";
                SetValueForUsername = tUsername.Text;

                FormMain objMain = new FormMain(SetValueForUsername);
                this.Hide();
                objMain.Show();

            }
            else
            {
                MessageBox.Show("Check Your User Name and Password");
            }
                
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            tUsername.Clear();
            tPassword.Clear();
        }
    }
}
