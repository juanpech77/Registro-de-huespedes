/*
 * Created by SharpDevelop.
 * User: Juan Carlos Pech E
 * Date: 17/07/2018
 * Time: 11:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;//para tener acceso a los datos
using System.Windows.Forms;//para tener acceso a los componentes del frmRegistarHuesped.cs

namespace Registro_de_huespedes.Controladores
{
	/// <summary>
	/// Description of RegistrarController.
	/// </summary>
	public class RegistrarController
	{
		//Definimos los campos como atributos
		public string folio { get; set; }//0
		public string nombre { get; set; }//1
		public string apellido_p { get; set; }//2
		public string apellido_m { get; set; }//3
		public string telefono { get; set; }//4
		public string correo { get; set; }//5
		public string fe_registro { get; set; }//6
		public string fs_registro { get; set; }//7
		public string procedencia { get; set; }//8
		public string nacionalidad { get; set; }//9
		public int edad { get; set; }//tipo de dato correcto Tinyint//10
		public string ciudad { get; set; }//11
		public string pais { get; set; }//12
		public int cantidad_ninios { get; set; }//tipo de dato correcto Integer//13
		public int cantidad_adultos { get; set; }//tipo de dato correcto Integer//14
		public string hora_registro { get; set; }//15
		public string celular { get; set; }//16
		public string sexo { get; set; }//17
		public string codigo_postal { get; set; }//18
		public string estado_civil { get; set; }//19
		public float precio { get; set; }//20
		public int numero_habitacion { get; set; }//tipo de dato correcto Integer//21
		
		
		
//		Value.ToString("yyyy-MM-dd") 
//		Value.ToString("hh:mm:ss")
		public RegistrarController()
		{
		}
		
											
		public void agregarnuevohusped()
		{
			string sql=string.Format("INSERT INTO huespedes(nombre,apellido_p,apellido_m,edad,sexo,estado_civil,procedencia,nacionalidad,correo,telefono,pais,celular,codigo_postal,ciudad) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}')",
			                         nombre,apellido_p,apellido_m,edad,sexo,estado_civil,procedencia,nacionalidad,correo,telefono,pais,celular,codigo_postal,ciudad);
			                         
			FrameBD.SQLIDU(sql);
			
		}
		
		  public string genera_clave(int l)
        {
            Random aleatorio = new Random();
            string res = "";
            string[] vals = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            for (int i = 0; i <= l; i++)
            {
                res = res + vals[aleatorio.Next(vals.GetUpperBound(0) + 1)];
            }
            
            return res;

            
        }
	}
}
