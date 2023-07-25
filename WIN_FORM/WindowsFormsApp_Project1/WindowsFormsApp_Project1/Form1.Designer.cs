namespace WindowsFormsApp_Project1
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
            this.Invoicelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductgroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Contactlabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.NationalityTextbox = new System.Windows.Forms.Label();
            this.ProductCategorylabel = new System.Windows.Forms.Label();
            this.Categorylabel = new System.Windows.Forms.Label();
            this.Quantitylabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Cgstlabel = new System.Windows.Forms.Label();
            this.Sgstlabel = new System.Windows.Forms.Label();
            this.Igstlabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.TotalAmountlabel = new System.Windows.Forms.Label();
            this.NetAmountlabel = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.ProductgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Invoicelabel
            // 
            this.Invoicelabel.AutoSize = true;
            this.Invoicelabel.Location = new System.Drawing.Point(12, 13);
            this.Invoicelabel.Name = "Invoicelabel";
            this.Invoicelabel.Size = new System.Drawing.Size(106, 20);
            this.Invoicelabel.TabIndex = 0;
            this.Invoicelabel.Text = "Invoice Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "label1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Contactlabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NationalityTextbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer\'s Detail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "datelabel";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProductgroupBox
            // 
            this.ProductgroupBox.Controls.Add(this.comboBox2);
            this.ProductgroupBox.Controls.Add(this.comboBox1);
            this.ProductgroupBox.Controls.Add(this.Quantitylabel);
            this.ProductgroupBox.Controls.Add(this.textBox4);
            this.ProductgroupBox.Controls.Add(this.Categorylabel);
            this.ProductgroupBox.Controls.Add(this.ProductCategorylabel);
            this.ProductgroupBox.Location = new System.Drawing.Point(12, 193);
            this.ProductgroupBox.Name = "ProductgroupBox";
            this.ProductgroupBox.Size = new System.Drawing.Size(278, 138);
            this.ProductgroupBox.TabIndex = 1;
            this.ProductgroupBox.TabStop = false;
            this.ProductgroupBox.Text = "Product\'s Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full Name";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 0;
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // Contactlabel
            // 
            this.Contactlabel.AutoSize = true;
            this.Contactlabel.Location = new System.Drawing.Point(6, 99);
            this.Contactlabel.Name = "Contactlabel";
            this.Contactlabel.Size = new System.Drawing.Size(65, 20);
            this.Contactlabel.TabIndex = 0;
            this.Contactlabel.Text = "Contact";
            this.Contactlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 32);
            this.textBox1.MaxLength = 500;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 96);
            this.textBox2.MaxLength = 10;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 26);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(123, 64);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Indian";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(205, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "NRI";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // NationalityTextbox
            // 
            this.NationalityTextbox.AutoSize = true;
            this.NationalityTextbox.Location = new System.Drawing.Point(6, 64);
            this.NationalityTextbox.Name = "NationalityTextbox";
            this.NationalityTextbox.Size = new System.Drawing.Size(82, 20);
            this.NationalityTextbox.TabIndex = 0;
            this.NationalityTextbox.Text = "Nationality";
            this.NationalityTextbox.Click += new System.EventHandler(this.label2_Click);
            // 
            // ProductCategorylabel
            // 
            this.ProductCategorylabel.AutoSize = true;
            this.ProductCategorylabel.Location = new System.Drawing.Point(6, 33);
            this.ProductCategorylabel.Name = "ProductCategorylabel";
            this.ProductCategorylabel.Size = new System.Drawing.Size(132, 20);
            this.ProductCategorylabel.TabIndex = 0;
            this.ProductCategorylabel.Text = "Product Category";
            this.ProductCategorylabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Categorylabel
            // 
            this.Categorylabel.AutoSize = true;
            this.Categorylabel.Location = new System.Drawing.Point(6, 66);
            this.Categorylabel.Name = "Categorylabel";
            this.Categorylabel.Size = new System.Drawing.Size(73, 20);
            this.Categorylabel.TabIndex = 0;
            this.Categorylabel.Text = "Category";
            this.Categorylabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Quantitylabel
            // 
            this.Quantitylabel.AutoSize = true;
            this.Quantitylabel.Location = new System.Drawing.Point(6, 99);
            this.Quantitylabel.Name = "Quantitylabel";
            this.Quantitylabel.Size = new System.Drawing.Size(68, 20);
            this.Quantitylabel.TabIndex = 0;
            this.Quantitylabel.Text = "Quantity";
            this.Quantitylabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(141, 99);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(131, 26);
            this.textBox4.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(141, 66);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(131, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // Cgstlabel
            // 
            this.Cgstlabel.AutoSize = true;
            this.Cgstlabel.Location = new System.Drawing.Point(338, 82);
            this.Cgstlabel.Name = "Cgstlabel";
            this.Cgstlabel.Size = new System.Drawing.Size(71, 20);
            this.Cgstlabel.TabIndex = 0;
            this.Cgstlabel.Text = "CGST%:";
            this.Cgstlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Sgstlabel
            // 
            this.Sgstlabel.AutoSize = true;
            this.Sgstlabel.Location = new System.Drawing.Point(338, 114);
            this.Sgstlabel.Name = "Sgstlabel";
            this.Sgstlabel.Size = new System.Drawing.Size(71, 20);
            this.Sgstlabel.TabIndex = 0;
            this.Sgstlabel.Text = "SGST%:";
            this.Sgstlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // Igstlabel
            // 
            this.Igstlabel.AutoSize = true;
            this.Igstlabel.Location = new System.Drawing.Point(338, 149);
            this.Igstlabel.Name = "Igstlabel";
            this.Igstlabel.Size = new System.Drawing.Size(65, 20);
            this.Igstlabel.TabIndex = 0;
            this.Igstlabel.Text = "IGST%:";
            this.Igstlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(425, 77);
            this.textBox3.MaxLength = 500;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 26);
            this.textBox3.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(425, 108);
            this.textBox5.MaxLength = 500;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 26);
            this.textBox5.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(425, 138);
            this.textBox6.MaxLength = 500;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 26);
            this.textBox6.TabIndex = 1;
            // 
            // TotalAmountlabel
            // 
            this.TotalAmountlabel.AutoSize = true;
            this.TotalAmountlabel.Location = new System.Drawing.Point(305, 196);
            this.TotalAmountlabel.Name = "TotalAmountlabel";
            this.TotalAmountlabel.Size = new System.Drawing.Size(104, 20);
            this.TotalAmountlabel.TabIndex = 0;
            this.TotalAmountlabel.Text = "Total Amount";
            this.TotalAmountlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // NetAmountlabel
            // 
            this.NetAmountlabel.AutoSize = true;
            this.NetAmountlabel.Location = new System.Drawing.Point(315, 226);
            this.NetAmountlabel.Name = "NetAmountlabel";
            this.NetAmountlabel.Size = new System.Drawing.Size(94, 20);
            this.NetAmountlabel.TabIndex = 0;
            this.NetAmountlabel.Text = "Net Amount";
            this.NetAmountlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(423, 193);
            this.textBox7.MaxLength = 500;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(144, 26);
            this.textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(423, 225);
            this.textBox8.MaxLength = 500;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(144, 26);
            this.textBox8.TabIndex = 1;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(319, 263);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(90, 33);
            this.Savebutton.TabIndex = 2;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            // 
            // Resetbutton
            // 
            this.Resetbutton.Location = new System.Drawing.Point(425, 263);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(98, 33);
            this.Resetbutton.TabIndex = 2;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 340);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.ProductgroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Invoicelabel);
            this.Controls.Add(this.NetAmountlabel);
            this.Controls.Add(this.TotalAmountlabel);
            this.Controls.Add(this.Igstlabel);
            this.Controls.Add(this.Sgstlabel);
            this.Controls.Add(this.Cgstlabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ProductgroupBox.ResumeLayout(false);
            this.ProductgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Invoicelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ProductgroupBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Contactlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label NationalityTextbox;
        private System.Windows.Forms.Label Quantitylabel;
        private System.Windows.Forms.Label Categorylabel;
        private System.Windows.Forms.Label ProductCategorylabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Cgstlabel;
        private System.Windows.Forms.Label Sgstlabel;
        private System.Windows.Forms.Label Igstlabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label TotalAmountlabel;
        private System.Windows.Forms.Label NetAmountlabel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Resetbutton;
    }
}

