
namespace FinalWork1
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.домToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.квартираToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFlat = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbTypeOfBuilding = new System.Windows.Forms.Label();
            this.tbAmountOfRooms = new System.Windows.Forms.TextBox();
            this.lbAmountOfRooms = new System.Windows.Forms.Label();
            this.tbAmountOfFloors = new System.Windows.Forms.TextBox();
            this.lbFloors = new System.Windows.Forms.Label();
            this.tbFlatNumber = new System.Windows.Forms.TextBox();
            this.lbFlatNumber = new System.Windows.Forms.Label();
            this.tbHomeNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelFlat.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.домToolStripMenuItem,
            this.квартираToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // домToolStripMenuItem
            // 
            this.домToolStripMenuItem.Name = "домToolStripMenuItem";
            this.домToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.домToolStripMenuItem.Text = "Дом";
            this.домToolStripMenuItem.Click += new System.EventHandler(this.домToolStripMenuItem_Click);
            // 
            // квартираToolStripMenuItem
            // 
            this.квартираToolStripMenuItem.Name = "квартираToolStripMenuItem";
            this.квартираToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.квартираToolStripMenuItem.Text = "Квартира";
            this.квартираToolStripMenuItem.Click += new System.EventHandler(this.квартираToolStripMenuItem_Click);
            // 
            // panelFlat
            // 
            this.panelFlat.Controls.Add(this.btnAdd);
            this.panelFlat.Controls.Add(this.lbTypeOfBuilding);
            this.panelFlat.Controls.Add(this.tbAmountOfRooms);
            this.panelFlat.Controls.Add(this.lbAmountOfRooms);
            this.panelFlat.Controls.Add(this.tbAmountOfFloors);
            this.panelFlat.Controls.Add(this.lbFloors);
            this.panelFlat.Controls.Add(this.tbFlatNumber);
            this.panelFlat.Controls.Add(this.lbFlatNumber);
            this.panelFlat.Controls.Add(this.tbHomeNumber);
            this.panelFlat.Controls.Add(this.label7);
            this.panelFlat.Controls.Add(this.tbStreet);
            this.panelFlat.Controls.Add(this.label8);
            this.panelFlat.Controls.Add(this.label9);
            this.panelFlat.Controls.Add(this.tbFullname);
            this.panelFlat.Controls.Add(this.label10);
            this.panelFlat.Location = new System.Drawing.Point(12, 61);
            this.panelFlat.Name = "panelFlat";
            this.panelFlat.Size = new System.Drawing.Size(642, 440);
            this.panelFlat.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(252, 347);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 44);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbTypeOfBuilding
            // 
            this.lbTypeOfBuilding.AutoSize = true;
            this.lbTypeOfBuilding.Location = new System.Drawing.Point(358, 79);
            this.lbTypeOfBuilding.Name = "lbTypeOfBuilding";
            this.lbTypeOfBuilding.Size = new System.Drawing.Size(77, 17);
            this.lbTypeOfBuilding.TabIndex = 15;
            this.lbTypeOfBuilding.Text = "Тип жилья";
            // 
            // tbAmountOfRooms
            // 
            this.tbAmountOfRooms.Location = new System.Drawing.Point(361, 290);
            this.tbAmountOfRooms.Name = "tbAmountOfRooms";
            this.tbAmountOfRooms.Size = new System.Drawing.Size(149, 22);
            this.tbAmountOfRooms.TabIndex = 14;
            // 
            // lbAmountOfRooms
            // 
            this.lbAmountOfRooms.AutoSize = true;
            this.lbAmountOfRooms.Location = new System.Drawing.Point(114, 295);
            this.lbAmountOfRooms.Name = "lbAmountOfRooms";
            this.lbAmountOfRooms.Size = new System.Drawing.Size(137, 17);
            this.lbAmountOfRooms.TabIndex = 13;
            this.lbAmountOfRooms.Text = "Количество комнат";
            // 
            // tbAmountOfFloors
            // 
            this.tbAmountOfFloors.Location = new System.Drawing.Point(361, 233);
            this.tbAmountOfFloors.Name = "tbAmountOfFloors";
            this.tbAmountOfFloors.Size = new System.Drawing.Size(149, 22);
            this.tbAmountOfFloors.TabIndex = 12;
            // 
            // lbFloors
            // 
            this.lbFloors.AutoSize = true;
            this.lbFloors.Location = new System.Drawing.Point(114, 238);
            this.lbFloors.Name = "lbFloors";
            this.lbFloors.Size = new System.Drawing.Size(78, 17);
            this.lbFloors.TabIndex = 11;
            this.lbFloors.Text = "Этажность";
            // 
            // tbFlatNumber
            // 
            this.tbFlatNumber.Location = new System.Drawing.Point(361, 233);
            this.tbFlatNumber.Name = "tbFlatNumber";
            this.tbFlatNumber.Size = new System.Drawing.Size(149, 22);
            this.tbFlatNumber.TabIndex = 9;
            // 
            // lbFlatNumber
            // 
            this.lbFlatNumber.AutoSize = true;
            this.lbFlatNumber.Location = new System.Drawing.Point(114, 238);
            this.lbFlatNumber.Name = "lbFlatNumber";
            this.lbFlatNumber.Size = new System.Drawing.Size(118, 17);
            this.lbFlatNumber.TabIndex = 8;
            this.lbFlatNumber.Text = "Номер квартиры";
            // 
            // tbHomeNumber
            // 
            this.tbHomeNumber.Location = new System.Drawing.Point(361, 186);
            this.tbHomeNumber.Name = "tbHomeNumber";
            this.tbHomeNumber.Size = new System.Drawing.Size(149, 22);
            this.tbHomeNumber.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Номер дома";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(361, 132);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(149, 22);
            this.tbStreet.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Улица";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Тип жилья";
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(361, 25);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(149, 22);
            this.tbFullname.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(114, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "ФИО";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 525);
            this.Controls.Add(this.panelFlat);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddForm";
            this.Text = "Добавление объекта";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFlat.ResumeLayout(false);
            this.panelFlat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem домToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem квартираToolStripMenuItem;
        private System.Windows.Forms.Panel panelFlat;
        private System.Windows.Forms.TextBox tbAmountOfRooms;
        private System.Windows.Forms.Label lbAmountOfRooms;
        private System.Windows.Forms.TextBox tbAmountOfFloors;
        private System.Windows.Forms.Label lbFloors;
        private System.Windows.Forms.TextBox tbFlatNumber;
        private System.Windows.Forms.Label lbFlatNumber;
        private System.Windows.Forms.TextBox tbHomeNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbTypeOfBuilding;
        private System.Windows.Forms.Button btnAdd;
    }
}