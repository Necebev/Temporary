using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sziahelo
{
	public partial class Form1 : Form
	{
		Label KezdoFelirat, HolTartunk;
		NumericUpDown MaxSzam, JatekosLepese;
		Button InditoGomb, MehetGomb, ResetBtn;
		TrackBar FolyamatJelzo;
		int osszeg = 0;
		static Random R = new Random();
		bool JatekosLep = true;
		List<int> hatarok = new List<int>();


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) //az ablak betöltésekor lefutó eseménykezelő
		{
			#region Alap beállítások
			Location = new Point(130, 100); //bal felső sarok helye
			Font = new Font("Calibri", 10f); //betűtípus + méret
			ClientSize = new Size(600, 200); // ablak mérete
			Text = "Fejben 21 játék"; // ablak fejléc felirata
			BackColor = Color.FromArgb(216, 202, 184);
			#endregion
			#region 

			// példányosítom a KezdoFelirat Label változót
			KezdoFelirat = new Label(); // ezután a néven keresztül jönnek a tulajdonságok
			KezdoFelirat.Location = new Point(20, 20);
			KezdoFelirat.Text = "Állítsd be a lépésmaximumot";
			KezdoFelirat.BackColor = Color.Bisque;
			Controls.Add(KezdoFelirat); // hozzáadjuk a Form1-hez a label-t
			KezdoFelirat.Size = new Size(180, 25);
			KezdoFelirat.TextAlign = ContentAlignment.MiddleCenter;

			MaxSzam = new NumericUpDown()
			{
				Parent = this,
				Location = new Point(20, 46),
				Minimum = 2,
				Maximum = 7,
				Size = new Size(40, 25)

			};

			InditoGomb = new Button()
			{
				Parent = this,
				Location = new Point(61, 46),
				Size = new Size(100, 25),
				Text = "Indítás",
				BackColor = Color.Bisque
			};
			InditoGomb.Click += InditoGomb_Click;

			ResetBtn = new Button()
			{
				Parent = this,
				Location = new Point(161, 46),
				Size = new Size(100, 25),
				Text = "Reset"
			};
			ResetBtn.Click += ResetBtn_Click;
			#endregion 


		}

		private void ResetBtn_Click(object sender, EventArgs e)
		{
			KezdoFelirat.Visible = true;
			MaxSzam.Visible = true;
			InditoGomb.Visible = true;
		}

		private void InditoGomb_Click(object sender, EventArgs e)
		{
			KezdoFelirat.Visible = false;
			MaxSzam.Visible = false;
			InditoGomb.Visible = false;

			HolTartunk = new Label()
			{
				Parent = this,
				Location = new Point(20, 46),
				Size = new Size(100, 45),
				Text = "A játék állása: \n",
				BackColor = Color.Bisque
			};

			FolyamatJelzo = new TrackBar()
			{
				Parent = this,
				Location = new Point(20, 72),
				Size = new Size(300, 25),
				Minimum = 0,
				Maximum = 21,
				Value = 0,
				Enabled = false,
			};

			JatekosLepese = new NumericUpDown()
			{
				Parent = this,
				Location = new Point(200, 120),
				Size = new Size(50, 25),
				Minimum = 0,
				Maximum = (int)MaxSzam.Value < 2 ? 2 : (int)MaxSzam.Value > 7 ? 7 : (int)MaxSzam.Value,
			};
			MehetGomb = new Button()
			{
				Parent = this,
				Location = new Point(251, 120),
				Size = new Size(100, 25),
				Text = "Mehet!",
				BackColor = Color.Bisque,

			};
			MehetGomb.Click += MehetGomb_Click;
			int NagyLepes = (int)MaxSzam.Value > 7 ? 7 : (int)MaxSzam.Value < 2 ? 2 : (int)MaxSzam.Value;
			for (int i = 21 % (++NagyLepes); i <= 21; i += NagyLepes)
			{
				hatarok.Add(i);
			}
		}

		private void MehetGomb_Click(object sender, EventArgs e)
		{
			JatekosKovetkezik(); GepKovetkezik();
			
		}

		void JatekosKovetkezik()
		{
			if (!Kiertekeles())
			{
				int AktualisLepes = (int)JatekosLepese.Value < 1 ? 1 : (int)JatekosLepese.Value > (int)JatekosLepese.Maximum ? (int)JatekosLepese.Maximum : (int)JatekosLepese.Value;
				if (AktualisLepes + osszeg > 21)
				{
					MessageBox.Show("Besokalltál, túllépted a 21-et(" + (AktualisLepes + osszeg) + ")");
					Application.Restart();
				}
				else
				{
					osszeg += AktualisLepes;
					HolTartunk.Text += " " + osszeg;
					FolyamatJelzo.Value = osszeg;
				}
			}
			else
			{
				HolTartunk.Text += " " + osszeg;
				MessageBox.Show("Bukta");
			}
		}
		void GepKovetkezik()
		{
			if (!Kiertekeles())
			{
				int i = 0;
				for(i = 0; i < hatarok.Count; i++)
				{
					if (hatarok[i] > osszeg) break;
				}
				if (hatarok[i]-osszeg > 1 && hatarok[i]-osszeg < (int)MaxSzam.Value) osszeg = hatarok[i]; osszeg += R.Next(1, (int)MaxSzam.Value+1);
				HolTartunk.Text += " " + osszeg;
				FolyamatJelzo.Value = osszeg;
				if (osszeg == 21)
				{
					MessageBox.Show("Bukta");
					Application.Restart();
				}
			}
			else
			{
				MessageBox.Show("Pacekos");
				Application.Restart();
			}
		}
		bool Kiertekeles()
		{
			if (osszeg < 21) return false; return true;
		}

	}
}
