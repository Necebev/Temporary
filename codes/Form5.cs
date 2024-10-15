using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vicci_cursor
{
	public partial class Form1 : Form
	{
		Button gomb;
		Random r = new Random();
		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			FormBorderStyle = FormBorderStyle.None;
			ClientSize = new Size(1440, 900);
			Location = new Point(0, 0);
			TopMost = true;

			gomb = new Button()
			{
				Parent = this,
				Location = new Point(0, 0),
				Size = new Size(200, 40),
				Text = "Cigi"
			};
			gomb.MouseEnter += Gomb_MouseEnter;
			gomb.Click += Gomb_Click;
		}

		private void Gomb_MouseEnter(object sender, EventArgs e)
		{
			gomb.Size = new Size(r.Next(100, 400), r.Next(20, 80));
			gomb.Location = new Point(r.Next(1440 / 5, 1440 * 4 / 5), r.Next(900 / 5, 900 * 4 / 5));
		}

		private void Gomb_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


	}
}
