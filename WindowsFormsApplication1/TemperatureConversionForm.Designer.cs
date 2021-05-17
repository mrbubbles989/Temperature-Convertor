namespace WindowsFormsApplication1
{
    partial class TemperatureConversionForm
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
			this.lblTemperature = new System.Windows.Forms.Label();
			this.lblDegress = new System.Windows.Forms.Label();
			this.rbtCelsius = new System.Windows.Forms.RadioButton();
			this.rbtFahrenheit = new System.Windows.Forms.RadioButton();
			this.lblOutput = new System.Windows.Forms.Label();
			this.txtTemperature = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTemperature
			// 
			this.lblTemperature.AutoSize = true;
			this.lblTemperature.Location = new System.Drawing.Point(28, 26);
			this.lblTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblTemperature.Name = "lblTemperature";
			this.lblTemperature.Size = new System.Drawing.Size(67, 13);
			this.lblTemperature.TabIndex = 0;
			this.lblTemperature.Text = "&Temperature";
			this.lblTemperature.Click += new System.EventHandler(this.label1_Click);
			// 
			// lblDegress
			// 
			this.lblDegress.AutoSize = true;
			this.lblDegress.Location = new System.Drawing.Point(38, 110);
			this.lblDegress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblDegress.Name = "lblDegress";
			this.lblDegress.Size = new System.Drawing.Size(47, 13);
			this.lblDegress.TabIndex = 1;
			this.lblDegress.Text = "Degrees";
			// 
			// rbtCelsius
			// 
			this.rbtCelsius.AutoSize = true;
			this.rbtCelsius.Checked = true;
			this.rbtCelsius.Location = new System.Drawing.Point(48, 66);
			this.rbtCelsius.Margin = new System.Windows.Forms.Padding(2);
			this.rbtCelsius.Name = "rbtCelsius";
			this.rbtCelsius.Size = new System.Drawing.Size(58, 17);
			this.rbtCelsius.TabIndex = 2;
			this.rbtCelsius.TabStop = true;
			this.rbtCelsius.Text = "Celsius";
			this.rbtCelsius.UseVisualStyleBackColor = true;
			// 
			// rbtFahrenheit
			// 
			this.rbtFahrenheit.AutoSize = true;
			this.rbtFahrenheit.Location = new System.Drawing.Point(164, 66);
			this.rbtFahrenheit.Margin = new System.Windows.Forms.Padding(2);
			this.rbtFahrenheit.Name = "rbtFahrenheit";
			this.rbtFahrenheit.Size = new System.Drawing.Size(75, 17);
			this.rbtFahrenheit.TabIndex = 3;
			this.rbtFahrenheit.TabStop = true;
			this.rbtFahrenheit.Text = "Fahrenheit";
			this.rbtFahrenheit.UseVisualStyleBackColor = true;
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.Location = new System.Drawing.Point(168, 110);
			this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(0, 13);
			this.lblOutput.TabIndex = 4;
			// 
			// txtTemperature
			// 
			this.txtTemperature.Location = new System.Drawing.Point(164, 26);
			this.txtTemperature.Margin = new System.Windows.Forms.Padding(2);
			this.txtTemperature.Name = "txtTemperature";
			this.txtTemperature.Size = new System.Drawing.Size(76, 20);
			this.txtTemperature.TabIndex = 5;
			this.txtTemperature.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(31, 154);
			this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(64, 19);
			this.btnCalculate.TabIndex = 6;
			this.btnCalculate.Text = "&Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(120, 154);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 19);
			this.button2.TabIndex = 7;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(208, 154);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(56, 19);
			this.button3.TabIndex = 8;
			this.button3.Text = "Close";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// TemperatureConversionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 256);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.txtTemperature);
			this.Controls.Add(this.lblOutput);
			this.Controls.Add(this.rbtFahrenheit);
			this.Controls.Add(this.rbtCelsius);
			this.Controls.Add(this.lblDegress);
			this.Controls.Add(this.lblTemperature);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "TemperatureConversionForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblDegress;
        private System.Windows.Forms.RadioButton rbtCelsius;
        private System.Windows.Forms.RadioButton rbtFahrenheit;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

