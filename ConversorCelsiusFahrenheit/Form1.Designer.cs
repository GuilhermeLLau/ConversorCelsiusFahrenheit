namespace ConversorCelsiusFahrenheit
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
            this.label1 = new System.Windows.Forms.Label();
            this.InputTop = new System.Windows.Forms.TextBox();
            this.BntConvert = new System.Windows.Forms.Button();
            this.InputBottom = new System.Windows.Forms.TextBox();
            this.SelectInput = new System.Windows.Forms.ComboBox();
            this.LblTop = new System.Windows.Forms.Label();
            this.LblBottom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(182, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor Celius Fahrenheit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // InputTop
            // 
            this.InputTop.AccessibleDescription = "InputTop";
            this.InputTop.AccessibleName = "InputTop";
            this.InputTop.Location = new System.Drawing.Point(498, 135);
            this.InputTop.Name = "InputTop";
            this.InputTop.Size = new System.Drawing.Size(229, 23);
            this.InputTop.TabIndex = 1;
            this.InputTop.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BntConvert
            // 
            this.BntConvert.Location = new System.Drawing.Point(498, 325);
            this.BntConvert.Name = "BntConvert";
            this.BntConvert.Size = new System.Drawing.Size(75, 23);
            this.BntConvert.TabIndex = 2;
            this.BntConvert.Text = "Converter";
            this.BntConvert.UseVisualStyleBackColor = true;
            this.BntConvert.Click += new System.EventHandler(this.button1_Click);
            // 
            // InputBottom
            // 
            this.InputBottom.AccessibleDescription = "InputBottom";
            this.InputBottom.AccessibleName = "InputBottom";
            this.InputBottom.Location = new System.Drawing.Point(498, 249);
            this.InputBottom.Name = "InputBottom";
            this.InputBottom.Size = new System.Drawing.Size(229, 23);
            this.InputBottom.TabIndex = 4;
            // 
            // SelectInput
            // 
            this.SelectInput.AccessibleDescription = "SelectInput";
            this.SelectInput.AccessibleName = "SelectInput";
            this.SelectInput.FormattingEnabled = true;
            this.SelectInput.Items.AddRange(new object[] {
            "Celsius -> Fahrenheit",
            "Fahrenheit -> Celsius"});
            this.SelectInput.Location = new System.Drawing.Point(58, 176);
            this.SelectInput.Name = "SelectInput";
            this.SelectInput.Size = new System.Drawing.Size(196, 23);
            this.SelectInput.TabIndex = 3;
            this.SelectInput.Text = "Escolha uma conversão";
            this.SelectInput.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LblTop
            // 
            this.LblTop.AccessibleDescription = "LblTop";
            this.LblTop.AccessibleName = "LblTop";
            this.LblTop.AutoSize = true;
            this.LblTop.Location = new System.Drawing.Point(498, 101);
            this.LblTop.Name = "LblTop";
            this.LblTop.Size = new System.Drawing.Size(0, 15);
            this.LblTop.TabIndex = 5;
            // 
            // LblBottom
            // 
            this.LblBottom.AutoSize = true;
            this.LblBottom.Location = new System.Drawing.Point(498, 213);
            this.LblBottom.Name = "LblBottom";
            this.LblBottom.Size = new System.Drawing.Size(0, 15);
            this.LblBottom.TabIndex = 6;
            this.LblBottom.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblBottom);
            this.Controls.Add(this.LblTop);
            this.Controls.Add(this.InputBottom);
            this.Controls.Add(this.SelectInput);
            this.Controls.Add(this.BntConvert);
            this.Controls.Add(this.InputTop);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox InputTop;
        private Button BntConvert;
        private TextBox InputBottom;
        private ComboBox SelectInput;
        private Label LblTop;
        private Label LblBottom;
    }
}