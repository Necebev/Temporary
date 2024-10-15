using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vicci_system32_deletion
{
	public partial class Form1 : Form
	{
		ProgressBar progbar;
		//Button szia;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			#region
			ClientSize = new Size(720, 450);
			Location = new Point(0, 0);
			#endregion



			progbar = new ProgressBar()
			{
				Parent = this,
				Size = new Size(60, 20),
				Location = new Point(30, 10)
			};

		}
	}
}
