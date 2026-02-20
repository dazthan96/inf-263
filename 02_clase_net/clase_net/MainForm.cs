/*
 * Created by SharpDevelop.
 * User: Beto
 * Date: 20/2/2026
 * Time: 16:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace clase_net
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			Bitmap bmp = new Bitmap(openFileDialog1.FileName);
			pictureBox1.Image = bmp;
			
		}
		void PictureBox1MouseClick(object sender, MouseEventArgs e)
		{
			Bitmap bmp = new Bitmap(pictureBox1.Image);
			Color c = new Color();
			c = bmp.GetPixel(e.X, e.Y);
			textBox1.Text = c.R.ToString();
			textBox2.Text = c.G.ToString();
			textBox3.Text = c.B.ToString();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(pictureBox1.Image);
			Color c = new Color();
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			for (int i=0; i<bmp.Width; i++){
				for(int j=0; j < bmp.Height; j++){
					c = bmp.GetPixel(i,j);
					bmp2.SetPixel(i, j, Color.FromArgb(c.R, 0, 0));
				}
			}
			pictureBox1.Image = bmp2;
		}
		void Button2Click(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(pictureBox1.Image);
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			Color c = new Color();
			for (int i=0; i<bmp.Width; i++){
				for(int j=0; j < bmp.Height; j++){
					c = bmp.GetPixel(i,j);
					int valor_intento = (c.R + c.B + c.G)/3;
					bmp2.SetPixel(i, j, Color.FromArgb(valor_intento, valor_intento, valor_intento));
				}
			}
			pictureBox1.Image = bmp2;
			
		}
		
		
	}
}
