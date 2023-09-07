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
    public partial class Test_Tools : Form
    {
        public Test_Tools()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"player 1 gender : {((rbtn_male_p1.Checked == true) ? "male" : "female")} , player 2 gender : {((rbtn_male_p2.Checked == true) ? "male" : "female")}");
        }
    }
}
