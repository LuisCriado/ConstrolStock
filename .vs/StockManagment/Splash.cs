using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagment
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            
        }

        int progress_value = 0;

        private void Splash_Load_1(object sender, EventArgs e)
        {
            bunifuCircleProgress2.IsPercentage = true;
            bunifuCircleProgress2.Animated = false;
            bunifuCircleProgress2.ValueByTransition = 0;

            timer1.Enabled = true;
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progress_value < 101)
            {
                bunifuCircleProgress2.ValueByTransition = progress_value;
                progress_value += 1;
            }
            else
            { 
            timer1.Enabled = false;
            this.Hide();
                Login Obj = new Login();
                Obj.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}