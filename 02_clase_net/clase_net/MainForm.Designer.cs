/*
 * Created by SharpDevelop.
 * User: Beto
 * Date: 20/2/2026
 * Time: 16:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace clase_net
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(18, 18);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(602, 446);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseClick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(630, 20);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(180, 35);
			this.button1.TabIndex = 1;
			this.button1.Text = "Abrir";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(630, 66);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(180, 35);
			this.button2.TabIndex = 2;
			this.button2.Text = "Escala Gris";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(630, 112);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(178, 26);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(630, 154);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(178, 26);
			this.textBox2.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(630, 195);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(178, 26);
			this.textBox3.TabIndex = 5;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(630, 237);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(180, 35);
			this.button3.TabIndex = 6;
			this.button3.Text = "canal R";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(630, 281);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(178, 33);
			this.button4.TabIndex = 7;
			this.button4.Text = "canal G";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(630, 321);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(178, 32);
			this.button5.TabIndex = 8;
			this.button5.Text = "puntos";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(630, 360);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(178, 31);
			this.button6.TabIndex = 9;
			this.button6.Text = "puntos";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(630, 398);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(178, 36);
			this.button7.TabIndex = 10;
			this.button7.Text = "Textura";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 483);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "clase_net";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
