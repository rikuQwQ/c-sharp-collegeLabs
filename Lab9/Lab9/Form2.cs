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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.connectionString))
                {
                    connect.Open();

                    string sqlExp = String.Format($"insert into [dbo].[Patient] values(@patientId, @lastName, @name, @address, @dateofBirth, @departmentId)");
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
        }
    }
}
