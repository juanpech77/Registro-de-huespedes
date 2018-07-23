/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 17/07/2018
 * Time: 11:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registro_de_huespedes.Views
{
	partial class frmRegistrarAuto
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtFoliodelhuesped;
		private System.Windows.Forms.TextBox txtDescripcionauto;
		private System.Windows.Forms.TextBox txtModeloauto;
		private System.Windows.Forms.TextBox txtMatriculaauto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAgregarAuto;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarAuto));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnAgregarAuto = new System.Windows.Forms.Button();
			this.txtFoliodelhuesped = new System.Windows.Forms.TextBox();
			this.txtDescripcionauto = new System.Windows.Forms.TextBox();
			this.txtModeloauto = new System.Windows.Forms.TextBox();
			this.txtMatriculaauto = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.groupBox1.Controls.Add(this.btnAgregarAuto);
			this.groupBox1.Controls.Add(this.txtFoliodelhuesped);
			this.groupBox1.Controls.Add(this.txtDescripcionauto);
			this.groupBox1.Controls.Add(this.txtModeloauto);
			this.groupBox1.Controls.Add(this.txtMatriculaauto);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(373, 293);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Registre los Datos Necesarios";
			// 
			// btnAgregarAuto
			// 
			this.btnAgregarAuto.Location = new System.Drawing.Point(122, 250);
			this.btnAgregarAuto.Name = "btnAgregarAuto";
			this.btnAgregarAuto.Size = new System.Drawing.Size(100, 37);
			this.btnAgregarAuto.TabIndex = 8;
			this.btnAgregarAuto.Text = "Agregar";
			this.btnAgregarAuto.UseVisualStyleBackColor = true;
			this.btnAgregarAuto.Click += new System.EventHandler(this.BtnAgregarAutoClick);
			// 
			// txtFoliodelhuesped
			// 
			this.txtFoliodelhuesped.Location = new System.Drawing.Point(159, 107);
			this.txtFoliodelhuesped.Name = "txtFoliodelhuesped";
			this.txtFoliodelhuesped.Size = new System.Drawing.Size(181, 24);
			this.txtFoliodelhuesped.TabIndex = 7;
			this.txtFoliodelhuesped.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFoliodelhuespedKeyPress);
			// 
			// txtDescripcionauto
			// 
			this.txtDescripcionauto.Location = new System.Drawing.Point(6, 168);
			this.txtDescripcionauto.Multiline = true;
			this.txtDescripcionauto.Name = "txtDescripcionauto";
			this.txtDescripcionauto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescripcionauto.Size = new System.Drawing.Size(334, 76);
			this.txtDescripcionauto.TabIndex = 6;
			this.txtDescripcionauto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDescripcionautoKeyPress);
			// 
			// txtModeloauto
			// 
			this.txtModeloauto.Location = new System.Drawing.Point(159, 74);
			this.txtModeloauto.Name = "txtModeloauto";
			this.txtModeloauto.Size = new System.Drawing.Size(181, 24);
			this.txtModeloauto.TabIndex = 5;
			this.txtModeloauto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtModeloautoKeyPress);
			// 
			// txtMatriculaauto
			// 
			this.txtMatriculaauto.Location = new System.Drawing.Point(159, 33);
			this.txtMatriculaauto.Name = "txtMatriculaauto";
			this.txtMatriculaauto.Size = new System.Drawing.Size(181, 24);
			this.txtMatriculaauto.TabIndex = 4;
			this.txtMatriculaauto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMatriculaautoKeyPress);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(122, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(113, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Descripción";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(23, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Folio";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(23, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Modelo";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(23, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Placa";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// frmRegistrarAuto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 321);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmRegistrarAuto";
			this.Text = "frmRegistrarAuto";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
