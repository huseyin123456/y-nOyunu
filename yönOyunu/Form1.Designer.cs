﻿namespace yönOyunu
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label1.Location = new Point(132, 53);
			label1.Name = "label1";
			label1.Size = new Size(220, 31);
			label1.TabIndex = 0;
			label1.Text = "Lutfen seviye seçin";
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			button1.Location = new Point(168, 117);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 1;
			button1.Text = "kolay";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			button2.Location = new Point(172, 182);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 2;
			button2.Text = "orta";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			button3.Location = new Point(172, 242);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 3;
			button3.Text = "zor";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			button4.Location = new Point(25, 117);
			button4.Name = "button4";
			button4.Size = new Size(108, 154);
			button4.TabIndex = 4;
			button4.Text = "NASIL OYNANIR?";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightSalmon;
			ClientSize = new Size(430, 377);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label1);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
	}
}