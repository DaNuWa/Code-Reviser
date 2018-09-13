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
    public partial class openpastpaers : Form
    {
        public openpastpaers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void openpastpaers_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "2011oop.pdf";
            System.Diagnostics.Process.Start(filename);

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string filename = "2012oop.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string filename = "2013oop.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string filename = "2014oop.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button8_Click(object sender, EventArgs e)
        {

            string filename = "2015oop.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button9_Click(object sender, EventArgs e)
        {

            string filename = "2016oop.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            string filename = "2017oop.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button17_Click(object sender, EventArgs e)
        {

            string filename = "prcoop1.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button16_Click(object sender, EventArgs e)
        {

            string filename = "prcoop2.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            pastpapers pa = new pastpapers();
            this.Hide();
            pa.Show();
        }
    }
}
