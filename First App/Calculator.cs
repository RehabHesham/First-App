using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_App
{
    public partial class Calculator : Form
    {
        float num1 = 0;
        float num2 = 0;
        char operation = ' ';
        public Calculator()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save");
        }

        private void openLastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open last");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd_open.ShowDialog();
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult color = cd_color.ShowDialog();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            rtb_results.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            rtb_results.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            rtb_results.Text += "3";
        }


        private void btn_number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            rtb_results.Text += btn.Text;
        }
        private void btn_operation_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (rtb_results.Text == "") num1 = 0;
            else num1 = Convert.ToSingle(rtb_results.Text);

            operation = btn.Text[0];

            rtb_results.Text = "";
        }


        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (rtb_results.Text == "") num1 = 0;
            else num1 = Convert.ToSingle(rtb_results.Text);

            operation = '+';

            rtb_results.Text = "";
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (rtb_results.Text == "") num1 = 0;
            else num1 = Convert.ToSingle(rtb_results.Text);

            operation = '-';

            rtb_results.Text = "";
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (rtb_results.Text == "") num2 = 0;
            else num2 = Convert.ToSingle(rtb_results.Text);


            float result;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    MessageBox.Show("Invalid operation");
                    result = 0;
                    break;
            }

            rtb_results.Text = result.ToString();
        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_results.Text = "";
        }
    }
}
