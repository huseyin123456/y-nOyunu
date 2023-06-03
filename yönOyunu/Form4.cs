using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yönOyunu
{
	public partial class Form4 : Form
	{
		bool engelAlgilandi = false;
		int puan = 0;
		public Form4()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			pictureBox1.Top += -50;
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			pictureBox1.Top += 50;

		}

		private void pictureBox5_Click(object sender, EventArgs e)
		{
			pictureBox1.Left += 58;

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			pictureBox1.Left += -58;

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			foreach (Control x in this.Controls)
			{
				if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "engel")
				{
					if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
					{
						if (engelAlgilandi == false)
						{
							MessageBox.Show("engele çarptı kaybettiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
							engelAlgilandi = true;


						}
						Application.Exit();
						break;

					}

				}
			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			foreach (Control y in this.Controls)
			{
				if (y is PictureBox && y.Tag != null && y.Tag.ToString() == "point")
				{
					if (y.Bounds.IntersectsWith(pictureBox1.Bounds))
					{
						puan++;

						label2.Text = puan.ToString();
					}
				}
				if (y is PictureBox pictureBox && pictureBox != pictureBox1 && y.Bounds.IntersectsWith(pictureBox1.Bounds))
				{
					Controls.Remove(pictureBox);
				}
			}

			if (bitis.Bounds.IntersectsWith(pictureBox1.Bounds))
			{
				MessageBox.Show("Tebrikler bu seviyeyi tamamladnız toplam kazandığınız puan: " + puan.ToString()
					, "TEBRİKLER", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
		}

		private void restart_Click(object sender, EventArgs e)
		{
			Form4 frm4 = new Form4();
			frm4.ShowDialog();

			this.Close();
		}

		private void begining_Click(object sender, EventArgs e)
		{
			Form1 frm1 = new Form1();
			frm1.ShowDialog();

			this.Close();
		}

		private void closeApp_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
