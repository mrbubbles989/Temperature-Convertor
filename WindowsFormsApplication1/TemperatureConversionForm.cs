using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class TemperatureConversionForm : Form
    {
        public TemperatureConversionForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double temp;
			double celsius;
			double fahrenheit;
			
            double.TryParse(txtTemperature.Text, out temp);

			if (rbtCelsius.Checked == true)
			{
				celsius = (temp * 1.8) + 32;
				lblOutput.Text = celsius.ToString();
			}
			else if (rbtFahrenheit.Checked == true)
			{
				fahrenheit = (temp - 32) / 1.8;
				lblOutput.Text = fahrenheit.ToString();
			}
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
			txtTemperature.Text = "";
			lblOutput.Text = "";
        }
    }
}
