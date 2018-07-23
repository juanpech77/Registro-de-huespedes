/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 12/07/2018
 * Time: 05:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registro_de_huespedes
{
	partial class FrmInicioLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtUsuariologin;
		private System.Windows.Forms.TextBox txtContrasenialogin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnIngresarlogin;
		private System.Windows.Forms.Button btnRegistrarselogin;
		private System.Windows.Forms.Label lblHora;
		private System.Windows.Forms.Timer tmrFechahora;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnSalirdelogin;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicioLogin));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtUsuariologin = new System.Windows.Forms.TextBox();
			this.txtContrasenialogin = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnIngresarlogin = new System.Windows.Forms.Button();
			this.btnRegistrarselogin = new System.Windows.Forms.Button();
			this.lblHora = new System.Windows.Forms.Label();
			this.lblFecha = new System.Windows.Forms.Label();
			this.tmrFechahora = new System.Windows.Forms.Timer(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnSalirdelogin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(10, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(458, 249);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// txtUsuariologin
			// 
			this.txtUsuariologin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuariologin.Location = new System.Drawing.Point(194, 79);
			this.txtUsuariologin.Name = "txtUsuariologin";
			this.txtUsuariologin.Size = new System.Drawing.Size(122, 26);
			this.txtUsuariologin.TabIndex = 1;
			// 
			// txtContrasenialogin
			// 
			this.txtContrasenialogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasenialogin.Location = new System.Drawing.Point(194, 132);
			this.txtContrasenialogin.Name = "txtContrasenialogin";
			this.txtContrasenialogin.Size = new System.Drawing.Size(122, 26);
			this.txtContrasenialogin.TabIndex = 2;
			this.txtContrasenialogin.UseSystemPasswordChar = true;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Location = new System.Drawing.Point(23, 132);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 28);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Location = new System.Drawing.Point(23, 79);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(32, 34);
			this.button2.TabIndex = 5;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// btnIngresarlogin
			// 
			this.btnIngresarlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngresarlogin.Location = new System.Drawing.Point(327, 101);
			this.btnIngresarlogin.Name = "btnIngresarlogin";
			this.btnIngresarlogin.Size = new System.Drawing.Size(100, 30);
			this.btnIngresarlogin.TabIndex = 6;
			this.btnIngresarlogin.Text = "Ingresar";
			this.btnIngresarlogin.UseVisualStyleBackColor = true;
			this.btnIngresarlogin.Click += new System.EventHandler(this.BtnIngresarloginClick);
			this.btnIngresarlogin.MouseLeave += new System.EventHandler(this.BtnIngresarloginMouseLeave);
			this.btnIngresarlogin.MouseHover += new System.EventHandler(this.BtnIngresarloginMouseHover);
			// 
			// btnRegistrarselogin
			// 
			this.btnRegistrarselogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarselogin.Location = new System.Drawing.Point(327, 177);
			this.btnRegistrarselogin.Name = "btnRegistrarselogin";
			this.btnRegistrarselogin.Size = new System.Drawing.Size(100, 30);
			this.btnRegistrarselogin.TabIndex = 7;
			this.btnRegistrarselogin.Text = "Registrarse";
			this.btnRegistrarselogin.UseVisualStyleBackColor = true;
			this.btnRegistrarselogin.MouseLeave += new System.EventHandler(this.BtnRegistrarseloginMouseLeave);
			this.btnRegistrarselogin.MouseHover += new System.EventHandler(this.BtnRegistrarseloginMouseHover);
			// 
			// lblHora
			// 
			this.lblHora.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblHora.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHora.Location = new System.Drawing.Point(342, 47);
			this.lblHora.Name = "lblHora";
			this.lblHora.Size = new System.Drawing.Size(101, 23);
			this.lblHora.TabIndex = 8;
			// 
			// lblFecha
			// 
			this.lblFecha.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblFecha.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.Location = new System.Drawing.Point(19, 177);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(262, 23);
			this.lblFecha.TabIndex = 9;
			// 
			// tmrFechahora
			// 
			this.tmrFechahora.Enabled = true;
			this.tmrFechahora.Tick += new System.EventHandler(this.TmrFechahoraTick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(30, 9);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(31, 29);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// btnSalirdelogin
			// 
			this.btnSalirdelogin.BackColor = System.Drawing.Color.Gainsboro;
			this.btnSalirdelogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalirdelogin.BackgroundImage")));
			this.btnSalirdelogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalirdelogin.Location = new System.Drawing.Point(361, 12);
			this.btnSalirdelogin.Name = "btnSalirdelogin";
			this.btnSalirdelogin.Size = new System.Drawing.Size(40, 30);
			this.btnSalirdelogin.TabIndex = 14;
			this.btnSalirdelogin.UseVisualStyleBackColor = false;
			this.btnSalirdelogin.Click += new System.EventHandler(this.BtnSalirdeloginClick);
			// 
			// FrmInicioLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 249);
			this.Controls.Add(this.btnSalirdelogin);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblFecha);
			this.Controls.Add(this.lblHora);
			this.Controls.Add(this.btnRegistrarselogin);
			this.Controls.Add(this.btnIngresarlogin);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtContrasenialogin);
			this.Controls.Add(this.txtUsuariologin);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmInicioLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "INICIO";
			this.Load += new System.EventHandler(this.FrmInicioLoginLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
