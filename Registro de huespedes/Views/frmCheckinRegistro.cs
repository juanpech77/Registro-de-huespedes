/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 23/07/2018
 * Time: 09:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Registro_de_huespedes.Views;//acceso a los formularios
using Registro_de_huespedes.Controladores;//acceso a los datos
using AccesoADatos;

namespace Registro_de_huespedes.Views
{
	/// <summary>
	/// Description of frmCheckinRegistro.
	/// </summary>
	public partial class frmCheckinRegistro : Form
	{
		RegistrarController addnuevoregistro =new RegistrarController();
		//RegistrarController oDatoid = new RegistrarController();
		
		public frmCheckinRegistro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnAgregarnewdatosClick(object sender, EventArgs e)
		{
			frmRegistarHuesped nuevosdatos = new frmRegistarHuesped();
			nuevosdatos.ShowDialog();
		}
		void BtnRegistrarcuandoyaexistaClick(object sender, EventArgs e)
		{
			addnuevoregistro.folioregistro=txtFoliocheckin.Text;//se genera automaticamente
			addnuevoregistro.precio=Convert.ToSingle(txtPrecioHabitacion.Text);
			addnuevoregistro.fe_registro=dtpFechaEntrada.Value.ToString("yyyy-MM-dd");
			addnuevoregistro.fs_registro=dtpFechaSalida.Value.ToString("yyyy-MM-dd");
			addnuevoregistro.cantidad_ninios=Convert.ToInt32(txtCantidadninios.Text);
			addnuevoregistro.cantidad_adultos=Convert.ToInt32(txtCantidadadultos.Text);
			addnuevoregistro.hora_registro=dtpHoraderegistro.Value.ToString("hh:mm:ss tt");
			addnuevoregistro.numero_habitacion=Convert.ToInt32(txtNumerohabitacion.Text);
			addnuevoregistro.idusu = Convert.ToInt32(cmbElijirhuespedsiexiste.SelectedValue.ToString());//elejir dato del huesped si existe
			
			
			addnuevoregistro.addregistronuevo();
			clearegistro();
		}
		void FrmCheckinRegistroLoad(object sender, EventArgs e)
		{
			txtFoliocheckin.Text = addnuevoregistro.genera_clave(6);
			addnuevoregistro.getdatoshuespedesexistentes(cmbElijirhuespedsiexiste);
		}
		void clearegistro()
		{
			txtFoliocheckin.Clear();
			txtPrecioHabitacion.Clear();
			txtNumerohabitacion.Clear();
			//dtpFechaEntrada
			//dtpFechaSalida
			txtCantidadninios.Clear();
			txtCantidadadultos.Clear();
			//dtpHoraderegistro
			cmbElijirhuespedsiexiste.SelectedIndex = 0;
			
		}
		
	}
}
