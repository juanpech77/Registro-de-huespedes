/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 28/07/2018
 * Time: 10:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registro_de_huespedes.Views
{
	partial class frmVerUsuarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gpbUsuarios;
		private System.Windows.Forms.TextBox txtNombreusuario;
		private System.Windows.Forms.TextBox txtTratamientousu;
		private System.Windows.Forms.TextBox txtRolusuario;
		private System.Windows.Forms.TextBox txtContraseñalogin;
		private System.Windows.Forms.TextBox txtUsudelogin;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBuscarusu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvDatosusuarios;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminarusu;
		private System.Windows.Forms.Button btnGuardarcambios;
		private System.Windows.Forms.Button txtModicarusu;
		
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
			this.gpbUsuarios = new System.Windows.Forms.GroupBox();
			this.btnGuardarcambios = new System.Windows.Forms.Button();
			this.txtModicarusu = new System.Windows.Forms.Button();
			this.btnEliminarusu = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtNombreusuario = new System.Windows.Forms.TextBox();
			this.txtTratamientousu = new System.Windows.Forms.TextBox();
			this.txtRolusuario = new System.Windows.Forms.TextBox();
			this.txtContraseñalogin = new System.Windows.Forms.TextBox();
			this.txtUsudelogin = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBuscarusu = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvDatosusuarios = new System.Windows.Forms.DataGridView();
			this.gpbUsuarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatosusuarios)).BeginInit();
			this.SuspendLayout();
			// 
			// gpbUsuarios
			// 
			this.gpbUsuarios.Controls.Add(this.btnGuardarcambios);
			this.gpbUsuarios.Controls.Add(this.txtModicarusu);
			this.gpbUsuarios.Controls.Add(this.btnEliminarusu);
			this.gpbUsuarios.Controls.Add(this.btnAgregar);
			this.gpbUsuarios.Controls.Add(this.txtNombreusuario);
			this.gpbUsuarios.Controls.Add(this.txtTratamientousu);
			this.gpbUsuarios.Controls.Add(this.txtRolusuario);
			this.gpbUsuarios.Controls.Add(this.txtContraseñalogin);
			this.gpbUsuarios.Controls.Add(this.txtUsudelogin);
			this.gpbUsuarios.Controls.Add(this.label6);
			this.gpbUsuarios.Controls.Add(this.label5);
			this.gpbUsuarios.Controls.Add(this.label4);
			this.gpbUsuarios.Controls.Add(this.label3);
			this.gpbUsuarios.Controls.Add(this.label2);
			this.gpbUsuarios.Controls.Add(this.txtBuscarusu);
			this.gpbUsuarios.Controls.Add(this.label1);
			this.gpbUsuarios.Controls.Add(this.dgvDatosusuarios);
			this.gpbUsuarios.Location = new System.Drawing.Point(12, 2);
			this.gpbUsuarios.Name = "gpbUsuarios";
			this.gpbUsuarios.Size = new System.Drawing.Size(1014, 279);
			this.gpbUsuarios.TabIndex = 0;
			this.gpbUsuarios.TabStop = false;
			// 
			// btnGuardarcambios
			// 
			this.btnGuardarcambios.Location = new System.Drawing.Point(425, 232);
			this.btnGuardarcambios.Name = "btnGuardarcambios";
			this.btnGuardarcambios.Size = new System.Drawing.Size(131, 32);
			this.btnGuardarcambios.TabIndex = 10;
			this.btnGuardarcambios.Text = "Guardar Usuario";
			this.btnGuardarcambios.UseVisualStyleBackColor = true;
			this.btnGuardarcambios.Click += new System.EventHandler(this.BtnGuardarcambiosClick);
			// 
			// txtModicarusu
			// 
			this.txtModicarusu.Location = new System.Drawing.Point(277, 232);
			this.txtModicarusu.Name = "txtModicarusu";
			this.txtModicarusu.Size = new System.Drawing.Size(142, 32);
			this.txtModicarusu.TabIndex = 9;
			this.txtModicarusu.Text = "Modificar Usuario";
			this.txtModicarusu.UseVisualStyleBackColor = true;
			this.txtModicarusu.Click += new System.EventHandler(this.TxtModicarusuClick);
			// 
			// btnEliminarusu
			// 
			this.btnEliminarusu.Location = new System.Drawing.Point(147, 232);
			this.btnEliminarusu.Name = "btnEliminarusu";
			this.btnEliminarusu.Size = new System.Drawing.Size(124, 32);
			this.btnEliminarusu.TabIndex = 8;
			this.btnEliminarusu.Text = "Eliminar Usuario";
			this.btnEliminarusu.UseVisualStyleBackColor = true;
			this.btnEliminarusu.Click += new System.EventHandler(this.BtnEliminarusuClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(9, 232);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(132, 32);
			this.btnAgregar.TabIndex = 7;
			this.btnAgregar.Text = "Guardar Usuario";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// txtNombreusuario
			// 
			this.txtNombreusuario.Location = new System.Drawing.Point(122, 206);
			this.txtNombreusuario.Name = "txtNombreusuario";
			this.txtNombreusuario.Size = new System.Drawing.Size(190, 20);
			this.txtNombreusuario.TabIndex = 5;
			// 
			// txtTratamientousu
			// 
			this.txtTratamientousu.Location = new System.Drawing.Point(122, 167);
			this.txtTratamientousu.Name = "txtTratamientousu";
			this.txtTratamientousu.Size = new System.Drawing.Size(190, 20);
			this.txtTratamientousu.TabIndex = 4;
			// 
			// txtRolusuario
			// 
			this.txtRolusuario.Location = new System.Drawing.Point(122, 134);
			this.txtRolusuario.Name = "txtRolusuario";
			this.txtRolusuario.Size = new System.Drawing.Size(190, 20);
			this.txtRolusuario.TabIndex = 3;
			// 
			// txtContraseñalogin
			// 
			this.txtContraseñalogin.Location = new System.Drawing.Point(122, 91);
			this.txtContraseñalogin.Name = "txtContraseñalogin";
			this.txtContraseñalogin.Size = new System.Drawing.Size(190, 20);
			this.txtContraseñalogin.TabIndex = 2;
			// 
			// txtUsudelogin
			// 
			this.txtUsudelogin.Location = new System.Drawing.Point(122, 53);
			this.txtUsudelogin.Name = "txtUsudelogin";
			this.txtUsudelogin.Size = new System.Drawing.Size(190, 20);
			this.txtUsudelogin.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 206);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(125, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Nombre Del Usuario";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Tratamiento";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 134);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(115, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Rol De Usuario";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Contraseña De Login";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Usuario De Login";
			// 
			// txtBuscarusu
			// 
			this.txtBuscarusu.Location = new System.Drawing.Point(162, 19);
			this.txtBuscarusu.Name = "txtBuscarusu";
			this.txtBuscarusu.Size = new System.Drawing.Size(285, 20);
			this.txtBuscarusu.TabIndex = 0;
			this.txtBuscarusu.TextChanged += new System.EventHandler(this.TxtBuscarusuTextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Buscar Usuario Por Nombre";
			// 
			// dgvDatosusuarios
			// 
			this.dgvDatosusuarios.AllowUserToAddRows = false;
			this.dgvDatosusuarios.AllowUserToDeleteRows = false;
			this.dgvDatosusuarios.BackgroundColor = System.Drawing.Color.Black;
			this.dgvDatosusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatosusuarios.GridColor = System.Drawing.SystemColors.AppWorkspace;
			this.dgvDatosusuarios.Location = new System.Drawing.Point(330, 53);
			this.dgvDatosusuarios.Name = "dgvDatosusuarios";
			this.dgvDatosusuarios.ReadOnly = true;
			this.dgvDatosusuarios.Size = new System.Drawing.Size(677, 150);
			this.dgvDatosusuarios.TabIndex = 0;
			// 
			// frmVerUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1033, 286);
			this.Controls.Add(this.gpbUsuarios);
			this.Name = "frmVerUsuarios";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmVerUsuarios";
			this.Load += new System.EventHandler(this.FrmVerUsuariosLoad);
			this.gpbUsuarios.ResumeLayout(false);
			this.gpbUsuarios.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatosusuarios)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
