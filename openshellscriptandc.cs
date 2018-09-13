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

namespace Rapid
{
    public partial class openshellscriptandc : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter da;

        public openshellscriptandc()
        {
            InitializeComponent();
        }

        private void code1_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + code1.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void openshellscriptandc_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button9.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button10.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button11.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button13.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button14.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button15.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button16.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button21.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button20.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button19.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button18.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button3.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

      
        private void button17_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button17.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button22.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button23.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button25.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button27.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button29.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button30.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button28.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button26.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button4.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button5.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String selectQuery = "SELECT * FROM db_images.c_and_shell WHERE Name = '" + button2.Text + "'";

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

        private void textBoxDESC_TextChanged(object sender, EventArgs e)
        {
            textBoxDESC.ScrollBars = ScrollBars.Both;
            textBoxDESC.WordWrap = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            samplecodes sa = new samplecodes();
            this.Hide();
            sa.Show();
        }
    }
}
