/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 23/07/2018
 * Time: 09:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registro_de_huespedes.Views
{
	partial class frmCheckinRegistro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.DateTimePicker dtpHoraderegistro;
		private System.Windows.Forms.TextBox txtPrecioHabitacion;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox txtCantidadadultos;
		private System.Windows.Forms.TextBox txtNumerohabitacion;
		private System.Windows.Forms.TextBox txtCantidadninios;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.DateTimePicker dtpFechaSalida;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btnAgregarnewdatos;
		
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnAgregarnewdatos = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.dtpHoraderegistro = new System.Windows.Forms.DateTimePicker();
			this.txtPrecioHabitacion = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.txtCantidadadultos = new System.Windows.Forms.TextBox();
			this.txtNumerohabitacion = new System.Windows.Forms.TextBox();
			this.txtCantidadninios = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
			this.label16 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.groupBox3.Controls.Add(this.btnAgregarnewdatos);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.txtFolio);
			this.groupBox3.Controls.Add(this.label22);
			this.groupBox3.Controls.Add(this.dtpHoraderegistro);
			this.groupBox3.Controls.Add(this.txtPrecioHabitacion);
			this.groupBox3.Controls.Add(this.label23);
			this.groupBox3.Controls.Add(this.txtCantidadadultos);
			this.groupBox3.Controls.Add(this.txtNumerohabitacion);
			this.groupBox3.Controls.Add(this.txtCantidadninios);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.dtpFechaEntrada);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.dtpFechaSalida);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(505, 341);
			this.groupBox3.TabIndex = 51;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Datos Ocupados Por EL Hotel";
			// 
			// btnAgregarnewdatos
			// 
			this.btnAgregarnewdatos.Location = new System.Drawing.Point(229, 303);
			this.btnAgregarnewdatos.Name = "btnAgregarnewdatos";
			this.btnAgregarnewdatos.Size = new System.Drawing.Size(219, 32);
			this.btnAgregarnewdatos.TabIndex = 48;
			this.btnAgregarnewdatos.Text = "Agregar Nuevo Huesped";
			this.btnAgregarnewdatos.UseVisualStyleBackColor = true;
			this.btnAgregarnewdatos.Click += new System.EventHandler(this.BtnAgregarnewdatosClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Folio";
			// 
			// txtFolio
			// 
			this.txtFolio.Location = new System.Drawing.Point(229, 25);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(233, 22);
			this.txtFolio.TabIndex = 15;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(6, 60);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(217, 23);
			this.label22.TabIndex = 37;
			this.label22.Text = "Precio De La Habitción";
			// 
			// dtpHoraderegistro
			// 
			this.dtpHoraderegistro.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpHoraderegistro.Location = new System.Drawing.Point(229, 264);
			this.dtpHoraderegistro.Name = "dtpHoraderegistro";
			this.dtpHoraderegistro.Size = new System.Drawing.Size(239, 22);
			this.dtpHoraderegistro.TabIndex = 47;
			// 
			// txtPrecioHabitacion
			// 
			this.txtPrecioHabitacion.Location = new System.Drawing.Point(229, 57);
			this.txtPrecioHabitacion.MaxLength = 10;
			this.txtPrecioHabitacion.Name = "txtPrecioHabitacion";
			this.txtPrecioHabitacion.Size = new System.Drawing.Size(233, 22);
			this.txtPrecioHabitacion.TabIndex = 38;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(6, 89);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(196, 23);
			this.label23.TabIndex = 39;
			this.label23.Text = "Número De Habitación";
			// 
			// txtCantidadadultos
			// 
			this.txtCantidadadultos.Location = new System.Drawing.Point(229, 232);
			this.txtCantidadadultos.MaxLength = 10;
			this.txtCantidadadultos.Name = "txtCantidadadultos";
			this.txtCantidadadultos.Size = new System.Drawing.Size(239, 22);
			this.txtCantidadadultos.TabIndex = 43;
			// 
			// txtNumerohabitacion
			// 
			this.txtNumerohabitacion.Location = new System.Drawing.Point(229, 89);
			this.txtNumerohabitacion.MaxLength = 15;
			this.txtNumerohabitacion.Name = "txtNumerohabitacion";
			this.txtNumerohabitacion.Size = new System.Drawing.Size(233, 22);
			this.txtNumerohabitacion.TabIndex = 40;
			// 
			// txtCantidadninios
			// 
			this.txtCantidadninios.Location = new System.Drawing.Point(229, 197);
			this.txtCantidadninios.MaxLength = 10;
			this.txtCantidadninios.Name = "txtCantidadninios";
			this.txtCantidadninios.Size = new System.Drawing.Size(233, 22);
			this.txtCantidadninios.TabIndex = 42;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 124);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(159, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Fecha De Entrada";
			// 
			// dtpFechaEntrada
			// 
			this.dtpFechaEntrada.Location = new System.Drawing.Point(229, 121);
			this.dtpFechaEntrada.Name = "dtpFechaEntrada";
			this.dtpFechaEntrada.Size = new System.Drawing.Size(233, 22);
			this.dtpFechaEntrada.TabIndex = 7;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(6, 269);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(169, 23);
			this.label16.TabIndex = 27;
			this.label16.Text = "Hora De Registro";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(6, 158);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(159, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Fecha De Salida";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(6, 235);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(181, 23);
			this.label15.TabIndex = 26;
			this.label15.Text = "Cantidad De Adultos";
			// 
			// dtpFechaSalida
			// 
			this.dtpFechaSalida.Location = new System.Drawing.Point(229, 153);
			this.dtpFechaSalida.Name = "dtpFechaSalida";
			this.dtpFechaSalida.Size = new System.Drawing.Size(233, 22);
			this.dtpFechaSalida.TabIndex = 9;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(6, 200);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(184, 23);
			this.label14.TabIndex = 25;
			this.label14.Text = "Cantidad De Niños";
			// 
			// frmCheckinRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(533, 370);
			this.Controls.Add(this.groupBox3);
			this.Name = "frmCheckinRegistro";
			this.Text = "frmCheckinRegistro";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
