
namespace Lab3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMassive = new System.Windows.Forms.Label();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelChangePlace = new System.Windows.Forms.Label();
            this.labelReverse = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Инициализация элементов массива";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.labelMassive);
            this.panel1.Controls.Add(this.btnGenerator);
            this.panel1.Controls.Add(this.textBoxSize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(27, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 183);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelMassive
            // 
            this.labelMassive.AutoSize = true;
            this.labelMassive.BackColor = System.Drawing.Color.White;
            this.labelMassive.Location = new System.Drawing.Point(216, 117);
            this.labelMassive.Name = "labelMassive";
            this.labelMassive.Padding = new System.Windows.Forms.Padding(3);
            this.labelMassive.Size = new System.Drawing.Size(187, 26);
            this.labelMassive.TabIndex = 3;
            this.labelMassive.Text = "Массив будет здесь";
            this.labelMassive.Click += new System.EventHandler(this.labelMassive_Click);
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(39, 98);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(158, 59);
            this.btnGenerator.TabIndex = 2;
            this.btnGenerator.Text = "Сгенерировать массив";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(329, 49);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(45, 27);
            this.textBoxSize.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите размерность массива n=  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Результаты";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.labelChangePlace);
            this.panel2.Controls.Add(this.labelReverse);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.labelSum);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(28, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 220);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelChangePlace
            // 
            this.labelChangePlace.AutoSize = true;
            this.labelChangePlace.BackColor = System.Drawing.Color.White;
            this.labelChangePlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelChangePlace.Location = new System.Drawing.Point(355, 167);
            this.labelChangePlace.Name = "labelChangePlace";
            this.labelChangePlace.Size = new System.Drawing.Size(97, 20);
            this.labelChangePlace.TabIndex = 8;
            this.labelChangePlace.Text = "Результат";
            // 
            // labelReverse
            // 
            this.labelReverse.AutoSize = true;
            this.labelReverse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelReverse.Location = new System.Drawing.Point(259, 105);
            this.labelReverse.Name = "labelReverse";
            this.labelReverse.Size = new System.Drawing.Size(97, 20);
            this.labelReverse.TabIndex = 7;
            this.labelReverse.Text = "Результат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Перевернутый массив:";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelSum.Location = new System.Drawing.Point(286, 51);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(97, 20);
            this.labelSum.TabIndex = 3;
            this.labelSum.Text = "Результат";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(314, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Поменять местами 2 и 3 элементы: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Сумма элементов массива: ";
            // 
            // btnRepeat
            // 
            this.btnRepeat.Location = new System.Drawing.Point(66, 530);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(158, 37);
            this.btnRepeat.TabIndex = 4;
            this.btnRepeat.Text = "Повторить";
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 584);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Label labelMassive;
        private System.Windows.Forms.Label labelChangePlace;
        private System.Windows.Forms.Label labelReverse;
        private System.Windows.Forms.Label label5;
    }
}

