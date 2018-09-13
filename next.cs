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
    public partial class next : Form
    {
        public next()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            firstinterface f = new firstinterface();
            this.Hide();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            goal g = new goal();
            this.Hide();
            this.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            next ne = new next();
            this.Hide();
            ne.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            aboutus ab = new aboutus();
            this.Hide();
            ab.Show();
        }

        private void next_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
