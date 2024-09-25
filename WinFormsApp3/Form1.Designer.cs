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
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // USD
            // 
            USD.AutoSize = true;
            USD.Location = new Point(326, 129);
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
            EUR.Location = new Point(326, 154);
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
            RUB.Location = new Point(326, 179);
            RUB.Name = "RUB";
            RUB.Size = new Size(47, 19);
            RUB.TabIndex = 2;
            RUB.TabStop = true;
            RUB.Text = "RUB";
            RUB.UseVisualStyleBackColor = true;
            // 
            // TRY
            // 
            TRY.AutoSize = true;
            TRY.Location = new Point(326, 204);
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
            button1.Location = new Point(326, 229);
            button1.Name = "button1";
            button1.Size = new Size(94, 50);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 99);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 8;
            label3.Text = "Konwertuj na: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 129);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 9;
            label4.Text = "Kwota PLN:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(TRY);
            Controls.Add(RUB);
            Controls.Add(EUR);
            Controls.Add(USD);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private Label label3;
        private Label label4;
    }
}
