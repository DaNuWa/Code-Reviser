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
    public partial class csharpcodestwoone : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataAdapter da;
        public csharpcodestwoone()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxDESC.ScrollBars = ScrollBars.Both;
            textBoxDESC.WordWrap = false;
        }

        private void csharpcodestwoone_Load(object sender, EventArgs e)
        {

        }

        private void code1_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_csharp WHERE Name = '" + code1.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_csharp WHERE Name = '" + button7.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_csharp WHERE Name = '" + button8.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_csharp WHERE Name = '" + button9.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_csharp WHERE Name = '" + button13.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_csharp WHERE Name = '" + button12.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_csharp WHERE Name = '" + button11.Text + "'";

            command = new MySqlCommand(selectQuery, connection);

            da = new MySqlDataAdapter(command);

            DataTable table = new DataTable();

            da.Fill(table);


            textBoxDESC.Text = table.Rows[0][1].ToString();



            da.Dispose();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            string selectQuery = "SELECT * FROM db_images.twoone_csharp WHERE Name = '" + button14.Text + "'";

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

        private void button2_Click(object sender, EventArgs e)
        {
            samplecodes sa = new samplecodes();
            this.Hide();
            sa.Show();
        }
    }
}
