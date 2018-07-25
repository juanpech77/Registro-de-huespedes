/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 17/07/2018
 * Time: 11:17 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Herramientas;
using AccesoADatos;
using Registro_de_huespedes.Controladores;//para tener acceso a los datos de los dos formularios
using Registro_de_huespedes.Views;//para tener acceso a los dos formularios



namespace Registro_de_huespedes.Views
{
	/// <summary>
	/// Description of frmRegistrarAuto.
	/// </summary>
	public partial class frmRegistrarAuto : Form
	{
		RegistrarAutosController oDatosauto = new RegistrarAutosController();
		public frmRegistrarAuto()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnAgregarAutoClick(object sender, EventArgs e)
		{
			//EliminarMsjdeError();
			if(txtMatriculaauto.Text=="")
			{
				MessageBox.Show("Ingrese una matricula");
			}
			
			else if (txtModeloauto.Text==""){
			
			MessageBox.Show("Ingrese un modelo");
			
			}
			else if (txtFoliodelhuesped.Text=="")
			{
				MessageBox.Show("Ingrese un folio");
			}
			else if (txtDescripcionauto.Text=="")
			{
				MessageBox.Show("Ingrese una descripcion");
			}
			
			else{
				
			MessageBox.Show("Datos Ingresados Correctamente");
			oDatosauto.matricula = txtMatriculaauto.Text;
			oDatosauto.modelo = txtModeloauto.Text;
			oDatosauto.folio = txtFoliodelhuesped.Text;
			oDatosauto.descripcion = txtDescripcionauto.Text;
			oDatosauto.agregarauto();
			limpiadatosauto();
			}
			
			
			
			
		}
		void limpiadatosauto()
		{
			txtMatriculaauto.Clear();
			txtModeloauto.Clear();
			txtFoliodelhuesped.Clear();
			txtDescripcionauto.Clear();
		}
		void TxtMatriculaautoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);
		}
		void TxtModeloautoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);
		}
		void TxtFoliodelhuespedKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);
		}
		void TxtDescripcionautoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);
		}
		private bool validarcamposvacios()
		{
			bool ok = true;
			if (txtMatriculaauto.Text=="") 
			{
				ok = false;
				errorProvider1.SetError(txtMatriculaauto,"Ingrese Un Dato Correcto");
			}
			if (txtModeloauto.Text=="") 
			{
				ok = false;
				errorProvider1.SetError(txtModeloauto,"Ingrese Un Dato Correcto");
			}
			if (txtFoliodelhuesped.Text=="") 
			{
				ok = false;
				errorProvider1.SetError(txtFoliodelhuesped,"Ingrese Un Dato Correcto");
			}
			if (txtDescripcionauto.Text=="") 
			{
				ok = false;
				errorProvider1.SetError(txtDescripcionauto,"Ingrese Un Dato Correcto");
			}
			return ok;
			
		}
		private void EliminarMsjdeError()
		{
			errorProvider1.SetError(txtMatriculaauto, "");
			errorProvider1.SetError(txtModeloauto, "");
			errorProvider1.SetError(txtFoliodelhuesped, "");
			errorProvider1.SetError(txtDescripcionauto, "");
		}
		
		
	}	
}
