/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 28/07/2018
 * Time: 10:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Registro_de_huespedes.Controladores;
using AccesoADatos;
using Herramientas;
namespace Registro_de_huespedes.Views
{
	/// <summary>
	/// Description of frmVerUsuarios.
	/// </summary>
	public partial class frmVerUsuarios : Form
	{
		//instanciomos la clase RegistrarUusariosController para comunicarse con la base de datos
		RegistrarUusariosController Ousuario = new RegistrarUusariosController();
		public frmVerUsuarios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmVerUsuariosLoad(object sender, EventArgs e)
		{
			Ousuario.BuscarUsuarios(txtBuscarusu.Text,dgvDatosusuarios);
		}
		void TxtBuscarusuTextChanged(object sender, EventArgs e)
		{
			Ousuario.BuscarUsuarios(txtBuscarusu.Text,dgvDatosusuarios);
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if (txtUsudelogin.Text !="" && txtContraseñalogin.Text !="" && txtRolusuario.Text !="" && txtTratamientousu.Text !="" && txtNombreusuario.Text !="")
			{
				Ousuario.idlogin = txtUsudelogin.Text;//id del usuario es como su nombre de usuario
				Ousuario.passlogin = txtContraseñalogin.Text;//contaseña para acceder al sistema
				Ousuario.rolusuario = txtRolusuario.Text;
				Ousuario.tratamiento = txtTratamientousu.Text;
				Ousuario.usuario = txtNombreusuario.Text;
				Ousuario.Agregarusuarios();
				Ousuario.BuscarUsuarios(txtBuscarusu.Text,dgvDatosusuarios);
				MessageBox.Show("Datos Registrados Con Exito","Registro Exitoso",MessageBoxButtons.OK,MessageBoxIcon.Information);
				txtUsudelogin.Clear();
				txtContraseñalogin.Clear();
				txtRolusuario.Clear();
				txtTratamientousu.Clear();
				txtNombreusuario.Clear();
			}
			else 
				MessageBox.Show("Ingrese Todos Los Datos Para Registrarse En El Sistema","Cuidado",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}//termina el evento click de guardar
		void BtnEliminarusuClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("ESTAS SEGURO DE ELIMINAR","Cuidado",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
			{
				string clave = dgvDatosusuarios[0,dgvDatosusuarios.CurrentCellAddress.Y].Value.ToString();
				Ousuario.Destroy(clave);
				Ousuario.BuscarUsuarios(txtBuscarusu.Text,dgvDatosusuarios);//actualizamos el datagridview
			}
		}//termina el evento clic al dar eliminar
		void TxtModicarusuClick(object sender, EventArgs e)
		{
			txtUsudelogin.Text = dgvDatosusuarios[0,dgvDatosusuarios.CurrentCellAddress.Y].Value.ToString();
			txtUsudelogin.Tag = dgvDatosusuarios[0,dgvDatosusuarios.CurrentCellAddress.Y].Value.ToString();//id visisble
			txtContraseñalogin.Text = dgvDatosusuarios[1,dgvDatosusuarios.CurrentCellAddress.Y].Value.ToString();
			txtRolusuario.Text = dgvDatosusuarios[2,dgvDatosusuarios.CurrentCellAddress.Y].Value.ToString();
			txtTratamientousu.Text = dgvDatosusuarios[3,dgvDatosusuarios.CurrentCellAddress.Y].Value.ToString();
			txtNombreusuario.Text = dgvDatosusuarios[4,dgvDatosusuarios.CurrentCellAddress.Y].Value.ToString();
			btnGuardarcambios.Visible=true;
			btnAgregar.Visible=false;
		}
		void BtnGuardarcambiosClick(object sender, EventArgs e)
		{
			Ousuario.BuscarUsuarios(txtBuscarusu.Text,dgvDatosusuarios);//actualizamos el datagridview
			if (txtUsudelogin.Text !="" && txtContraseñalogin.Text !="" && txtRolusuario.Text !="" && txtTratamientousu.Text !="" && txtNombreusuario.Text !="")
			{
				Ousuario.Actualizarusuarios(txtUsudelogin.Text,txtContraseñalogin.Text,txtRolusuario.Text,txtTratamientousu.Text,txtNombreusuario.Text,txtUsudelogin.Tag.ToString());
				
				MessageBox.Show("Datos Agregados Correctamente","Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);
				//Ousuario.BuscarUsuarios(txtBuscarusu.Text,dgvDatosusuarios);//actualizamos el datagridview
			}
			else
				MessageBox.Show("Igrese todos los datos para Guardar Cambios vila","Cuidado",MessageBoxButtons.OK,MessageBoxIcon.Error);
			txtUsudelogin.Clear();
			txtContraseñalogin.Clear();
			txtRolusuario.Clear();
			txtTratamientousu.Clear();
			txtNombreusuario.Clear();
			txtBuscarusu.Clear();
			btnGuardarcambios.Visible=false;
			btnAgregar.Visible=true;
		}
		
		
	}
}
