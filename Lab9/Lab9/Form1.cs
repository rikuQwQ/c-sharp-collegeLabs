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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadTable()
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.connectionString))
                {
                    connect.Open();

                    string sqlExp = "select [policyID],[lastName], [name], [address],[dateOfBirth],[dapartmentName] " +
                        "from Patient join [dbo].[Department] on [dbo].[Department].[departmentID] = [dbo].[Patient].[departmentID] ";
                    SqlCommand command = new SqlCommand(sqlExp, connect);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                    }
                    reader.Close();
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCombobox()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.connectionString))
                {
                    connect.Open();

                    string sqlExp = "select [dapartmentName] from [dbo].[Department]";
                    SqlCommand command = new SqlCommand(sqlExp, connect);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader[0]);
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
        private void TableFiltered()
        {
            dataGridView1.Rows.Clear();
            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.connectionString))
                {
                    connect.Open();

                    string sqlExp = "select [policyID],[lastName], [name], [address],[dateOfBirth],[dapartmentName] " +
                        "from Patient join [dbo].[Department] on [dbo].[Department].[departmentID] = [dbo].[Patient].[departmentID] where [dapartmentName] = '" + comboBox1.Text + "'";
                    SqlCommand command = new SqlCommand(sqlExp, connect);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadCombobox();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            TableFiltered();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            DialogResult result = form2.ShowDialog();

            if(result == DialogResult.OK)
            {
                LoadTable();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            int index = int.Parse(dataGridView1.Rows[row].Cells[0].Value?.ToString());
            Form3 form3 = new Form3(index);
            DialogResult result = form3.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadTable();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            int index = int.Parse(dataGridView1.Rows[row].Cells[0].Value?.ToString());

            try
            {
                using (SqlConnection connect = new SqlConnection(Connect.connectionString))
                {
                    connect.Open();
                    string sqlExp = String.Format("delete from [dbo].[Patient] where [policyID] = @policyId");
                    dataGridView1.Rows.RemoveAt(row);
                    SqlCommand command = new SqlCommand(sqlExp, connect);
                    command.Parameters.AddWithValue("@policyId", index);
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
