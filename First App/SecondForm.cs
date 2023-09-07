using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_App
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            DialogResult result = MessageBox.Show($"Login button have been clicked\nUsername: {username}, Password: {password}", "Login validate", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                // open new form
                // MessageBox.Show("new form");
                Calculator calculator = new Calculator();
                this.Hide();
                calculator.ShowDialog();
                this.Close();
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
