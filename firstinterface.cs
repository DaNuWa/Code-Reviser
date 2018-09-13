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
    public partial class firstinterface : Form
    {
        private System.Windows.Forms.LinkLabel linkLabel1;
        public firstinterface()
        {
            InitializeComponent();
        }

        private void firstinterface_Load(object sender, EventArgs e)
        {

        }
        protected override CreateParams CreateParams
        {
            get
            {
                var parms = base.CreateParams;
                parms.Style &= ~0x02000000;  // Turn off WS_CLIPCHILDREN
                return parms;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            samplecodes sa = new samplecodes();
            sa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pastpapers op = new pastpapers();
            op.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            goal gl = new goal();
            gl.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            next n = new next();
            this.Hide();
            n.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            firstinterface f = new firstinterface();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aboutus a = new aboutus();
            this.Hide();
            a.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            /*  try
              {
                  VisitLink();
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Unable to open link that was clicked.");
              }
          }

          private void VisitLink()
          {
              // Change the color of the link text by setting LinkVisited   
              // to true.  
              linkLabel1.LinkVisited = true;
              //Call the Process.Start method to open the default browser   
              //with a URL:  
              System.Diagnostics.Process.Start("http://www.microsoft.com");
          }*/
        }
    }
}
