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
    public partial class openpastpapersthree : Form
    {
        public openpastpapersthree()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filename = "ds1.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filename = "ds3.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string filename = "ds5.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string filename = "dsp1.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string filename = "dsp5.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string filename = "dsp6.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button3_Click(object sender, EventArgs e)
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
