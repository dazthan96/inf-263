/*
 * Created by SharpDevelop.
 * User: Beto
 * Date: 4/4/2026
 * Time: 23:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Reemplazo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Bitmap bmp;
		int ventana = 10;
		int alto, ancho, posX, posY;
		int  red, green, blue, redProm, greenProm, blueProm;
		
		Color pixelColor;
		// conexion y configuracion de SQL Server
		string cadenaConexion = "server=(local);user=inf263;pwd=123456;database=texturas";

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
		void CargarImagenClick(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			bmp =new Bitmap(openFileDialog1.FileName);
			pictureBox1.Image = bmp;
			alto = bmp.Height;
			ancho = bmp.Width;
			altoBox.Text = alto.ToString();
			anchoBox.Text = ancho.ToString();
		}
		void PictureBox1MouseClick(object sender, MouseEventArgs e)
		{
			pixelColor = bmp.GetPixel(e.X,e.Y);
			posX = e.X;
			posY = e.Y;
			red = pixelColor.R;
			green = pixelColor.G;
			blue = pixelColor.B;
			redBox.Text = pixelColor.R.ToString();
			greenBox.Text = pixelColor.G.ToString();
			blueBox.Text = pixelColor.B.ToString();
			
		}
		void PromedioColorClick(object sender, EventArgs e)
		{
			
			for (int i = posX - (ventana/2); i < posX + (ventana/2); i++) {
				for (int j = posY - (ventana/2); j < posY+(ventana/2); j++) {
					Color c = bmp.GetPixel(i,j);
					redProm = redProm + c.R;
					greenProm = greenProm + c.G;
					blueProm = blueProm + c.B;
				}
			}
			redProm = redProm / (ventana*ventana);
			greenProm = greenProm / (ventana*ventana);
			blueProm = blueProm / (ventana*ventana);
			redPromBox.Text = redProm.ToString();
			greenPromBox.Text = greenProm.ToString();
			bluePromBox.Text = blueProm.ToString();
	
		}
		void EscalaGrisesClick(object sender, EventArgs e)
		{
			int sumGris=0;
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			Color c = new Color();
			for (int i = 0; i < ancho; i++) {
				for (int j = 0; j < alto; j++) {
					c = bmp.GetPixel(i,j);
					sumGris = (c.R + c.G + c.B)/3;
					bmp2.SetPixel(i,j,Color.FromArgb(sumGris,sumGris,sumGris));
				}
			}
			pictureBox1.Image = bmp2;
		}
		void ImagenOriginalClick(object sender, EventArgs e)
		{
			pictureBox1.Image = bmp;
		}
		void EliminarColorClick(object sender, EventArgs e)
		{
			Color c = new Color();
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			for (int i = 0; i < ancho; i++) {
				for (int j = 0; j < alto; j++) {
					c = bmp.GetPixel(i,j);
					if ((c.R == red) && (c.G == green) && (c.B == blue)) {
						bmp2.SetPixel(i,j,Color.FromArgb(0,0,0));
					} else {
						bmp2.SetPixel(i,j, Color.FromArgb(c.R, c.G, c.B));
					}
				}
			}
			pictureBox1.Image=bmp2;
		}
		void EliminarTonoClick(object sender, EventArgs e)
		{
			Color c = new Color();
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			for (int i = 0; i < ancho; i++) {
				for (int j = 0; j < alto; j++) {
					c = bmp.GetPixel(i,j);
					if ((Math.Abs(c.R - red)<10)&&(Math.Abs(c.G - green)<10)&&(Math.Abs(c.B - blue)<10)) {
						bmp2.SetPixel(i,j,Color.FromArgb(0,0,0));
					} else {
						bmp2.SetPixel(i,j,Color.FromArgb(c.R, c.G, c.B));
					}
				}
			}
			pictureBox1.Image = bmp2;
		}
		void EliminarTexturaClick(object sender, EventArgs e)
		{
			Color c = new Color();
			Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height);
			for (int i = 0; i < ancho - ventana; i+=ventana) {
				for (int j = 0; j < alto - ventana; j+=ventana) {
					int sumaR=0, sumaG=0, sumaB=0;
					for (int k = i; k < i +ventana; k++) {
						for (int l = j; l < j+ventana; l++) {
							c = bmp.GetPixel(k,l);
							sumaR +=c.R;
							sumaG +=c.G;
							sumaB += c.B;
						}
					}
					int promR = sumaR /(ventana*ventana);
					int promG = sumaG /(ventana*ventana);
					int promB = sumaB /(ventana*ventana);
					bool esParecido = Math.Abs(promR - redProm)<10 && Math.Abs(promG - greenProm) <10 && Math.Abs(promB - blueProm)<10;
					for (int k = i; k < i+ventana; k++) {
						for (int l = j; l < j+ventana; l++) {
							if (esParecido) {
								bmp2.SetPixel(k,l,Color.FromArgb(0,0,0));
							} else {
								Color colorOriginal = bmp.GetPixel(k,l);
								bmp2.SetPixel(k,l, Color.FromArgb(colorOriginal.R, colorOriginal.G, colorOriginal.B));
							}
						}
					}
				}
			}
			pictureBox1.Image = bmp2;
		}
		void PixelarClick(object sender, EventArgs e)
		{
			Color c = new Color();
			Bitmap bmp2 = new Bitmap(bmp.Width,bmp.Height);
			int nuevo_mosaico = 3;
			for (int i = 0; i < ancho - nuevo_mosaico; i+=nuevo_mosaico) {
				for (int j = 0; j < alto - nuevo_mosaico; j+=nuevo_mosaico) {
					int sumaR=0, sumaG=0, sumaB=0;
					for (int k = i; k < i+nuevo_mosaico; k++) {
						for (int l = j; l < j+nuevo_mosaico; l++) {
							c = bmp.GetPixel(k,l);
							sumaR+=c.R;
							sumaG+=c.G;
							sumaB+=c.B;
						}
					}
					int promR = sumaR / (nuevo_mosaico*nuevo_mosaico);
					int promG = sumaG / (nuevo_mosaico*nuevo_mosaico);
					int promB = sumaB / (nuevo_mosaico*nuevo_mosaico);
					for (int k = i; k < i + nuevo_mosaico; k++) {
						for (int l = j; l < j + nuevo_mosaico; l++) {
							bmp2.SetPixel(k,l, Color.FromArgb(promR,promG, promB));
						}
					}
				}
			}
			pictureBox1.Image = bmp2;
		}
		void BotonDetectarClick(object sender, EventArgs e)
		{
			using (SqlConnection con = new SqlConnection(cadenaConexion)){
				try {
					con.Open();
					MessageBox.Show("Conexion existosa");
				}catch (Exception ex){
					MessageBox.Show("Error de conexion: "+ex.Message);
				}
			}
		}
		void GuardarbdClick(object sender, EventArgs e)
		{
			using (SqlConnection con = new SqlConnection(cadenaConexion)){
		        string sql = "INSERT INTO textura(r, g, b, descripcion) VALUES (@r, @g, @b, @desc)";
		        SqlCommand cmd = new SqlCommand(sql, con);
		        
		        // Pasamos los valores de los TextBox a la consulta
		        cmd.Parameters.AddWithValue("@r", int.Parse(redBox.Text));
		        cmd.Parameters.AddWithValue("@g", int.Parse(greenBox.Text));
		        cmd.Parameters.AddWithValue("@b", int.Parse(blueBox.Text));
		        cmd.Parameters.AddWithValue("@desc", nombreBox.Text);
		
		        try {
		            con.Open();
		            cmd.ExecuteNonQuery();
		            MessageBox.Show("Textura guardada correctamente.");
		        } catch (Exception ex) {
		            MessageBox.Show("Error al guardar: " + ex.Message);
		        }
		    }
		}
		void VerbdClick(object sender, EventArgs e)
		{
			using (SqlConnection con = new SqlConnection(cadenaConexion)){
		        string sql = "SELECT * FROM textura"; // Trae todos los registros
		        SqlDataAdapter da = new SqlDataAdapter(sql, con);
		        DataTable dt = new DataTable();
		
		        try {
		            da.Fill(dt); // Llena la tabla virtual con los datos de SQL
		            tablaDatos.DataSource = dt; // Muestra los datos en el grid del diseño
		        } catch (Exception ex) {
		            MessageBox.Show("Error al listar: " + ex.Message);
		        }
		    }
		}
		
		
	}
}
