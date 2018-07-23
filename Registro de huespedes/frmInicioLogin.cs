/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 12/07/2018
 * Time: 05:32 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Herramientas;//clase para validar el tipo de dato
using AccesoADatos;

namespace Registro_de_huespedes
{
	/// <summary>
	/// Description of frmInicioLogin.
	/// </summary>
	public partial class FrmInicioLogin : Form
	{
		public FrmInicioLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//timer1.Enabled=true;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

	
		void TmrFechahoraTick(object sender, EventArgs e)
		{
			//lblHora.Text=DateTime.Now.ToString("h:mm:ss");//si ponemos "HH:mm:ss" muestra la hora en formato 24hrs
			lblHora.Text=DateTime.Now.ToLongTimeString();
			lblFecha.Text=DateTime.Now.ToLongDateString();
		}
		void TxtUsuariologinKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);//valida el checkbox usuario
		}
		void TxtContrasenialoginKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);//valida la contraseña del usuario
		}
		void FrmInicioLoginLoad(object sender, EventArgs e)
		{
//			Size desktopSize = System.Windows.Forms.SystemInformation.PrimaryMonitorMaximizedWindowSize;
//			Int32 alto = (desktopSize.Height -200) /2;
//			Int32 ancho = (desktopSize.Width -500) /2;
//			frmInicioLogin.Location = new Point(ancho, alto);
		}
//		void BtnSalirloginClick(object sender, EventArgs e)
//		{
//			if (MessageBox.Show("Seguro Qué Decea Salir","Cuidado",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
//			{
//				if (MessageBox.Show("Esta Seguro","Cuidado",MessageBoxButtons.YesNo)==DialogResult.Yes)
//				{
//					Application.Exit();
//				}
//			}
//		}
		void BtnIngresarloginMouseHover(object sender, EventArgs e)
		{
			btnIngresarlogin.Size = new Size(105,35);
			
		}
		void BtnIngresarloginMouseLeave(object sender, EventArgs e)
		{
			btnIngresarlogin.Size=new Size(100,30);
		}
		void BtnSalirdeloginClick(object sender, EventArgs e)
		{
//			
			if (MessageBox.Show("Seguro Qué Decea Salir","Cuidado",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
			{
				if (MessageBox.Show("Esta Seguro","Cuidado",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
				{
					Application.Exit();
				}
			}
	
		}
		void BtnRegistrarseloginMouseHover(object sender, EventArgs e)
		{
			btnRegistrarselogin.Size=new Size(105,35);
		}
		void BtnRegistrarseloginMouseLeave(object sender, EventArgs e)
		{
			btnRegistrarselogin.Size=new Size(100,30);
		}
		void BtnIngresarloginClick(object sender, EventArgs e)
		{
			//pedimos los datos en forma de un vector
			string condicion = string.Format("idlogin='{0}'",//solo pedimos la id para comprobar que existe el usuario
			                                 txtUsuariologin.Text);
			string [] datos= FrameBD.ObtieneCampos("usuarios",condicion,"idlogin,passlogin,rolusuario,tratamiento,usuario");//es un metodo muy flexibe
			if (datos.Length>1)//si pasa el primer if entonces el usuario si existe
			{
				if (datos[1]==txtContrasenialogin.Text) //si el vector encuentra mas de una pocicion entonces existe			
				{ //si txtPass.text coicide en la BD, lo que escribio el usuario
					
					//MessageBox.Show("Bienvenido:" + datos[2]);
					FrameBD.rol=datos[2];
					FrameBD.quienAccede = datos[3] + " " + datos[4];
					
					MainForm oAbrirmenu = new MainForm();
					this.Hide();//Este codigo hace que el formulario de login se oculte
					oAbrirmenu.ShowDialog();
					this.Close();
				}
				else 
					MessageBox.Show("La Contraseña es incoreccta");
			}
			else 
				MessageBox.Show("El Usuario No Existe");
		}
		
		
		
	}
}
