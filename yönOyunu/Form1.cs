namespace yönOyunu
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 frm2 = new Form2();
			frm2.ShowDialog();

			this.Close();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form3 frm3 = new Form3();
			frm3.ShowDialog();
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 frm4 = new Form4();
			frm4.ShowDialog();
			this.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Engelere çarpmadan olabildiğince puan toplayıp kapıya varılması gerek", "BİLGİLENDİRME"
				, MessageBoxButtons.OK, MessageBoxIcon.Information);



		}
	}
}