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
    public partial class pastpapers : Form
    {
        public pastpapers()
        {
            InitializeComponent();
        }

       

     
      
      

        private void dropdownonetwo_onItemSelected(object sender, EventArgs e)
        {
           /* if (dropdownonetwo.SelectedItem.ToString()==( "Data structures");
            {
                openpastpapersthree op = new openpastpapersthree();
                op.Show();

            }
            else if (cmboxseconsemester.SelectedItem.ToString() == " C and Shellscript")

            {
                openpastpapersfour op = new openpastpapersfour();
                op.Show();

            }*/

          
        }

        private void dropdownonetwo_onItemSelected_1(object sender, EventArgs e)
        {
            if (dropdownonetwo.selectedValue.ToString() == "Data structures")
            {
                openpastpapersthree op = new openpastpapersthree();
                op.Show();
                this.Hide();
            }
            else if (dropdownonetwo.selectedValue.ToString() == "C and shellscript")
            {
                openpastpapersfour op = new openpastpapersfour();
                op.Show();
                this.Hide();
            }
        }

        private void bunifutwoone_onItemSelected(object sender, EventArgs e)
        {
           if (bunifutwoone.selectedValue.ToString() == "Algorithm")
            {
                openpasspaerfive op = new openpasspaerfive();
                op.Show();
                this.Hide();
            }
            else if (bunifutwoone.selectedValue.ToString() == "Rapid application development")
            {
                openpastpaperssix op = new openpastpaperssix();
                op.Show();
                this.Hide();
            }
        }

        private void bunifuoneone_onItemSelected_1(object sender, EventArgs e)
        {
            if (bunifuoneone.selectedValue.ToString() == "Object oriented programming")
            {
                openpastpaers op = new openpastpaers();
                op.Show();
                this.Hide();
            }
            else if (bunifuoneone.selectedValue.ToString() == "C++")
            {
                openpastpaperstwo op = new openpastpaperstwo();
                op.Show();
                this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstinterface ff = new firstinterface();
            ff.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            goal g = new goal();
            this.Hide();
            g.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            next n = new next();
            this.Hide();
            n.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            aboutus ab = new aboutus();
            this.Hide();
            ab.Show();
        }
    }
}
