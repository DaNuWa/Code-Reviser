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
    public partial class onetwo : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter da;
        public onetwo()
        {
            InitializeComponent();
        }

        private void onetwo_Load(object sender, EventArgs e)
        {

        }

       

        private void btnbinarysearch_Click_1(object sender, EventArgs e)
        {

            String selectQuery = "SELECT * FROM db_images.firstyearsecondsemjava WHERE code_name = '" + btnbinarysearch.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxjavasecondsem_TextChanged(object sender, EventArgs e)
        {
            textBoxDESC.ScrollBars = ScrollBars.Both;
           textBoxDESC.WordWrap =false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java WHERE Name = '" + button6.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java  WHERE Name = '" + button7.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java  WHERE Name = '" + button2.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java  WHERE Name = '" + button4.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java  WHERE Name = '" + button3.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java  WHERE Name = '" + button5.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java  WHERE Name = '" + button12.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java  WHERE Name = '" + button11.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java  WHERE Name = '" + button9.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java  WHERE Name = '" + button8.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java WHERE Name = '" + button20.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java WHERE Name = '" + button19.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java WHERE Name = '" + button18.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java WHERE Name = '" + button17.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java WHERE Name = '" + button14.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_java WHERE Name = '" + button13.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            samplecodes sa = new samplecodes();
            this.Hide();
            sa.Show();
        }
    }
}
