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

    public partial class Loadingscreen : Form
    {
        public Loadingscreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 1;
                if(rectangleShape2.Width>=530)
                {
                    timer1.Stop();
                    firstinterface op = new firstinterface();
                    op.Show();
                    Visible = false;
                    this.Hide();
                }
                

            }
            catch
            {
                return;
            }

        }

        private void Loadingscreen_Load(object sender, EventArgs e)
        {

        }
    }
}
