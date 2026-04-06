/*
 * Created by SharpDevelop.
 * User: Beto
 * Date: 4/4/2026
 * Time: 23:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Reemplazo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Guardarbd;
		private System.Windows.Forms.Button verbd;
		private System.Windows.Forms.Button botonDetectar;
		private System.Windows.Forms.Button CargarImagen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nombreBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.DataGridView tablaDatos;
		private System.Windows.Forms.TextBox altoBox;
		private System.Windows.Forms.TextBox anchoBox;
		private System.Windows.Forms.TextBox redBox;
		private System.Windows.Forms.TextBox greenBox;
		private System.Windows.Forms.TextBox blueBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox redPromBox;
		private System.Windows.Forms.TextBox greenPromBox;
		private System.Windows.Forms.TextBox bluePromBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button promedioColor;
		private System.Windows.Forms.Button escalaGrises;
		private System.Windows.Forms.Button imagenOriginal;
		private System.Windows.Forms.Button eliminarColor;
		private System.Windows.Forms.Button eliminarTono;
		private System.Windows.Forms.Button eliminarTextura;
		private System.Windows.Forms.Button pixelar;
		
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
			this.Guardarbd = new System.Windows.Forms.Button();
			this.verbd = new System.Windows.Forms.Button();
			this.botonDetectar = new System.Windows.Forms.Button();
			this.CargarImagen = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.nombreBox = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tablaDatos = new System.Windows.Forms.DataGridView();
			this.altoBox = new System.Windows.Forms.TextBox();
			this.anchoBox = new System.Windows.Forms.TextBox();
			this.redBox = new System.Windows.Forms.TextBox();
			this.greenBox = new System.Windows.Forms.TextBox();
			this.blueBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.redPromBox = new System.Windows.Forms.TextBox();
			this.greenPromBox = new System.Windows.Forms.TextBox();
			this.bluePromBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.promedioColor = new System.Windows.Forms.Button();
			this.escalaGrises = new System.Windows.Forms.Button();
			this.imagenOriginal = new System.Windows.Forms.Button();
			this.eliminarColor = new System.Windows.Forms.Button();
			this.eliminarTono = new System.Windows.Forms.Button();
			this.eliminarTextura = new System.Windows.Forms.Button();
			this.pixelar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// Guardarbd
			// 
			this.Guardarbd.Location = new System.Drawing.Point(512, 156);
			this.Guardarbd.Name = "Guardarbd";
			this.Guardarbd.Size = new System.Drawing.Size(75, 23);
			this.Guardarbd.TabIndex = 0;
			this.Guardarbd.Text = "Guardar";
			this.Guardarbd.UseVisualStyleBackColor = true;
			this.Guardarbd.Click += new System.EventHandler(this.GuardarbdClick);
			// 
			// verbd
			// 
			this.verbd.Location = new System.Drawing.Point(512, 185);
			this.verbd.Name = "verbd";
			this.verbd.Size = new System.Drawing.Size(75, 23);
			this.verbd.TabIndex = 1;
			this.verbd.Text = "Ver";
			this.verbd.UseVisualStyleBackColor = true;
			this.verbd.Click += new System.EventHandler(this.VerbdClick);
			// 
			// botonDetectar
			// 
			this.botonDetectar.Location = new System.Drawing.Point(512, 214);
			this.botonDetectar.Name = "botonDetectar";
			this.botonDetectar.Size = new System.Drawing.Size(75, 23);
			this.botonDetectar.TabIndex = 2;
			this.botonDetectar.Text = "Detectar BD";
			this.botonDetectar.UseVisualStyleBackColor = true;
			this.botonDetectar.Click += new System.EventHandler(this.BotonDetectarClick);
			// 
			// CargarImagen
			// 
			this.CargarImagen.Location = new System.Drawing.Point(188, 11);
			this.CargarImagen.Name = "CargarImagen";
			this.CargarImagen.Size = new System.Drawing.Size(75, 23);
			this.CargarImagen.TabIndex = 3;
			this.CargarImagen.Text = "Cargar";
			this.CargarImagen.UseVisualStyleBackColor = true;
			this.CargarImagen.Click += new System.EventHandler(this.CargarImagenClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(21, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nombre: ";
			// 
			// nombreBox
			// 
			this.nombreBox.Location = new System.Drawing.Point(77, 11);
			this.nombreBox.Name = "nombreBox";
			this.nombreBox.Size = new System.Drawing.Size(100, 20);
			this.nombreBox.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(593, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(288, 297);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1MouseClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tablaDatos
			// 
			this.tablaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.tablaDatos.Location = new System.Drawing.Point(21, 156);
			this.tablaDatos.Name = "tablaDatos";
			this.tablaDatos.Size = new System.Drawing.Size(485, 152);
			this.tablaDatos.TabIndex = 7;
			// 
			// altoBox
			// 
			this.altoBox.Location = new System.Drawing.Point(54, 41);
			this.altoBox.Name = "altoBox";
			this.altoBox.Size = new System.Drawing.Size(49, 20);
			this.altoBox.TabIndex = 8;
			// 
			// anchoBox
			// 
			this.anchoBox.Location = new System.Drawing.Point(155, 41);
			this.anchoBox.Name = "anchoBox";
			this.anchoBox.Size = new System.Drawing.Size(49, 20);
			this.anchoBox.TabIndex = 8;
			// 
			// redBox
			// 
			this.redBox.Location = new System.Drawing.Point(23, 87);
			this.redBox.Name = "redBox";
			this.redBox.Size = new System.Drawing.Size(49, 20);
			this.redBox.TabIndex = 8;
			// 
			// greenBox
			// 
			this.greenBox.Location = new System.Drawing.Point(78, 87);
			this.greenBox.Name = "greenBox";
			this.greenBox.Size = new System.Drawing.Size(49, 20);
			this.greenBox.TabIndex = 8;
			// 
			// blueBox
			// 
			this.blueBox.Location = new System.Drawing.Point(133, 87);
			this.blueBox.Name = "blueBox";
			this.blueBox.Size = new System.Drawing.Size(49, 20);
			this.blueBox.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(23, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 14);
			this.label2.TabIndex = 9;
			this.label2.Text = "alto";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(109, 44);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 14);
			this.label3.TabIndex = 9;
			this.label3.Text = "ancho";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(23, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 14);
			this.label4.TabIndex = 9;
			this.label4.Text = "R";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(78, 70);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 14);
			this.label5.TabIndex = 9;
			this.label5.Text = "G";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(133, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(51, 14);
			this.label6.TabIndex = 9;
			this.label6.Text = "B";
			// 
			// redPromBox
			// 
			this.redPromBox.Location = new System.Drawing.Point(23, 130);
			this.redPromBox.Name = "redPromBox";
			this.redPromBox.Size = new System.Drawing.Size(49, 20);
			this.redPromBox.TabIndex = 8;
			// 
			// greenPromBox
			// 
			this.greenPromBox.Location = new System.Drawing.Point(78, 130);
			this.greenPromBox.Name = "greenPromBox";
			this.greenPromBox.Size = new System.Drawing.Size(49, 20);
			this.greenPromBox.TabIndex = 8;
			// 
			// bluePromBox
			// 
			this.bluePromBox.Location = new System.Drawing.Point(133, 130);
			this.bluePromBox.Name = "bluePromBox";
			this.bluePromBox.Size = new System.Drawing.Size(49, 20);
			this.bluePromBox.TabIndex = 8;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(23, 113);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 14);
			this.label7.TabIndex = 9;
			this.label7.Text = "R Prom";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(78, 113);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(51, 14);
			this.label8.TabIndex = 9;
			this.label8.Text = "G Prom";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(133, 113);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 14);
			this.label9.TabIndex = 9;
			this.label9.Text = "B Prom";
			// 
			// promedioColor
			// 
			this.promedioColor.Location = new System.Drawing.Point(269, 11);
			this.promedioColor.Name = "promedioColor";
			this.promedioColor.Size = new System.Drawing.Size(124, 23);
			this.promedioColor.TabIndex = 3;
			this.promedioColor.Text = "Suavizado o Promedio";
			this.promedioColor.UseVisualStyleBackColor = true;
			this.promedioColor.Click += new System.EventHandler(this.PromedioColorClick);
			// 
			// escalaGrises
			// 
			this.escalaGrises.Location = new System.Drawing.Point(399, 12);
			this.escalaGrises.Name = "escalaGrises";
			this.escalaGrises.Size = new System.Drawing.Size(75, 23);
			this.escalaGrises.TabIndex = 3;
			this.escalaGrises.Text = "Grises";
			this.escalaGrises.UseVisualStyleBackColor = true;
			this.escalaGrises.Click += new System.EventHandler(this.EscalaGrisesClick);
			// 
			// imagenOriginal
			// 
			this.imagenOriginal.Location = new System.Drawing.Point(481, 11);
			this.imagenOriginal.Name = "imagenOriginal";
			this.imagenOriginal.Size = new System.Drawing.Size(75, 23);
			this.imagenOriginal.TabIndex = 10;
			this.imagenOriginal.Text = "Original";
			this.imagenOriginal.UseVisualStyleBackColor = true;
			this.imagenOriginal.Click += new System.EventHandler(this.ImagenOriginalClick);
			// 
			// eliminarColor
			// 
			this.eliminarColor.Location = new System.Drawing.Point(221, 37);
			this.eliminarColor.Name = "eliminarColor";
			this.eliminarColor.Size = new System.Drawing.Size(103, 23);
			this.eliminarColor.TabIndex = 11;
			this.eliminarColor.Text = "Eliminar un color";
			this.eliminarColor.UseVisualStyleBackColor = true;
			this.eliminarColor.Click += new System.EventHandler(this.EliminarColorClick);
			// 
			// eliminarTono
			// 
			this.eliminarTono.Location = new System.Drawing.Point(331, 37);
			this.eliminarTono.Name = "eliminarTono";
			this.eliminarTono.Size = new System.Drawing.Size(95, 23);
			this.eliminarTono.TabIndex = 12;
			this.eliminarTono.Text = "Eliminar Tono";
			this.eliminarTono.UseVisualStyleBackColor = true;
			this.eliminarTono.Click += new System.EventHandler(this.EliminarTonoClick);
			// 
			// eliminarTextura
			// 
			this.eliminarTextura.Location = new System.Drawing.Point(432, 37);
			this.eliminarTextura.Name = "eliminarTextura";
			this.eliminarTextura.Size = new System.Drawing.Size(98, 23);
			this.eliminarTextura.TabIndex = 13;
			this.eliminarTextura.Text = "Eliminar textura similar";
			this.eliminarTextura.UseVisualStyleBackColor = true;
			this.eliminarTextura.Click += new System.EventHandler(this.EliminarTexturaClick);
			// 
			// pixelar
			// 
			this.pixelar.Location = new System.Drawing.Point(221, 60);
			this.pixelar.Name = "pixelar";
			this.pixelar.Size = new System.Drawing.Size(103, 23);
			this.pixelar.TabIndex = 14;
			this.pixelar.Text = "Pixelar Imagen";
			this.pixelar.UseVisualStyleBackColor = true;
			this.pixelar.Click += new System.EventHandler(this.PixelarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(893, 320);
			this.Controls.Add(this.pixelar);
			this.Controls.Add(this.eliminarTextura);
			this.Controls.Add(this.eliminarTono);
			this.Controls.Add(this.eliminarColor);
			this.Controls.Add(this.imagenOriginal);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bluePromBox);
			this.Controls.Add(this.greenPromBox);
			this.Controls.Add(this.blueBox);
			this.Controls.Add(this.redPromBox);
			this.Controls.Add(this.greenBox);
			this.Controls.Add(this.redBox);
			this.Controls.Add(this.anchoBox);
			this.Controls.Add(this.altoBox);
			this.Controls.Add(this.tablaDatos);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.nombreBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.promedioColor);
			this.Controls.Add(this.escalaGrises);
			this.Controls.Add(this.CargarImagen);
			this.Controls.Add(this.botonDetectar);
			this.Controls.Add(this.verbd);
			this.Controls.Add(this.Guardarbd);
			this.Name = "MainForm";
			this.Text = "Reemplazo";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tablaDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
