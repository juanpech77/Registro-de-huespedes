/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 19/07/2018
 * Time: 06:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;//para tener acceso a los componentes

namespace Registro_de_huespedes.Controladores
{
	/// <summary>
	/// Description of RegistrarAutosController.
	/// </summary>
	public class RegistrarAutosController
	{
		//definimos los campos como las variables de la tabla autos_clientes
		public string matricula { get; set; }
		public string modelo { get; set; }
		public string descripcion { get; set; }
		public string folio { get; set; }
		
		
		public RegistrarAutosController()
		{
		}
		
		
		
		public void Buscarautos(string matri, DataGridView dgv)//buscar autos 
		{
			string sql = "SELECT * FROM autos_clientes WHERE matricula LIKE'" + matri + "%'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "datos";
		}
		public void agregarauto()//viene la inserccion mediante el formulario de agregar huesped
		{
			string sql = string.Format("INSERT INTO autos_clientes(matricula,modelo,folio,descripcion)VALUES ('{0}','{1}','{2}','{3}')",
			                          matricula,modelo,folio,descripcion);
			FrameBD.SQLIDU(sql);
		}
		
		public void Eliminarautos( string idauto)
		{
			string sql = string.Format("DELETE FROM autos_clientes WHERE matricula='{0}';",idauto);
			FrameBD.SQLIDU(sql);
		}
		
		public void Actualizarautos( string mat, string mod,string des,string fo,string copiamat)
		{
			string sql = string.Format("UPDATE autos_clientes SET matricula='{0}', modelo='{1}',descripcion='{2}',folio='{3}' WHERE matricula='{4}';",mat,mod,des,fo,copiamat);
			FrameBD.SQLIDU(sql);
		}
		/*public void Storeautos()
		{
			string sql = string.Format("INSERT INTO autos_clientes(matricula,modelo,descripcion,folio)VALUES ('{0}','{1}','{2}',{3})",
			                           matricula,modelo,descripcion,folio);
			FrameBD.SQLIDU(sql);
		}*/
	}
}
