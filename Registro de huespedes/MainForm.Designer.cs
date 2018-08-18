/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 11/07/2018
 * Time: 11:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registro_de_huespedes
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblRol;
		private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
		private System.Windows.Forms.Panel PanMenuVertical;
		private System.Windows.Forms.Button btnRegistrarHuesped;
		private System.Windows.Forms.Button btnAutomovil;
		private System.Windows.Forms.Button btncheckOut;
		private System.Windows.Forms.Button bntHabitaciones;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem recargosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuRegistrosGu;
		private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuAgregarUsuario;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.PanMenuVertical = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnRegistrarHuesped = new System.Windows.Forms.Button();
			this.btnAutomovil = new System.Windows.Forms.Button();
			this.btncheckOut = new System.Windows.Forms.Button();
			this.bntHabitaciones = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRegistrosGu = new System.Windows.Forms.ToolStripMenuItem();
			this.recargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAgregarUsuario = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.PanMenuVertical.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lblRol,
			this.lblUsuario});
			this.statusStrip1.Location = new System.Drawing.Point(0, 566);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(779, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblRol
			// 
			this.lblRol.Name = "lblRol";
			this.lblRol.Size = new System.Drawing.Size(0, 17);
			// 
			// lblUsuario
			// 
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(0, 17);
			// 
			// PanMenuVertical
			// 
			this.PanMenuVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
			this.PanMenuVertical.AutoSize = true;
			this.PanMenuVertical.BackColor = System.Drawing.Color.MidnightBlue;
			this.PanMenuVertical.Controls.Add(this.pictureBox1);
			this.PanMenuVertical.Controls.Add(this.btnRegistrarHuesped);
			this.PanMenuVertical.Controls.Add(this.btnAutomovil);
			this.PanMenuVertical.Controls.Add(this.btncheckOut);
			this.PanMenuVertical.Controls.Add(this.bntHabitaciones);
			this.PanMenuVertical.Location = new System.Drawing.Point(0, 24);
			this.PanMenuVertical.Name = "PanMenuVertical";
			this.PanMenuVertical.Size = new System.Drawing.Size(156, 539);
			this.PanMenuVertical.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(147, 83);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// btnRegistrarHuesped
			// 
			this.btnRegistrarHuesped.FlatAppearance.BorderSize = 0;
			this.btnRegistrarHuesped.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnRegistrarHuesped.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRegistrarHuesped.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarHuesped.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnRegistrarHuesped.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarHuesped.Image")));
			this.btnRegistrarHuesped.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnRegistrarHuesped.Location = new System.Drawing.Point(28, 126);
			this.btnRegistrarHuesped.Name = "btnRegistrarHuesped";
			this.btnRegistrarHuesped.Size = new System.Drawing.Size(112, 93);
			this.btnRegistrarHuesped.TabIndex = 0;
			this.btnRegistrarHuesped.Text = "\r\n\r\nRegistrar \r\ncliente";
			this.btnRegistrarHuesped.UseVisualStyleBackColor = true;
			this.btnRegistrarHuesped.Click += new System.EventHandler(this.BtnRegistrarHuespedClick);
			// 
			// btnAutomovil
			// 
			this.btnAutomovil.FlatAppearance.BorderSize = 0;
			this.btnAutomovil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btnAutomovil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAutomovil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAutomovil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAutomovil.Image = ((System.Drawing.Image)(resources.GetObject("btnAutomovil.Image")));
			this.btnAutomovil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAutomovil.Location = new System.Drawing.Point(6, 438);
			this.btnAutomovil.Name = "btnAutomovil";
			this.btnAutomovil.Size = new System.Drawing.Size(144, 88);
			this.btnAutomovil.TabIndex = 2;
			this.btnAutomovil.Text = "  \r\n\r\nHuesped con\r\n   automovil";
			this.btnAutomovil.UseVisualStyleBackColor = true;
			this.btnAutomovil.Click += new System.EventHandler(this.BtnAutomovilClick);
			// 
			// btncheckOut
			// 
			this.btncheckOut.FlatAppearance.BorderSize = 0;
			this.btncheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.btncheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btncheckOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btncheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btncheckOut.Image = ((System.Drawing.Image)(resources.GetObject("btncheckOut.Image")));
			this.btncheckOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btncheckOut.Location = new System.Drawing.Point(15, 235);
			this.btncheckOut.Name = "btncheckOut";
			this.btncheckOut.Size = new System.Drawing.Size(135, 73);
			this.btncheckOut.TabIndex = 1;
			this.btncheckOut.Text = "\r\n\r\nCheckout";
			this.btncheckOut.UseVisualStyleBackColor = true;
			// 
			// bntHabitaciones
			// 
			this.bntHabitaciones.FlatAppearance.BorderSize = 0;
			this.bntHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
			this.bntHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntHabitaciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bntHabitaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.bntHabitaciones.Image = ((System.Drawing.Image)(resources.GetObject("bntHabitaciones.Image")));
			this.bntHabitaciones.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.bntHabitaciones.Location = new System.Drawing.Point(6, 337);
			this.bntHabitaciones.Name = "bntHabitaciones";
			this.bntHabitaciones.Size = new System.Drawing.Size(144, 65);
			this.bntHabitaciones.TabIndex = 1;
			this.bntHabitaciones.Text = "    \r\n\r\nHabitaciones";
			this.bntHabitaciones.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.operacionesToolStripMenuItem,
			this.recargosToolStripMenuItem,
			this.ingresosToolStripMenuItem,
			this.administracionToolStripMenuItem,
			this.ayudaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(779, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// operacionesToolStripMenuItem
			// 
			this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuRegistrosGu});
			this.operacionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("operacionesToolStripMenuItem.Image")));
			this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
			this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.operacionesToolStripMenuItem.Text = "Registry";
			// 
			// mnuRegistrosGu
			// 
			this.mnuRegistrosGu.Image = ((System.Drawing.Image)(resources.GetObject("mnuRegistrosGu.Image")));
			this.mnuRegistrosGu.Name = "mnuRegistrosGu";
			this.mnuRegistrosGu.Size = new System.Drawing.Size(182, 22);
			this.mnuRegistrosGu.Text = "Registros Guardados";
			this.mnuRegistrosGu.Click += new System.EventHandler(this.MnuRegistrosGuClick);
			// 
			// recargosToolStripMenuItem
			// 
			this.recargosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recargosToolStripMenuItem.Image")));
			this.recargosToolStripMenuItem.Name = "recargosToolStripMenuItem";
			this.recargosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
			this.recargosToolStripMenuItem.Text = "Surcharges";
			// 
			// ingresosToolStripMenuItem
			// 
			this.ingresosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresosToolStripMenuItem.Image")));
			this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
			this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.ingresosToolStripMenuItem.Text = "Income";
			// 
			// administracionToolStripMenuItem
			// 
			this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuAgregarUsuario});
			this.administracionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administracionToolStripMenuItem.Image")));
			this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
			this.administracionToolStripMenuItem.Size = new System.Drawing.Size(181, 20);
			this.administracionToolStripMenuItem.Text = "Administracion De Usuarios";
			// 
			// mnuAgregarUsuario
			// 
			this.mnuAgregarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("mnuAgregarUsuario.Image")));
			this.mnuAgregarUsuario.Name = "mnuAgregarUsuario";
			this.mnuAgregarUsuario.Size = new System.Drawing.Size(165, 22);
			this.mnuAgregarUsuario.Text = "Agreagar Usuario";
			this.mnuAgregarUsuario.Click += new System.EventHandler(this.MnuAgregarUsuarioClick);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.ayudaToolStripMenuItem.Text = "help";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(779, 588);
			this.Controls.Add(this.PanMenuVertical);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "Registro de huespedes";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.PanMenuVertical.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
