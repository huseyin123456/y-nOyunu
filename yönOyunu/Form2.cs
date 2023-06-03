using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yönOyunu
{
	public partial class Form2 : Form
	{
		bool engelAlgılandı = false;// cisim engelle karşılaşması için.
		
		int puan = 0; // kaç puan topladığını öğrenmek için her cisim ile karşılaştığında +1 puan.

		

		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}


		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			pictureBox1.Top += -48;

		}

		private void pictureBox3_Click_1(object sender, EventArgs e)
		{
			pictureBox1.Top += 48;
		}

		private void pictureBox4_Click_1(object sender, EventArgs e)
		{
			pictureBox1.Left += -48;
		}

		private void pictureBox5_Click_1(object sender, EventArgs e)
		{
			pictureBox1.Left += 48;
		}

		// yukarıdaki 4 işlem cismin hareketini sağlamak ve ne kadar hareket edeceğini belirlemek.

		private void timer1_Tick(object sender, EventArgs e)
		{
			foreach (Control x in this.Controls)
			{
				if (x is PictureBox && x.Tag != null && x.Tag.ToString() == "engel")
				{
					if (pictureBox1.Bounds.IntersectsWith(x.Bounds))
					{
						if (engelAlgılandı == false)
						{
							MessageBox.Show("engele çarptı kaybettiniz.","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
							engelAlgılandı = true;

						}
						Application.Exit();
						break;

					}

				}


			}

		}

		// yukarıdaki timer cismin engel ile karşılaşması durumunda uyarı verip oyunu bitirmesi sağlanmakta
		// o kodları içeriyor forech yapısı sayesinde.
		



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

			// yukarıdaki olay  karışmasın diye başka timer ekledim bu timer da puan ve etki ettiği cismi görünütlüğünü kapatır.

		
			if(bitis.Bounds.IntersectsWith(pictureBox1.Bounds))
			{
				MessageBox.Show("Tebrikler bu seviyeyi tamamladnız toplam kazandığınız puan: " + puan.ToString()
					,"TEBRİKLER",MessageBoxButtons.OK,MessageBoxIcon.Information);
				
			}

			// bu if li yapıda cisim bitis isimli kapıya gelince seviyeyi tamamladaığını söylemek için 
			// bir messageBox gösteriyor ve toplam puanı gösteriyor.
			

		}

		private void restart_Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.ShowDialog();

			this.Close();
		}

		private void begining_Click(object sender, EventArgs e)
		{
			Form1 frm1 = new Form1();
			frm1.ShowDialog();

			this.Close();
		}

		private void next_Click(object sender, EventArgs e)
		{
			Form3 frm3 = new Form3();
			frm3.ShowDialog();

			this.Close();
		}

		// yukarıdaki butonlarda başa dönmesini sonraki seviyeye geçmesini veya kapatmasını sağlıyor.
	}
}
