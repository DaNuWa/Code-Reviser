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
    public partial class samplecodes : Form
    {
        public samplecodes()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*firstfirst first=new firstfirst();
            first.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
         

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            }

        

      

      
        private void samplecodes_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void cmboxtwoone_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void cmboxtwoone_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmboboxonetwo_SelectedIndexChanged(object sender, EventArgs e)
        {

          

            
        }

      

      

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdown1.selectedValue.ToString() == "Object oriented programming")
            {
                ooponeone op = new ooponeone();
                op.Show();
                this.Hide();

            }
            else if (bunifuDropdown1.selectedValue.ToString() == "C++")
            {
                opencodescplusfirstsem op = new opencodescplusfirstsem();
                op.Show();


            }
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdown2.selectedValue.ToString() == "Data structures")
            {
                 javacodestwoone op = new javacodestwoone();
                

                op.Show();
                this.Hide();

            }
            else if (bunifuDropdown2.selectedValue.ToString() == "ShellScript and C")
            {

                //  csharpcodestwoone op = new csharpcodestwoone();
                openshellscriptandc op = new openshellscriptandc();
                this.Hide();

                op.Show();
            }
        }

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {
            if (bunifuDropdown3.selectedValue.ToString() == "Algorithm")
            {
               onetwo op = new onetwo();
                op.Show();
                this.Hide();

            }
            else if (bunifuDropdown3.selectedValue.ToString() == "c#")
            {
                csharpcodestwoone op = new csharpcodestwoone();
                op.Show();

                this.Hide();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void samplecodes_Load_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            firstinterface f = new firstinterface();
            this.Hide();
            f.Show();
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
