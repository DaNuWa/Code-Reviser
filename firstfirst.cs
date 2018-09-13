using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Rapid
{
    public partial class ooponeone : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter da;

        public ooponeone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stream mystream;
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if ((mystream = open.OpenFile()) != null)
                {


                    string strfilename = open.FileName;
                    string filetext = File.ReadAllText(strfilename);
                  //  textBoxID.Text = filetext;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.myimages WHERE ID = '" + button4.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);

         //   textBoxNAME.Text = table.Rows[0][1].ToString();
          //  pdf.Text = table.Rows[0][3].ToString();

         //  byte[] img = (byte[])table.Rows[0][3];

          // MemoryStream ms = new MemoryStream(img);
            //pictureBox1.Text = table.Rows[0][3].ToString();

          //  pictureBox1.Image = Image.FromStream(ms);

            da.Dispose();

        }



        private void ooponeone_Load(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.firstyearsecondsemjava WHERE code_name = '" + button3.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);

          
            textBoxDESC.Text = table.Rows[0][1].ToString();

          

            da.Dispose();

        }

      /*  private void button2_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.firstyearsecondsemjava WHERE code_name = '" + button2.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();

        }*/

        private void ooponeone_Load_1(object sender, EventArgs e)
        {

        }

        private void textBoxDESC_TextChanged(object sender, EventArgs e)
        {
            textBoxDESC.ScrollBars = ScrollBars.Both;
            textBoxDESC.WordWrap = false;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void code1_Click_1(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + code1.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button7.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button8.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button9.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" +button13.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button12.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button11.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button14.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button21.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button20.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button19.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button18.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button6.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button17.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button22.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button23.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

      /*  private void button24_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button24.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }*/

        private void button25_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button25.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button27.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button29.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button30.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button28.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button26_Click(object sender, EventArgs e)
        {
             string selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button26.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.oneone_java WHERE Name = '" + button7.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pastpapers pa = new pastpapers();
            this.Hide();
            pa.Show();
        }
    }
}

