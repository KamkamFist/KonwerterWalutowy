namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            USD = new RadioButton();
            EUR = new RadioButton();
            RUB = new RadioButton();
            TRY = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            TRY1 = new RadioButton();
            RUB1 = new RadioButton();
            EUR1 = new RadioButton();
            USD1 = new RadioButton();
            groupBox1 = new GroupBox();
            PLN1 = new RadioButton();
            groupBox2 = new GroupBox();
            PLN = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // USD
            // 
            USD.AutoSize = true;
            USD.Location = new Point(17, 58);
            USD.Name = "USD";
            USD.Size = new Size(47, 19);
            USD.TabIndex = 0;
            USD.TabStop = true;
            USD.Text = "USD";
            USD.UseVisualStyleBackColor = true;
            USD.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // EUR
            // 
            EUR.AutoSize = true;
            EUR.Location = new Point(17, 83);
            EUR.Name = "EUR";
            EUR.Size = new Size(46, 19);
            EUR.TabIndex = 1;
            EUR.TabStop = true;
            EUR.Text = "EUR";
            EUR.UseVisualStyleBackColor = true;
            // 
            // RUB
            // 
            RUB.AutoSize = true;
            RUB.Location = new Point(17, 108);
            RUB.Name = "RUB";
            RUB.Size = new Size(43, 19);
            RUB.TabIndex = 2;
            RUB.TabStop = true;
            RUB.Text = "JPY";
            RUB.UseVisualStyleBackColor = true;
            // 
            // TRY
            // 
            TRY.AutoSize = true;
            TRY.Location = new Point(17, 133);
            TRY.Name = "TRY";
            TRY.Size = new Size(45, 19);
            TRY.TabIndex = 3;
            TRY.TabStop = true;
            TRY.Text = "TRY";
            TRY.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(580, 167);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 4;
            label1.Text = " ";
            // 
            // button1
            // 
            button1.Location = new Point(291, 266);
            button1.Name = "button1";
            button1.Size = new Size(263, 50);
            button1.TabIndex = 5;
            button1.Text = "Przemień";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(580, 131);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 7;
            label2.Text = "Otrzymana Wartosc: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 129);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "Kwota: ";
            // 
            // TRY1
            // 
            TRY1.AutoSize = true;
            TRY1.Location = new Point(9, 138);
            TRY1.Name = "TRY1";
            TRY1.Size = new Size(45, 19);
            TRY1.TabIndex = 13;
            TRY1.TabStop = true;
            TRY1.Text = "TRY";
            TRY1.UseVisualStyleBackColor = true;
            // 
            // RUB1
            // 
            RUB1.AutoSize = true;
            RUB1.Location = new Point(9, 113);
            RUB1.Name = "RUB1";
            RUB1.Size = new Size(43, 19);
            RUB1.TabIndex = 12;
            RUB1.TabStop = true;
            RUB1.Text = "JPY";
            RUB1.UseVisualStyleBackColor = true;
            // 
            // EUR1
            // 
            EUR1.AutoSize = true;
            EUR1.Location = new Point(9, 88);
            EUR1.Name = "EUR1";
            EUR1.Size = new Size(46, 19);
            EUR1.TabIndex = 11;
            EUR1.TabStop = true;
            EUR1.Text = "EUR";
            EUR1.UseVisualStyleBackColor = true;
            // 
            // USD1
            // 
            USD1.AutoSize = true;
            USD1.Location = new Point(9, 63);
            USD1.Name = "USD1";
            USD1.Size = new Size(47, 19);
            USD1.TabIndex = 10;
            USD1.TabStop = true;
            USD1.Text = "USD";
            USD1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PLN1);
            groupBox1.Controls.Add(USD1);
            groupBox1.Controls.Add(EUR1);
            groupBox1.Controls.Add(TRY1);
            groupBox1.Controls.Add(RUB1);
            groupBox1.Location = new Point(291, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(126, 161);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Konwertuj z: ";
            // 
            // PLN1
            // 
            PLN1.AutoSize = true;
            PLN1.Location = new Point(9, 38);
            PLN1.Name = "PLN1";
            PLN1.Size = new Size(47, 19);
            PLN1.TabIndex = 14;
            PLN1.TabStop = true;
            PLN1.Text = "PLN";
            PLN1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PLN);
            groupBox2.Controls.Add(USD);
            groupBox2.Controls.Add(EUR);
            groupBox2.Controls.Add(RUB);
            groupBox2.Controls.Add(TRY);
            groupBox2.Location = new Point(427, 99);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(127, 161);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Konwertuj na: ";
            // 
            // PLN
            // 
            PLN.AutoSize = true;
            PLN.Location = new Point(17, 33);
            PLN.Name = "PLN";
            PLN.Size = new Size(47, 19);
            PLN.TabIndex = 4;
            PLN.TabStop = true;
            PLN.Text = "PLN";
            PLN.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton USD;
        private RadioButton EUR;
        private RadioButton RUB;
        private RadioButton TRY;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private RadioButton TRY1;
        private RadioButton RUB1;
        private RadioButton EUR1;
        private RadioButton USD1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton PLN1;
        private RadioButton PLN;
    }
}
