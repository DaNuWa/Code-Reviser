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
    public partial class openpastpaperstwo : Form
    {
        public openpastpaperstwo()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string filename = "2011cplus.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string filename = "2012cplus.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string filename = "2015cplus.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string filename = "2016cplus.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string filename = "cp1.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string filename = "cp2.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string filename = "cp5.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pastpapers pa = new pastpapers();
            this.Hide();
            pa.Show();
        }
    }
}
