/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 28/07/2018
 * Time: 10:46 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;//para tener acceso a los componentes

namespace Registro_de_huespedes.Controladores
{
	/// <summary>
	/// Description of RegistrarUusariosController.
	/// </summary>
	public class RegistrarUusariosController
	{
		//Definimos los campos como atributos
		public string idlogin { get; set; }
		public string passlogin { get; set; }
		public string rolusuario {get; set;}
		public string tratamiento {get; set;}
		public string usuario {get; set;}
		
		public RegistrarUusariosController()
		{
		}
		
		public void BuscarUsuarios( string name, DataGridView dgv)
		{
			string sql = "SELECT * FROM usuarios WHERE usuario LIKE'" + name + "%'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "datos";
		}
		
		public void Agregarusuarios()
		{
			string sql = string.Format("INSERT INTO usuarios(idlogin,passlogin,rolusuario,tratamiento,usuario) VALUES('{0}','{1}','{2}','{3}','{4}')",
			                           idlogin,passlogin,rolusuario,tratamiento,usuario);
			FrameBD.SQLIDU(sql);
		}
		
		public void Destroy(string pk)
		{
			string sql = string.Format("DELETE FROM usuarios WHERE idlogin='{0}';",pk);
			FrameBD.SQLIDU(sql);
		}
		
		public void Actualizarusuarios(string idlo, string pass, string rolusu,string trata,string user,string copiaidlo)
		{
			string sql = string.Format("UPDATE usuarios SET idlogin='{0}',passlogin='{1}',rolusuario='{2}',tratamiento='{3}',usuario='{4}' WHERE idlogin='{5}';",idlo,pass,rolusu,trata,user,copiaidlo);
			FrameBD.SQLIDU(sql);
		}
//		string sql = string.Format("UPDATE autos_clientes SET matricula='{0}', modelo='{1}',descripcion='{2}',folio='{3}' WHERE matricula='{4}';",mat,mod,des,fo,copiamat);
//			FrameBD.SQLIDU(sql);
	}
}
