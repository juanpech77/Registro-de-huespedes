/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 19/07/2018
 * Time: 07:47 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Registro_de_huespedes.Controladores;//para tener acceso a los datos
using AccesoADatos;
namespace Registro_de_huespedes.Views
{
	/// <summary>
	/// Description of frmBuscarAutos.
	/// </summary>
	public partial class frmBuscarAutos : Form
	{
		RegistrarAutosController OBusca = new RegistrarAutosController();
		public frmBuscarAutos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmBuscarAutosLoad(object sender, EventArgs e)
		{
			OBusca.Buscarautos(txtBuscarautos.Text,dgvDatoscar);//para que funcione el metodo
		}
		void TxtBuscarautosTextChanged(object sender, EventArgs e)
		{
			OBusca.Buscarautos(txtBuscarautos.Text,dgvDatoscar);//buscar un auto atarvez de la matricula
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			 if(txtMatriculacar.Text !="" && txtModelocar.Text !="" && txtFoliocar.Text !="" )
			{
			 	
			 	OBusca.matricula=txtMatriculacar.Text;
			 	OBusca.modelo=txtModelocar.Text;
				OBusca.folio=txtFoliocar.Text;
				OBusca.descripcion=txtDescripcioncar.Text;
				OBusca.agregarauto();
				OBusca.Buscarautos(txtBuscarautos.Text,dgvDatoscar);
				txtMatriculacar.Clear();
				txtModelocar.Clear();
				txtDescripcioncar.Clear();
				txtFoliocar.Clear();
				MessageBox.Show("Datos Registrados Con Exito","Registro Exitoso",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			 
			 
			else
			{
			 	MessageBox.Show("Igrese todos los datos para registrarse");
				
			}	
			

			
			
		}
		void BtnEliminacarClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("Estas seguro de Eliminar","Cuidado",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes);
			{
				string clave = dgvDatoscar[0,dgvDatoscar.CurrentCellAddress.Y].Value.ToString();
				OBusca.Eliminarautos(clave);
				OBusca.Buscarautos(txtBuscarautos.Text,dgvDatoscar);//actualizamos el datagrid
			}
		}
		void BtnEditarcarClick(object sender, EventArgs e)
		{
			
				txtMatriculacar.Text = dgvDatoscar[0,dgvDatoscar.CurrentCellAddress.Y].Value.ToString(); 
				txtMatriculacar.Tag = dgvDatoscar[0,dgvDatoscar.CurrentCellAddress.Y].Value.ToString();//id visisble
				txtModelocar.Text = dgvDatoscar[1,dgvDatoscar.CurrentCellAddress.Y].Value.ToString();
				txtDescripcioncar.Text = dgvDatoscar[3,dgvDatoscar.CurrentCellAddress.Y].Value.ToString();
				txtFoliocar.Text = dgvDatoscar[2,dgvDatoscar.CurrentCellAddress.Y].Value.ToString();
				btnGuardarcarU.Visible=true;
				btnGuardar.Visible=false;
			
			
		}
		void BtnGuardarcarUClick(object sender, EventArgs e)
		{
			OBusca.Buscarautos(txtBuscarautos.Text,dgvDatoscar);//actualizamos el datagrid
			if (txtModelocar.Text!="" && txtFoliocar.Text!="")
			{
				OBusca.Actualizarautos(txtMatriculacar.Text,txtModelocar.Text,txtFoliocar.Text,txtDescripcioncar.Text,txtMatriculacar.Tag.ToString());
			
				btnGuardarcarU.Visible=false;
				btnGuardar.Visible=true;
				MessageBox.Show("Datos Agregados Correctamente","Registro",MessageBoxButtons.OK,MessageBoxIcon.Information);	
			}
			else 
			{
				MessageBox.Show("Igrese todos los datos para registrarse");
			}
			
				txtMatriculacar.Clear();
				txtModelocar.Clear();
				txtFoliocar.Clear();
				txtDescripcioncar.Clear();
		
		}
		void Button1Click(object sender, EventArgs e)
		{
			dataGridView1.Visible=true;
		}
		void DgvDatoscarCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
	
		
		
		
	}
}
