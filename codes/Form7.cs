using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orai1
{
	public partial class Form1 : Form
	{
		ListBox alap, oszthatok;
		TextBox alsohatar, felsohatar, darab, oszto;
		Button kilep;
		static Random r = new Random();
		ToolTip tt = new ToolTip();

		public Form1()
		{
			InitializeComponent();
			Load += Form1_Load;
			tt.AutoPopDelay = 5000;
			tt.ReshowDelay = 500;
			tt.InitialDelay = 500;
			tt.SetToolTip(this, "Himnusz");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			#region Settings
			Font = new Font("Times", 14f);
			Location = new Point(100, 100);
			ClientSize = new Size(300, 500);
			FormBorderStyle = FormBorderStyle.None;
			BackColor = Color.FromArgb(128,128, 128);
			#endregion

			alsohatar = new TextBox()
			{
				Parent = this,
				Location = new Point(20, 20),
				Size = new Size(260, 30)
			};
			tt.SetToolTip(alsohatar, "Isten áldd meg a magyart");

			felsohatar = new TextBox()
			{
				Parent = this,
				Location = new Point(20, 70),
				Size = new Size(260, 30)
			};
			tt.SetToolTip(felsohatar, "Jókedvvel bőséggel");

			darab = new TextBox()
			{
				Parent = this,
				Location = new Point(20, 120),
				Size = new Size(260, 30)
			};
			tt.SetToolTip(darab, "Nyújts feléje védőkart");

			kilep = new Button()
			{
				Parent = this,
				Location = new Point(281, 3),
				Size = new Size(17, 17),
				Text = "X",
				Font = new Font("arial", 5f),
				BackColor = Color.Red,
				ForeColor = Color.White
			};
			tt.SetToolTip(kilep, "Ha küzd ellenséggel");

			alsohatar.KeyDown += TextBox_KeyDown;
			felsohatar.KeyDown += TextBox_KeyDown;
			darab.KeyDown += TextBox_KeyDown;
			kilep.Click += Kilep_Click;
		}

		private void Kilep_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void TextBox_KeyDown(object sender, KeyEventArgs e)
		{
			// var aktualis = sender as TextBox;
			if (e.KeyCode == Keys.Enter)
			{
				int ah=0, fh=0, db = 0; 
				if (int.TryParse(alsohatar.Text, out ah) && int.TryParse(felsohatar.Text, out fh) && int.TryParse(darab.Text, out db) && db > 0)
				{
					alsohatar.Visible = false; felsohatar.Visible = false; darab.Visible = false;
					alap = new ListBox()
					{
						Parent = this,
						Location = new Point(20, 30),
						Size = new Size(120,410)
					};
					tt.SetToolTip(alap, "Bal sors akit régen tép");

					oszthatok = new ListBox()
					{
						Parent = this,
						Location = new Point(160, 30),
						Size = new Size(120, 410)
					};
					tt.SetToolTip(oszthatok, "Hozz rá víg esztendőt");

					oszto = new TextBox()
					{
						Parent = this,
						Location = new Point(100, 440),
						Size = new Size(100, 30)
					};
					tt.SetToolTip(oszto, "Megbűnhődte már e nép a múltat s jövendőt");

					// Ah shit here we go again.
					oszto.KeyPress += Oszto_KeyPress;
					oszto.KeyDown += Oszto_KeyDown;
					int csere = ah;
					ah = ah < fh ? ah : fh;
					fh = fh == ah ? csere : fh;
					List<int> list = new List<int>();
					for (int i = 0; i < db; i++) list.Add(r.Next(ah, fh + 1));
					list.Sort();
					alap.DataSource = list;
				}
			}
		}

		private void Oszto_KeyDown(object sender, KeyEventArgs e)
		{
			int Oszto = 0;
			if (e.KeyCode == Keys.Enter && int.TryParse(oszto.Text, out Oszto) && Oszto > 0) {
				oszthatok.Items.Clear();
				foreach (int szam in alap.Items)
				{
					if (szam % Oszto == 0) oszthatok.Items.Add(szam); 
				}
			}
		}

		private void Oszto_KeyPress(object sender, KeyPressEventArgs e)
		{
			// ha nem szám vagy backspace vagy enter a leütött bilentyű, akkor ne is engedje, hogy beírjuk a textbox-ba
			if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Enter)
			{
				e.Handled = true;
			}
		}
	}
}
