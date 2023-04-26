
namespace FinalWork1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowList = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSortByFullname = new System.Windows.Forms.Button();
            this.btnDeleteLastObject = new System.Windows.Forms.Button();
            this.btnAddObject = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowList);
            this.panel1.Location = new System.Drawing.Point(25, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 90);
            this.panel1.TabIndex = 1;
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(14, 17);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(92, 55);
            this.btnShowList.TabIndex = 0;
            this.btnShowList.Text = "Показать список";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSortByFullname);
            this.panel2.Controls.Add(this.btnDeleteLastObject);
            this.panel2.Controls.Add(this.btnAddObject);
            this.panel2.Location = new System.Drawing.Point(140, 413);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 89);
            this.panel2.TabIndex = 2;
            // 
            // btnSortByFullname
            // 
            this.btnSortByFullname.Location = new System.Drawing.Point(255, 17);
            this.btnSortByFullname.Name = "btnSortByFullname";
            this.btnSortByFullname.Size = new System.Drawing.Size(138, 55);
            this.btnSortByFullname.TabIndex = 3;
            this.btnSortByFullname.Text = "Отсортировать по ФИО";
            this.btnSortByFullname.UseVisualStyleBackColor = true;
            this.btnSortByFullname.Click += new System.EventHandler(this.btnSortByFullname_Click);
            // 
            // btnDeleteLastObject
            // 
            this.btnDeleteLastObject.Location = new System.Drawing.Point(109, 17);
            this.btnDeleteLastObject.Name = "btnDeleteLastObject";
            this.btnDeleteLastObject.Size = new System.Drawing.Size(140, 55);
            this.btnDeleteLastObject.TabIndex = 2;
            this.btnDeleteLastObject.Text = "Удалить последний объект";
            this.btnDeleteLastObject.UseVisualStyleBackColor = true;
            this.btnDeleteLastObject.Click += new System.EventHandler(this.btnDeleteLastObject_Click);
            // 
            // btnAddObject
            // 
            this.btnAddObject.Location = new System.Drawing.Point(12, 17);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(91, 55);
            this.btnAddObject.TabIndex = 1;
            this.btnAddObject.Text = "Добавить объект";
            this.btnAddObject.UseVisualStyleBackColor = true;
            this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOpen);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(564, 412);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 90);
            this.panel3.TabIndex = 3;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(121, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(79, 55);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Открыть ";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 55);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 403);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список владельцев недвижимости";
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(15, 34);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(762, 355);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Недвижимость ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSortByFullname;
        private System.Windows.Forms.Button btnDeleteLastObject;
        private System.Windows.Forms.Button btnAddObject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView;
    }
}

