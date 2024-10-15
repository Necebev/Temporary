using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hazi1
{
	public partial class Form1 : Form
	{
		Label cimke;
		public Form1()
		{
			InitializeComponent();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			FormWindowState.Maximized;
			cimke = new Label()
			{
				Parent = this,
				Text = "IIIIIIIIIIIIIIIIIIIII",
				Font = new Font("arial", 80),
				Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
			};
		}
	}
}
