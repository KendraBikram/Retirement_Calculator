namespace retirementcal
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.currentage = new System.Windows.Forms.TextBox();
            this.retirementage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.incometoretire = new System.Windows.Forms.TextBox();
            this.incomeincre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.currentsalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.duringreturnrate = new System.Windows.Forms.TextBox();
            this.retirenestegg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.activereturnrate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.withdrawal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.scenariobox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(383, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 50);
            this.button1.TabIndex = 11;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentage
            // 
            this.currentage.Location = new System.Drawing.Point(188, 247);
            this.currentage.Name = "currentage";
            this.currentage.Size = new System.Drawing.Size(191, 34);
            this.currentage.TabIndex = 2;
            this.currentage.Text = "45";
            this.currentage.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // retirementage
            // 
            this.retirementage.Location = new System.Drawing.Point(188, 296);
            this.retirementage.Name = "retirementage";
            this.retirementage.Size = new System.Drawing.Size(191, 34);
            this.retirementage.TabIndex = 3;
            this.retirementage.Text = "67";
            this.retirementage.TextChanged += new System.EventHandler(this.retirementage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(296, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 45);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 45);
            this.label2.TabIndex = 12;
            this.label2.Text = "Current Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(65, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "Current Salary:";
            // 
            // incometoretire
            // 
            this.incometoretire.Location = new System.Drawing.Point(708, 247);
            this.incometoretire.Name = "incometoretire";
            this.incometoretire.Size = new System.Drawing.Size(191, 34);
            this.incometoretire.TabIndex = 5;
            this.incometoretire.Text = "3000";
            this.incometoretire.TextChanged += new System.EventHandler(this.annsave_TextChanged);
            // 
            // incomeincre
            // 
            this.incomeincre.Location = new System.Drawing.Point(708, 296);
            this.incomeincre.Name = "incomeincre";
            this.incomeincre.Size = new System.Drawing.Size(191, 34);
            this.incomeincre.TabIndex = 6;
            this.incomeincre.Text = "2";
            this.incomeincre.TextChanged += new System.EventHandler(this.incomeincre_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 45);
            this.label4.TabIndex = 13;
            this.label4.Text = "Retirement Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(493, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 45);
            this.label5.TabIndex = 16;
            this.label5.Text = "Yearly income to retirement:";
            // 
            // currentsalary
            // 
            this.currentsalary.Location = new System.Drawing.Point(188, 352);
            this.currentsalary.Name = "currentsalary";
            this.currentsalary.Size = new System.Drawing.Size(191, 34);
            this.currentsalary.TabIndex = 4;
            this.currentsalary.Text = "50000";
            this.currentsalary.TextChanged += new System.EventHandler(this.annincome_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(539, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 45);
            this.label7.TabIndex = 18;
            this.label7.Text = "Income increase (%):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Javanese Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(293, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(476, 98);
            this.label10.TabIndex = 20;
            this.label10.Text = "Maturation Calculator";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(359, 121);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(315, 34);
            this.namebox.TabIndex = 1;
            this.namebox.Text = "Kendra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(151, 469);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(443, 45);
            this.label12.TabIndex = 23;
            this.label12.Text = "Annual return rate during retirement years (%):";
            // 
            // duringreturnrate
            // 
            this.duringreturnrate.Location = new System.Drawing.Point(511, 472);
            this.duringreturnrate.Name = "duringreturnrate";
            this.duringreturnrate.Size = new System.Drawing.Size(191, 34);
            this.duringreturnrate.TabIndex = 9;
            this.duringreturnrate.Text = "5";
            this.duringreturnrate.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // retirenestegg
            // 
            this.retirenestegg.Location = new System.Drawing.Point(709, 352);
            this.retirenestegg.Name = "retirenestegg";
            this.retirenestegg.Size = new System.Drawing.Size(191, 34);
            this.retirenestegg.TabIndex = 7;
            this.retirenestegg.Text = "100000";
            this.retirenestegg.TextChanged += new System.EventHandler(this.retincome_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(569, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 45);
            this.label9.TabIndex = 15;
            this.label9.Text = "Current nest egg:";
            // 
            // activereturnrate
            // 
            this.activereturnrate.Location = new System.Drawing.Point(511, 413);
            this.activereturnrate.Name = "activereturnrate";
            this.activereturnrate.Size = new System.Drawing.Size(191, 34);
            this.activereturnrate.TabIndex = 8;
            this.activereturnrate.Text = "4";
            this.activereturnrate.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(320, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 45);
            this.label6.TabIndex = 27;
            this.label6.Text = "Annual return rate (%):";
            // 
            // withdrawal
            // 
            this.withdrawal.Location = new System.Drawing.Point(511, 534);
            this.withdrawal.Name = "withdrawal";
            this.withdrawal.Size = new System.Drawing.Size(191, 34);
            this.withdrawal.TabIndex = 10;
            this.withdrawal.Text = "30313";
            this.withdrawal.TextChanged += new System.EventHandler(this.withdrawal_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(268, 531);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(298, 45);
            this.label11.TabIndex = 28;
            this.label11.Text = "Withdrawals during retirement:";
            // 
            // scenariobox
            // 
            this.scenariobox.Location = new System.Drawing.Point(359, 182);
            this.scenariobox.Name = "scenariobox";
            this.scenariobox.Size = new System.Drawing.Size(315, 34);
            this.scenariobox.TabIndex = 29;
            this.scenariobox.Text = "Retire at 67";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(276, 179);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 45);
            this.label8.TabIndex = 30;
            this.label8.Text = "Scenario:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(976, 698);
            this.Controls.Add(this.scenariobox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.incomeincre);
            this.Controls.Add(this.incometoretire);
            this.Controls.Add(this.retirementage);
            this.Controls.Add(this.currentage);
            this.Controls.Add(this.withdrawal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.activereturnrate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.duringreturnrate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.retirenestegg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.currentsalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox currentage;
        public System.Windows.Forms.TextBox retirementage;
        public System.Windows.Forms.TextBox incometoretire;
        public System.Windows.Forms.TextBox incomeincre;
        public System.Windows.Forms.TextBox currentsalary;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox duringreturnrate;
        public System.Windows.Forms.TextBox retirenestegg;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox activereturnrate;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox withdrawal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox scenariobox;
        private System.Windows.Forms.Label label8;
    }
}

