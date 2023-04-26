using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            Massive mas = new Massive();

            try
            {
                mas.Size = int.Parse(textBoxSize.Text);
            }
            catch
            {
                MessageBox.Show("Введите число");
                textBoxSize.Clear();
                return;
            }

            if(mas.Size == 0)
            {
                MessageBox.Show("Введите любое число, кроме нуля");
                textBoxSize.Clear();
                return;
            }
            
            labelMassive.Text = mas.CreateMas();
            labelSum.Text = mas.SummMas();
            labelReverse.Text = mas.ReverseMas();
            labelChangePlace.Text = mas.ChangeElem();

            panel2.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelMassive_Click(object sender, EventArgs e)
        {
            labelMassive.AutoSize = true;
            labelChangePlace.AutoSize = true;
            labelReverse.AutoSize = true;
            labelSum.AutoSize = true;
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            textBoxSize.Clear();
            labelMassive.Text = "";
            panel2.Visible = false;
        }
    }
}
