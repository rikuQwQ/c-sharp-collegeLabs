using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab9
{
    public partial class Form3 : Form
    {
        int index = 0;
        public Form3(int index)
        {
            InitializeComponent();
            this.index = index;

        }

        private void InfoLoad()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.connectionString))
                {
                    connect.Open();

                    string sqlExp = String.Format($"select * from [dbo].[Patient] where [policyID] = " + index);
                    SqlCommand command = new SqlCommand(sqlExp, connect);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            textBox1.Text = reader[0].ToString();
                            textBox2.Text = reader[1].ToString();
                            textBox3.Text = reader[2].ToString();
                            textBox4.Text = reader[3].ToString();
                            dateTimePicker1.Value = DateTime.Parse(reader[4].ToString());
                            textBox5.Text = reader[5].ToString();
                        }

                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.connectionString))
                {
                    connect.Open();
                    string sqlExp = String.Format($"update [dbo].[Patient] set [lastName] =  @lastName, [name] = @name, [address] = @address, [dateOfBirth] = @dateofBirth, [departmentID] = @departmentId where [policyID] = @patientId");
                    SqlCommand command = new SqlCommand(sqlExp, connect);
                    command.Parameters.AddWithValue("@patientId", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@lastName", textBox2.Text);
                    command.Parameters.AddWithValue("@name", textBox3.Text);
                    command.Parameters.AddWithValue("@address", textBox4.Text);
                    command.Parameters.AddWithValue("@dateofBirth", dateTimePicker1.Value.Date);
                    command.Parameters.AddWithValue("@departmentId", int.Parse(textBox5.Text));
                    command.ExecuteNonQuery();

                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = DialogResult.OK;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            InfoLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index += 1;
            InfoLoad();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index -= 1;
            InfoLoad();
        }
    }
}
