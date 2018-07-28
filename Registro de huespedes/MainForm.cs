/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 11/07/2018
 * Time: 11:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Herramientas;//clase que valida el tipo de dato
using AccesoADatos;//agregamos referencia al namespace de la clase statica.
using Registro_de_huespedes.Views;//para tener acceso al formulario frmRegistarHuesped
using Registro_de_huespedes.Controladores;

	
namespace Registro_de_huespedes
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
				
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			lblRol.Text = "ROL: " + FrameBD.rol;//estado que muestra abajo que tipo de rol hace
			lblUsuario.Text ="BIENVENIDO: " +FrameBD.quienAccede;//muestra el nombre completo de la persona 
		}
		void PBDesplazaMenuClick(object sender, EventArgs e)
		{
			if (PanMenuVertical.Width == 150)
            {
                PanMenuVertical.Width = 55;
            }
            else
                PanMenuVertical.Width = 150;
		}
		void BtnRegistrarHuespedClick(object sender, EventArgs e)
		{
			frmCheckinRegistro oNuevoregistro = new frmCheckinRegistro();
			oNuevoregistro.ShowDialog();
//			frmRegistarHuesped ODatioshuesped = new frmRegistarHuesped();
//			//ODatioshuesped.MdiParent=this;
//			ODatioshuesped.ShowDialog();

		}
		
		void BtnAutomovilClick(object sender, EventArgs e)
		{
			frmBuscarAutos ODatoscarhuesped = new frmBuscarAutos();
			ODatoscarhuesped.ShowDialog();
		}
		void MnuRegistrosGuClick(object sender, EventArgs e)
		{
			FrmRegistrosguardados oVerregistros = new FrmRegistrosguardados();
			oVerregistros.MdiParent=this;
			oVerregistros.Show();
		}
		void MnuAgregarUsuarioClick(object sender, EventArgs e)
		{
			frmVerUsuarios Ousuarioo = new frmVerUsuarios();
			Ousuarioo.MdiParent=this;
			Ousuarioo.Show();
		}
		
	}
}
