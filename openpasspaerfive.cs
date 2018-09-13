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
    public partial class openpasspaerfive : Form
    {
        public openpasspaerfive()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string filename = "al0.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string filename = "al1.pdf";
            System.Diagnostics.Process.Start(filename);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string filename = "alp1.pdf";
            System.Diagnostics.Process.Start(filename);

        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        }

        private void openpasspaerfive_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pastpapers pa = new pastpapers();
            this.Hide();
            pa.Show();
        }
    }
}
