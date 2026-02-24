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
		int cR, cG, cB;
		int cwR, cwG, cwB;
		int ventana;
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
			cR = c.R;
			cG = c.G;
			cB = c.B;
			cwR = 0;
			cwG = 0;
			cwB = 0;
			for (int i = e.X-5; i<e.X+5;i++){
				for(int j =e.Y-5;j<e.Y+5; j++){
					c = bmp.GetPixel(i,j);
					cwR = cwR + c.R;
					cwG = cwG + c.G;
					cwB = cwB + c.B;
				}
			}
			cwR = cwR /100;
			cwG = cwG /100;
			cwB = cwB /100;
			textBox1.Text = textBox1.Text + " " +cwR.ToString();
			textBox2.Text = textBox2.Text + " " +cwG.ToString();
			textBox3.Text = textBox3.Text + " " +cwB.ToString();
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
		void Button4Click(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(pictureBox1.Image);
			Color c = new Color();
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			for (int i=0; i<bmp.Width; i++){
				for(int j=0; j < bmp.Height; j++){
					c = bmp.GetPixel(i,j);
					bmp2.SetPixel(i, j, Color.FromArgb(0, c.G, 0));
				}
			}
			pictureBox1.Image = bmp2;
		}
		void Button5Click(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(pictureBox1.Image);
			Color c = new Color();
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			for (int i=0; i<bmp.Width; i++){
				for(int j=0; j < bmp.Height; j++){
					c = bmp.GetPixel(i,j);
					if((c.R == cR) && (c.G ==cG) && (c.B == cB))
						bmp2.SetPixel(i,j, Color.FromArgb(0, 0, 0));
					
					else
						bmp2.SetPixel(i,j, Color.FromArgb(c.R, c.G, c.B));
				}
			}
			pictureBox1.Image = bmp2;
		}
		void Button6Click(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(pictureBox1.Image);
			Color c = new Color();
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			for (int i=0; i<bmp.Width; i++){
				for(int j=0; j < bmp.Height; j++){
					c = bmp.GetPixel(i,j);
					if((cR-10 < c.R) && (c.R <cR +10) && (cG-10 < c.G) && (c.G <cG +10) && (cB-10 < c.B) && (c.B <cB +10))
						bmp2.SetPixel(i,j, Color.FromArgb(0, 0, 0));
					
					else
						bmp2.SetPixel(i,j, Color.FromArgb(c.R, c.G, c.B));
				}
			}
			pictureBox1.Image = bmp2;
		}
		void Button7Click(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(pictureBox1.Image);
			Color c = new Color();
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			int cRm; 
			int cGm; 
			int cBm;
			for (int i=0; i<bmp.Width -ventana; i+ventana){
				for(int j=0; j < bmp.Height -ventana; j+ventana){
					cRm = 0;
					cGm = 0;
					cBm = 0;
					for(int k=1;k<i+ventana;k++){
						for(int l=j; l<j + ventana;l++){
						}
						c = bmp.GetPixel();
					}
					c = bmp.GetPixel(i,j);
					if((cR-10 < c.R) && (c.R <cR +10) && (cG-10 < c.G) && (c.G <cG +10) && (cB-10 < c.B) && (c.B <cB +10))
						bmp2.SetPixel(i,j, Color.FromArgb(0, 0, 0));
					
					else
						bmp2.SetPixel(i,j, Color.FromArgb(c.R, c.G, c.B));
				}
			}
			pictureBox1.Image = bmp2;
		}
		
		
	}
}
