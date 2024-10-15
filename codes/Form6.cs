using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sziasz
{
	public partial class Form1 : Form
	{
		ProgressBar progbar;
		Button yes, no;
		Label text;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			#region
			ClientSize = new Size(203, 123);
			Location = new Point(0, 0);
			BackColor = Color.White;
			Text = "Error";
			#endregion

			progbar = new ProgressBar()
			{
				Visible = false,
				Parent = this,
				Value = 0,
				Size = new Size(163, 123),
				Location = new Point(30, 10)
			};

			text = new Label()
			{
				Parent = this,
				Text = "Biztos benne, hogy végleg törli a gecibe az egészet?",
				Size = new Size(163, 20),
				Location = new Point(30, 10)
			};
		}
	}
}
