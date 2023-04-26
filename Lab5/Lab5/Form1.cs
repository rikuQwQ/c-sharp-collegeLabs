using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        Data Matrix = new Data();
        public Form1()
        {
            InitializeComponent();

            labelPositive.Visible = false;
            labelNegative.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Data.n+1;
            dataGridView1.ColumnCount = Data.n;
            dataGridView2.RowCount = Data.n+1;
            dataGridView2.ColumnCount = Data.n;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            Matrix.CreateArray();
            Matrix.Print(dataGridView1, Data.mas);
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            Matrix.DoubleArray();
            Matrix.Print(dataGridView2, Data.masChange);
        }

        private void btnTriple_Click(object sender, EventArgs e)
        {
            Matrix.TripleSecondColumn();
            Matrix.Print(dataGridView2, Data.masChange);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            Matrix.Above();
            Matrix.Print(dataGridView2, Data.masChange);
        }

        private void btnAmount_Click(object sender, EventArgs e)
        {
            int positive = 0;
            int negative = 0;

            positive = Matrix.Positive();
            negative = Matrix.Negative();

            labelPositive.Text = positive.ToString();
            labelNegative.Text = negative.ToString();

            labelPositive.Visible = true;
            labelNegative.Visible = true;
        }
    }
}
