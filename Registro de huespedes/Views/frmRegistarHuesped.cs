/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 16/07/2018
 * Time: 07:10 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Herramientas;//clase para validar el tipo de dato y, validar las cajas de texto.
using AccesoADatos;
using Registro_de_huespedes.Controladores;//para tener acceso a los datos
using Registro_de_huespedes.Views;//para tener acceso al formulario frmResgistarAuto

namespace Registro_de_huespedes.Views
{
	/// <summary>
	/// Description of frmRegistarHuesped.
	/// </summary>
	public partial class frmRegistarHuesped : Form
	{  
		RegistrarController ORegistro = new RegistrarController();//creamos un nuevo metodo de la clase RegistrarController, que trabajo con los datos
		RegistrarAutosController OAutoadd = new RegistrarAutosController();//creamos un nuevo metodo de la clase RegistarAutosController, que trabajo con los datos
		
		public frmRegistarHuesped()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnRegistrarhuespedClick(object sender, EventArgs e)
		{
			ORegistro.nombre=txtNombre.Text;
			ORegistro.apellido_p=txtApellidoP.Text;
			ORegistro.apellido_m=txtApellidoM.Text;
			ORegistro.edad=Convert.ToInt32(txtEdad.Text);
			ORegistro.sexo=cmbSexo.SelectedItem.ToString();
			ORegistro.estado_civil=cmbEstadoCivil.SelectedItem.ToString();
			ORegistro.procedencia=txtProdedencia.Text;
			ORegistro.nacionalidad=txtNacionalidad.Text;
			ORegistro.correo=txtCorreo.Text;
			ORegistro.telefono=txtTelefono.Text;
			ORegistro.pais=txtPais.Text;
			ORegistro.celular=txtCelular.Text;
			ORegistro.codigo_postal=txtCodigoPostal.Text;
			ORegistro.ciudad=txtCiudad.Text;
		
			ORegistro.agregarnuevohusped();
			
			cleandatoshuesped();
			MessageBox.Show("Datos Registrados Correcctaménte","Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
				
			
			

		}
		void cleandatoshuesped()
		{
			
			txtNombre.Clear();
			txtApellidoP.Clear();
			txtApellidoM.Clear();
			txtTelefono.Clear();
			txtCorreo.Clear();
			txtProdedencia.Clear();
			txtNacionalidad.Clear();
			txtEdad.Clear();
			txtCiudad.Clear();
			txtPais.Clear();
			txtCelular.Clear();
			cmbSexo.Items.Clear();
			txtCodigoPostal.Clear();
			cmbEstadoCivil.Items.Clear();
			
			
		}
		void BtnAgregarautomenupClick(object sender, EventArgs e)
		{
			frmRegistrarAuto OAutonew = new frmRegistrarAuto();//formulario para agregar auto
			OAutonew.ShowDialog();
			
		}
		void TxtNombreKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
		void TxtApellidoPKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
		void TxtApellidoMKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
		void TxtEdadKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("N",e.KeyChar);
		}
		void TxtProdedenciaKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);//valida numeros enteros
		}
		void TxtNacionalidadKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
		void TxtCorreoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.validaCorreo(txtCorreo,e.KeyChar);//valida correo
		}
		void TxtTelefonoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("N",e.KeyChar);//valida numeros enteros
		}
		void TxtPaisKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
		void TxtCelularKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("N",e.KeyChar);//valida numeros enteros
		}
		void TxtCodigoPostalKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);//VALIDA LETRAS Y NUMEROS
		}
		void TxtCiudadKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
//		void TxtPrecioHabitacionKeyPress(object sender, KeyPressEventArgs e)
//		{
//			e.KeyChar = Validaciones.validaReal(txtPrecioHabitacion,e.KeyChar);//valida punto decimal
//		}
		void TxtNumerohabitacionKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("N",e.KeyChar);//valida numeros enteros
		}
		void TxtCantidadniniosKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("N",e.KeyChar);//valida numeros enteros
		}
		void TxtCantidadadultosKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("N",e.KeyChar);//valida numeros enteros
		}
		
		
	
		
		
	}
}
