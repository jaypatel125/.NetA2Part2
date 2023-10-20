namespace Lab2
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
            this.components = new System.ComponentModel.Container();
            this.radioJane = new System.Windows.Forms.RadioButton();
            this.radioPat = new System.Windows.Forms.RadioButton();
            this.radioRon = new System.Windows.Forms.RadioButton();
            this.radioSue = new System.Windows.Forms.RadioButton();
            this.radioLaura = new System.Windows.Forms.RadioButton();
            this.checkCut = new System.Windows.Forms.CheckBox();
            this.checkColor = new System.Windows.Forms.CheckBox();
            this.checkExtensions = new System.Windows.Forms.CheckBox();
            this.checkHighlights = new System.Windows.Forms.CheckBox();
            this.radioSenior = new System.Windows.Forms.RadioButton();
            this.radioAdult = new System.Windows.Forms.RadioButton();
            this.radioChild = new System.Windows.Forms.RadioButton();
            this.radioStudent = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelVisits = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Hairdresser = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hairdresser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioJane
            // 
            this.radioJane.AutoSize = true;
            this.radioJane.Checked = true;
            this.radioJane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioJane.Location = new System.Drawing.Point(6, 21);
            this.radioJane.Name = "radioJane";
            this.radioJane.Size = new System.Drawing.Size(118, 20);
            this.radioJane.TabIndex = 4;
            this.radioJane.TabStop = true;
            this.radioJane.Text = "Jane Samley";
            this.radioJane.UseVisualStyleBackColor = true;
            this.radioJane.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioPat
            // 
            this.radioPat.AutoSize = true;
            this.radioPat.Location = new System.Drawing.Point(6, 47);
            this.radioPat.Name = "radioPat";
            this.radioPat.Size = new System.Drawing.Size(113, 20);
            this.radioPat.TabIndex = 5;
            this.radioPat.TabStop = true;
            this.radioPat.Text = "Pat Johnson";
            this.radioPat.UseVisualStyleBackColor = true;
            this.radioPat.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioRon
            // 
            this.radioRon.AutoSize = true;
            this.radioRon.Location = new System.Drawing.Point(6, 73);
            this.radioRon.Name = "radioRon";
            this.radioRon.Size = new System.Drawing.Size(130, 20);
            this.radioRon.TabIndex = 6;
            this.radioRon.TabStop = true;
            this.radioRon.Text = "Ron Chambers";
            this.radioRon.UseVisualStyleBackColor = true;
            // 
            // radioSue
            // 
            this.radioSue.AutoSize = true;
            this.radioSue.Location = new System.Drawing.Point(6, 99);
            this.radioSue.Name = "radioSue";
            this.radioSue.Size = new System.Drawing.Size(103, 20);
            this.radioSue.TabIndex = 7;
            this.radioSue.TabStop = true;
            this.radioSue.Text = "Sue Pallon";
            this.radioSue.UseVisualStyleBackColor = true;
            // 
            // radioLaura
            // 
            this.radioLaura.AutoSize = true;
            this.radioLaura.Location = new System.Drawing.Point(6, 125);
            this.radioLaura.Name = "radioLaura";
            this.radioLaura.Size = new System.Drawing.Size(127, 20);
            this.radioLaura.TabIndex = 8;
            this.radioLaura.TabStop = true;
            this.radioLaura.Text = "Laura Renkins";
            this.radioLaura.UseVisualStyleBackColor = true;
            this.radioLaura.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // checkCut
            // 
            this.checkCut.AutoSize = true;
            this.checkCut.Location = new System.Drawing.Point(6, 21);
            this.checkCut.Name = "checkCut";
            this.checkCut.Size = new System.Drawing.Size(51, 20);
            this.checkCut.TabIndex = 9;
            this.checkCut.Text = "Cut";
            this.checkCut.UseVisualStyleBackColor = true;
            // 
            // checkColor
            // 
            this.checkColor.AutoSize = true;
            this.checkColor.Location = new System.Drawing.Point(6, 47);
            this.checkColor.Name = "checkColor";
            this.checkColor.Size = new System.Drawing.Size(66, 20);
            this.checkColor.TabIndex = 10;
            this.checkColor.Text = "Color";
            this.checkColor.UseVisualStyleBackColor = true;
            this.checkColor.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkExtensions
            // 
            this.checkExtensions.AutoSize = true;
            this.checkExtensions.Location = new System.Drawing.Point(6, 99);
            this.checkExtensions.Name = "checkExtensions";
            this.checkExtensions.Size = new System.Drawing.Size(104, 20);
            this.checkExtensions.TabIndex = 11;
            this.checkExtensions.Text = "Extensions";
            this.checkExtensions.UseVisualStyleBackColor = true;
            // 
            // checkHighlights
            // 
            this.checkHighlights.AutoSize = true;
            this.checkHighlights.Location = new System.Drawing.Point(6, 73);
            this.checkHighlights.Name = "checkHighlights";
            this.checkHighlights.Size = new System.Drawing.Size(98, 20);
            this.checkHighlights.TabIndex = 12;
            this.checkHighlights.Text = "Highlights";
            this.checkHighlights.UseVisualStyleBackColor = true;
            this.checkHighlights.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // radioSenior
            // 
            this.radioSenior.AutoSize = true;
            this.radioSenior.Location = new System.Drawing.Point(6, 97);
            this.radioSenior.Name = "radioSenior";
            this.radioSenior.Size = new System.Drawing.Size(138, 20);
            this.radioSenior.TabIndex = 13;
            this.radioSenior.TabStop = true;
            this.radioSenior.Text = "Senior (over 65)";
            this.radioSenior.UseVisualStyleBackColor = true;
            this.radioSenior.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioAdult
            // 
            this.radioAdult.AutoSize = true;
            this.radioAdult.Checked = true;
            this.radioAdult.Location = new System.Drawing.Point(6, 21);
            this.radioAdult.Name = "radioAdult";
            this.radioAdult.Size = new System.Drawing.Size(130, 20);
            this.radioAdult.TabIndex = 14;
            this.radioAdult.TabStop = true;
            this.radioAdult.Text = "Standard Adult";
            this.radioAdult.UseVisualStyleBackColor = true;
            // 
            // radioChild
            // 
            this.radioChild.AutoSize = true;
            this.radioChild.Location = new System.Drawing.Point(6, 45);
            this.radioChild.Name = "radioChild";
            this.radioChild.Size = new System.Drawing.Size(166, 20);
            this.radioChild.TabIndex = 15;
            this.radioChild.TabStop = true;
            this.radioChild.Text = "Child (12 and under)";
            this.radioChild.UseVisualStyleBackColor = true;
            // 
            // radioStudent
            // 
            this.radioStudent.AutoSize = true;
            this.radioStudent.Location = new System.Drawing.Point(6, 71);
            this.radioStudent.Name = "radioStudent";
            this.radioStudent.Size = new System.Drawing.Size(80, 20);
            this.radioStudent.TabIndex = 16;
            this.radioStudent.TabStop = true;
            this.radioStudent.Text = "Student";
            this.radioStudent.UseVisualStyleBackColor = true;
            // 
            // labelVisits
            // 
            this.labelVisits.AutoSize = true;
            this.labelVisits.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelVisits.Location = new System.Drawing.Point(6, 23);
            this.labelVisits.Name = "labelVisits";
            this.labelVisits.Size = new System.Drawing.Size(167, 16);
            this.labelVisits.TabIndex = 17;
            this.labelVisits.Text = "Number of Client Visits:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Price:";
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate.Location = new System.Drawing.Point(70, 418);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(92, 33);
            this.calculate.TabIndex = 20;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(217, 418);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(92, 33);
            this.clear.TabIndex = 21;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(360, 418);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(92, 33);
            this.exit.TabIndex = 22;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // Hairdresser
            // 
            this.Hairdresser.Controls.Add(this.radioJane);
            this.Hairdresser.Controls.Add(this.radioPat);
            this.Hairdresser.Controls.Add(this.radioRon);
            this.Hairdresser.Controls.Add(this.radioSue);
            this.Hairdresser.Controls.Add(this.radioLaura);
            this.Hairdresser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hairdresser.Location = new System.Drawing.Point(38, 36);
            this.Hairdresser.Name = "Hairdresser";
            this.Hairdresser.Size = new System.Drawing.Size(202, 167);
            this.Hairdresser.TabIndex = 23;
            this.Hairdresser.TabStop = false;
            this.Hairdresser.Text = "Hairdresser";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkCut);
            this.groupBox1.Controls.Add(this.checkColor);
            this.groupBox1.Controls.Add(this.checkHighlights);
            this.groupBox1.Controls.Add(this.checkExtensions);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(279, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 157);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioAdult);
            this.groupBox2.Controls.Add(this.radioChild);
            this.groupBox2.Controls.Add(this.radioStudent);
            this.groupBox2.Controls.Add(this.radioSenior);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(38, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 136);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelVisits);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(279, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 100);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client Visits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 476);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Hairdresser);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Hairdresser.ResumeLayout(false);
            this.Hairdresser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioJane;
        private System.Windows.Forms.RadioButton radioPat;
        private System.Windows.Forms.RadioButton radioRon;
        private System.Windows.Forms.RadioButton radioSue;
        private System.Windows.Forms.RadioButton radioLaura;
        private System.Windows.Forms.CheckBox checkCut;
        private System.Windows.Forms.CheckBox checkColor;
        private System.Windows.Forms.CheckBox checkExtensions;
        private System.Windows.Forms.CheckBox checkHighlights;
        private System.Windows.Forms.RadioButton radioSenior;
        private System.Windows.Forms.RadioButton radioAdult;
        private System.Windows.Forms.RadioButton radioChild;
        private System.Windows.Forms.RadioButton radioStudent;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelVisits;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.GroupBox Hairdresser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}

