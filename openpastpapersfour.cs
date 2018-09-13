using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rapid
{
    public partial class openpastpapersfour : Form
    {
        public openpastpapersfour()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string filename = "os1.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filename = "os2.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string filename = "os5.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string filename = "os6.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filename = "os7.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string filename = "osp1.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "osp2.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string filename = "osp3.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string filename = "osp6.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filename = "osp7.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            pastpapers pa = new pastpapers();
            this.Hide();
            pa.Show();

        }
    }
}
