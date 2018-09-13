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
    public partial class openpastpaperssix : Form
    {
        public openpastpaperssix()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string filename = "radp0.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "rad0.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string filename = "radp1.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filename = "rad0.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            pastpapers pa = new pastpapers();
            this.Hide();
            pa.Show();
        }
    }
}
