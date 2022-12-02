using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3_2_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		double f(double x)
		{
			double y;

			if (x < 0) y = -4;
			else if (x >= 0 && x <= 1) y = x * x + 3 * x + 4;
			else y = 2;
			return y;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				double h = Convert.ToDouble(textBox1.Text);
				double a = Convert.ToDouble(textBox3.Text);
				double b = Convert.ToDouble(textBox4.Text);

				for (double i = a; i <= b; i += h)
				{
					textBox2.Text += String.Format("При x = {0}    Y = {1:f4}\r\n", i, f(i));
				}

			} catch
			{
				textBox2.Text = "H, A, B должны быть числом";
			}
		}
	}
}
