using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Load += Form1_Betoltes;
		}

		private void Form1_Betoltes(object sender, EventArgs e)
		{
			Location = new Point(100, 100);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			BackColor = Color.FromArgb(192, 192, 192);
			button2.Text = "hali";
			button1.Enabled = true;
			button1.Text = "Aktív";
			button1.Click += button1_Click;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			button1.Text = "Működik";
			button1.Font = new Font("Calibri", 14f);
		}

		private void label1_Click(object sender, EventArgs e)
		{
			 
		}
	}
}
