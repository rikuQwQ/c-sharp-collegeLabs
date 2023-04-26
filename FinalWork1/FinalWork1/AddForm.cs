using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWork1
{
    public partial class AddForm : Form
    {
        List<Housing> hh = new List<Housing>();
        bool isHouse;
        public AddForm(List<Housing> hh)
        {
            InitializeComponent();
            this.hh = hh;

            ChangeToHouse();
            isHouse = true;
            lbTypeOfBuilding.Text = "Дом";
        }
        public void AddHousing(Housing housing)
        {
            hh.Add(housing);
            DialogResult = DialogResult.OK;
        }

        public void ChangeToFlat()
        {
            lbFloors.Visible = false;
            tbAmountOfFloors.Visible = false;

            lbFlatNumber.Visible = true;
            tbFlatNumber.Visible = true;
            lbAmountOfRooms.Visible = true;
            tbAmountOfRooms.Visible = true;
        }
        public void ChangeToHouse()
        {
            lbFlatNumber.Visible = false;
            tbFlatNumber.Visible = false;
            lbAmountOfRooms.Visible = false;
            tbAmountOfRooms.Visible = false;

            lbFloors.Visible = true;
            tbAmountOfFloors.Visible = true;
        }

        private void домToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isHouse = true;
            lbTypeOfBuilding.Text = "Дом";
            ChangeToHouse();
        }

        private void квартираToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isHouse = false;
            lbTypeOfBuilding.Text = "Квартира";
            ChangeToFlat();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isHouse)
            {
                AddHousing(new House(tbFullname.Text, lbTypeOfBuilding.Text, tbStreet.Text, int.Parse(tbHomeNumber.Text), int.Parse(tbAmountOfFloors.Text)));
            }
            else
            {
                AddHousing(new Flat(tbFullname.Text, lbTypeOfBuilding.Text, tbStreet.Text, int.Parse(tbHomeNumber.Text), int.Parse(tbFlatNumber.Text), int.Parse(tbAmountOfRooms.Text)));
            }
        }
    }
}
