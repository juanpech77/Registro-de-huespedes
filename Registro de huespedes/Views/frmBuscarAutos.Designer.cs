/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 19/07/2018
 * Time: 07:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Registro_de_huespedes.Views
{
	partial class frmBuscarAutos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox gpbBuscarautos;
		private System.Windows.Forms.DataGridView dgvDatoscar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtDescripcioncar;
		private System.Windows.Forms.TextBox txtModelocar;
		private System.Windows.Forms.TextBox txtMatriculacar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBuscarautos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnEliminacar;
		private System.Windows.Forms.Button btnEditarcar;
		private System.Windows.Forms.Button btnGuardarcarU;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtFoliocar;
		private System.Windows.Forms.DataGridView dataGridView1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarAutos));
			this.gpbBuscarautos = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.txtFoliocar = new System.Windows.Forms.TextBox();
			this.btnGuardarcarU = new System.Windows.Forms.Button();
			this.btnEditarcar = new System.Windows.Forms.Button();
			this.btnEliminacar = new System.Windows.Forms.Button();
			this.dgvDatoscar = new System.Windows.Forms.DataGridView();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtDescripcioncar = new System.Windows.Forms.TextBox();
			this.txtModelocar = new System.Windows.Forms.TextBox();
			this.txtMatriculacar = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBuscarautos = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gpbBuscarautos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatoscar)).BeginInit();
			this.SuspendLayout();
			// 
			// gpbBuscarautos
			// 
			this.gpbBuscarautos.Controls.Add(this.dataGridView1);
			this.gpbBuscarautos.Controls.Add(this.label5);
			this.gpbBuscarautos.Controls.Add(this.txtFoliocar);
			this.gpbBuscarautos.Controls.Add(this.btnGuardarcarU);
			this.gpbBuscarautos.Controls.Add(this.btnEditarcar);
			this.gpbBuscarautos.Controls.Add(this.btnEliminacar);
			this.gpbBuscarautos.Controls.Add(this.dgvDatoscar);
			this.gpbBuscarautos.Controls.Add(this.btnGuardar);
			this.gpbBuscarautos.Controls.Add(this.txtDescripcioncar);
			this.gpbBuscarautos.Controls.Add(this.txtModelocar);
			this.gpbBuscarautos.Controls.Add(this.txtMatriculacar);
			this.gpbBuscarautos.Controls.Add(this.label4);
			this.gpbBuscarautos.Controls.Add(this.label3);
			this.gpbBuscarautos.Controls.Add(this.label2);
			this.gpbBuscarautos.Controls.Add(this.txtBuscarautos);
			this.gpbBuscarautos.Controls.Add(this.label1);
			this.gpbBuscarautos.Location = new System.Drawing.Point(1, 2);
			this.gpbBuscarautos.Name = "gpbBuscarautos";
			this.gpbBuscarautos.Size = new System.Drawing.Size(808, 498);
			this.gpbBuscarautos.TabIndex = 0;
			this.gpbBuscarautos.TabStop = false;
			this.gpbBuscarautos.Text = "groupBox1";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(425, 316);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(240, 150);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.Visible = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(17, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(70, 23);
			this.label5.TabIndex = 14;
			this.label5.Text = "Folio";
			// 
			// txtFoliocar
			// 
			this.txtFoliocar.Location = new System.Drawing.Point(100, 144);
			this.txtFoliocar.Name = "txtFoliocar";
			this.txtFoliocar.Size = new System.Drawing.Size(147, 22);
			this.txtFoliocar.TabIndex = 3;
			// 
			// btnGuardarcarU
			// 
			this.btnGuardarcarU.Location = new System.Drawing.Point(17, 336);
			this.btnGuardarcarU.Name = "btnGuardarcarU";
			this.btnGuardarcarU.Size = new System.Drawing.Size(75, 23);
			this.btnGuardarcarU.TabIndex = 12;
			this.btnGuardarcarU.Text = "Guardar";
			this.btnGuardarcarU.UseVisualStyleBackColor = true;
			this.btnGuardarcarU.Click += new System.EventHandler(this.BtnGuardarcarUClick);
			// 
			// btnEditarcar
			// 
			this.btnEditarcar.Location = new System.Drawing.Point(291, 336);
			this.btnEditarcar.Name = "btnEditarcar";
			this.btnEditarcar.Size = new System.Drawing.Size(75, 23);
			this.btnEditarcar.TabIndex = 11;
			this.btnEditarcar.Text = "Editar";
			this.btnEditarcar.UseVisualStyleBackColor = true;
			this.btnEditarcar.Click += new System.EventHandler(this.BtnEditarcarClick);
			// 
			// btnEliminacar
			// 
			this.btnEliminacar.Location = new System.Drawing.Point(210, 336);
			this.btnEliminacar.Name = "btnEliminacar";
			this.btnEliminacar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminacar.TabIndex = 10;
			this.btnEliminacar.Text = "Eliminar";
			this.btnEliminacar.UseVisualStyleBackColor = true;
			this.btnEliminacar.Click += new System.EventHandler(this.BtnEliminacarClick);
			// 
			// dgvDatoscar
			// 
			this.dgvDatoscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatoscar.Location = new System.Drawing.Point(279, 70);
			this.dgvDatoscar.Name = "dgvDatoscar";
			this.dgvDatoscar.Size = new System.Drawing.Size(523, 233);
			this.dgvDatoscar.TabIndex = 9;
			this.dgvDatoscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatoscarCellContentClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(117, 336);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(75, 23);
			this.btnGuardar.TabIndex = 8;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// txtDescripcioncar
			// 
			this.txtDescripcioncar.Location = new System.Drawing.Point(17, 216);
			this.txtDescripcioncar.Multiline = true;
			this.txtDescripcioncar.Name = "txtDescripcioncar";
			this.txtDescripcioncar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDescripcioncar.Size = new System.Drawing.Size(230, 89);
			this.txtDescripcioncar.TabIndex = 4;
			// 
			// txtModelocar
			// 
			this.txtModelocar.Location = new System.Drawing.Point(100, 102);
			this.txtModelocar.Name = "txtModelocar";
			this.txtModelocar.Size = new System.Drawing.Size(147, 22);
			this.txtModelocar.TabIndex = 2;
			// 
			// txtMatriculacar
			// 
			this.txtMatriculacar.Location = new System.Drawing.Point(100, 70);
			this.txtMatriculacar.Name = "txtMatriculacar";
			this.txtMatriculacar.Size = new System.Drawing.Size(147, 22);
			this.txtMatriculacar.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 190);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(95, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Descripcion";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Modelo";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Matricula";
			// 
			// txtBuscarautos
			// 
			this.txtBuscarautos.Location = new System.Drawing.Point(390, 25);
			this.txtBuscarautos.Name = "txtBuscarautos";
			this.txtBuscarautos.Size = new System.Drawing.Size(244, 22);
			this.txtBuscarautos.TabIndex = 0;
			this.txtBuscarautos.TextChanged += new System.EventHandler(this.TxtBuscarautosTextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(307, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Buscar";
			// 
			// frmBuscarAutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(821, 541);
			this.Controls.Add(this.gpbBuscarautos);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmBuscarAutos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmBuscarAutos";
			this.Load += new System.EventHandler(this.FrmBuscarAutosLoad);
			this.gpbBuscarautos.ResumeLayout(false);
			this.gpbBuscarautos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatoscar)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
