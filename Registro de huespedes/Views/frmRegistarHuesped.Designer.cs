/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 16/07/2018
 * Time: 07:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registro_de_huespedes.Views
{
	partial class frmRegistarHuesped
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gpbRegistrardatoshuesped;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCelular;
		private System.Windows.Forms.TextBox txtPais;
		private System.Windows.Forms.TextBox txtCodigoPostal;
		private System.Windows.Forms.ComboBox cmbEstadoCivil;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtCiudad;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.TextBox txtNacionalidad;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtApellidoP;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtProdedencia;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnRegistrarhuesped;
		private System.Windows.Forms.Button btnAgregarautomenup;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistarHuesped));
			this.gpbRegistrardatoshuesped = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtProdedencia = new System.Windows.Forms.TextBox();
			this.txtNacionalidad = new System.Windows.Forms.TextBox();
			this.txtCelular = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtPais = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtCodigoPostal = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.txtCiudad = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnRegistrarhuesped = new System.Windows.Forms.Button();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.btnAgregarautomenup = new System.Windows.Forms.Button();
			this.gpbRegistrardatoshuesped.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gpbRegistrardatoshuesped
			// 
			this.gpbRegistrardatoshuesped.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.gpbRegistrardatoshuesped.BackColor = System.Drawing.SystemColors.Window;
			this.gpbRegistrardatoshuesped.Controls.Add(this.groupBox2);
			this.gpbRegistrardatoshuesped.Controls.Add(this.groupBox1);
			this.gpbRegistrardatoshuesped.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbRegistrardatoshuesped.Location = new System.Drawing.Point(-7, -3);
			this.gpbRegistrardatoshuesped.Name = "gpbRegistrardatoshuesped";
			this.gpbRegistrardatoshuesped.Size = new System.Drawing.Size(873, 461);
			this.gpbRegistrardatoshuesped.TabIndex = 0;
			this.gpbRegistrardatoshuesped.TabStop = false;
			this.gpbRegistrardatoshuesped.Text = "Registar Nuevo Huesped";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.txtProdedencia);
			this.groupBox2.Controls.Add(this.txtNacionalidad);
			this.groupBox2.Controls.Add(this.txtCelular);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtCorreo);
			this.groupBox2.Controls.Add(this.txtTelefono);
			this.groupBox2.Controls.Add(this.txtPais);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.txtCodigoPostal);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.txtCiudad);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Location = new System.Drawing.Point(406, 41);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(443, 396);
			this.groupBox2.TabIndex = 49;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Informacion Adicional";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(15, 30);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(119, 23);
			this.label9.TabIndex = 10;
			this.label9.Text = "Procedencia";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(15, 63);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(115, 23);
			this.label10.TabIndex = 11;
			this.label10.Text = "Nacionalidad";
			// 
			// txtProdedencia
			// 
			this.txtProdedencia.Location = new System.Drawing.Point(187, 25);
			this.txtProdedencia.Name = "txtProdedencia";
			this.txtProdedencia.Size = new System.Drawing.Size(200, 26);
			this.txtProdedencia.TabIndex = 6;
			this.txtProdedencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProdedenciaKeyPress);
			// 
			// txtNacionalidad
			// 
			this.txtNacionalidad.Location = new System.Drawing.Point(187, 63);
			this.txtNacionalidad.Name = "txtNacionalidad";
			this.txtNacionalidad.Size = new System.Drawing.Size(200, 26);
			this.txtNacionalidad.TabIndex = 7;
			this.txtNacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNacionalidadKeyPress);
			// 
			// txtCelular
			// 
			this.txtCelular.Location = new System.Drawing.Point(187, 213);
			this.txtCelular.Name = "txtCelular";
			this.txtCelular.Size = new System.Drawing.Size(200, 26);
			this.txtCelular.TabIndex = 11;
			this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelularKeyPress);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(11, 134);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Telefono";
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(187, 99);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(200, 26);
			this.txtCorreo.TabIndex = 8;
			this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorreoKeyPress);
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(187, 136);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(200, 26);
			this.txtTelefono.TabIndex = 9;
			this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoKeyPress);
			// 
			// txtPais
			// 
			this.txtPais.Location = new System.Drawing.Point(187, 173);
			this.txtPais.Name = "txtPais";
			this.txtPais.Size = new System.Drawing.Size(200, 26);
			this.txtPais.TabIndex = 10;
			this.txtPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPaisKeyPress);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(11, 99);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(75, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Correo";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(15, 176);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 14;
			this.label13.Text = "Pais";
			// 
			// txtCodigoPostal
			// 
			this.txtCodigoPostal.Location = new System.Drawing.Point(187, 252);
			this.txtCodigoPostal.Name = "txtCodigoPostal";
			this.txtCodigoPostal.Size = new System.Drawing.Size(200, 26);
			this.txtCodigoPostal.TabIndex = 12;
			this.txtCodigoPostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoPostalKeyPress);
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(15, 255);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(120, 23);
			this.label19.TabIndex = 31;
			this.label19.Text = "Codigo Postal";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(15, 213);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(86, 23);
			this.label17.TabIndex = 28;
			this.label17.Text = "Celular";
			// 
			// txtCiudad
			// 
			this.txtCiudad.Location = new System.Drawing.Point(187, 288);
			this.txtCiudad.Name = "txtCiudad";
			this.txtCiudad.Size = new System.Drawing.Size(200, 26);
			this.txtCiudad.TabIndex = 13;
			this.txtCiudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCiudadKeyPress);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(15, 291);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(84, 23);
			this.label12.TabIndex = 13;
			this.label12.Text = "Ciudad";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.groupBox1.Controls.Add(this.btnRegistrarhuesped);
			this.groupBox1.Controls.Add(this.txtApellidoM);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtApellidoP);
			this.groupBox1.Controls.Add(this.txtNombre);
			this.groupBox1.Controls.Add(this.txtEdad);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.cmbSexo);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.cmbEstadoCivil);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(15, 41);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(371, 396);
			this.groupBox1.TabIndex = 48;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Generales";
			// 
			// btnRegistrarhuesped
			// 
			this.btnRegistrarhuesped.Location = new System.Drawing.Point(12, 333);
			this.btnRegistrarhuesped.Name = "btnRegistrarhuesped";
			this.btnRegistrarhuesped.Size = new System.Drawing.Size(165, 36);
			this.btnRegistrarhuesped.TabIndex = 35;
			this.btnRegistrarhuesped.Text = "Registrar Huesped";
			this.btnRegistrarhuesped.UseVisualStyleBackColor = true;
			this.btnRegistrarhuesped.Click += new System.EventHandler(this.BtnRegistrarhuespedClick);
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.Location = new System.Drawing.Point(165, 88);
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(200, 24);
			this.txtApellidoM.TabIndex = 2;
			this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoMKeyPress);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Apellido Paterno";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(11, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Apelllido Materno";
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.Location = new System.Drawing.Point(165, 56);
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(200, 24);
			this.txtApellidoP.TabIndex = 1;
			this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoPKeyPress);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(165, 23);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(200, 24);
			this.txtNombre.TabIndex = 0;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(165, 129);
			this.txtEdad.MaxLength = 2;
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(200, 24);
			this.txtEdad.TabIndex = 3;
			this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEdadKeyPress);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(11, 132);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 23);
			this.label11.TabIndex = 12;
			this.label11.Text = "Edad";
			// 
			// cmbSexo
			// 
			this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
			"Hombre",
			"Mujer"});
			this.cmbSexo.Location = new System.Drawing.Point(165, 162);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(200, 26);
			this.cmbSexo.TabIndex = 4;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(12, 169);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 23);
			this.label18.TabIndex = 29;
			this.label18.Text = "Sexo";
			// 
			// cmbEstadoCivil
			// 
			this.cmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbEstadoCivil.FormattingEnabled = true;
			this.cmbEstadoCivil.Items.AddRange(new object[] {
			"Soltero",
			"Casado",
			"Viudo"});
			this.cmbEstadoCivil.Location = new System.Drawing.Point(165, 194);
			this.cmbEstadoCivil.Name = "cmbEstadoCivil";
			this.cmbEstadoCivil.Size = new System.Drawing.Size(200, 26);
			this.cmbEstadoCivil.TabIndex = 5;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(12, 197);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(100, 23);
			this.label20.TabIndex = 32;
			this.label20.Text = "Estado Civil";
			// 
			// btnAgregarautomenup
			// 
			this.btnAgregarautomenup.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregarautomenup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarautomenup.Location = new System.Drawing.Point(586, 464);
			this.btnAgregarautomenup.Name = "btnAgregarautomenup";
			this.btnAgregarautomenup.Size = new System.Drawing.Size(165, 36);
			this.btnAgregarautomenup.TabIndex = 36;
			this.btnAgregarautomenup.Text = "Agregar Auto";
			this.btnAgregarautomenup.UseVisualStyleBackColor = false;
			this.btnAgregarautomenup.Click += new System.EventHandler(this.BtnAgregarautomenupClick);
			// 
			// frmRegistarHuesped
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(848, 503);
			this.Controls.Add(this.btnAgregarautomenup);
			this.Controls.Add(this.gpbRegistrardatoshuesped);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRegistarHuesped";
			this.Text = "frmRegistarHuesped";
			this.gpbRegistrardatoshuesped.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
