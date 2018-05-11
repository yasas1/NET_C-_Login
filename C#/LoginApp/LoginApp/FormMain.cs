using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class FormMain : Form
    {
        public FormMain(string x = "")
        {
            InitializeComponent();
            lUsername.Text = x;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //lUsername.Text = FormLogin.SetValueForUsername;
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormLogin objMain = new FormLogin();
            this.Close();
            objMain.Show();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
