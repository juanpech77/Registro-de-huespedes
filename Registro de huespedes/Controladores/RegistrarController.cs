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
		public string folioregistro { get; set; }
		public string nombre { get; set; }//1
		public string apellido_p { get; set; }
		public string apellido_m { get; set; }
		public string telefono { get; set; }
		public string correo { get; set; }
		public string fe_registro { get; set; }
		public string fs_registro { get; set; }
		public string procedencia { get; set; }
		public string nacionalidad { get; set; }
		public int edad { get; set; }//tipo de dato correcto Tinyint//
		public string ciudad { get; set; }
		public string pais { get; set; }
		public int cantidad_ninios { get; set; }//tipo de dato correcto Integer
		public int cantidad_adultos { get; set; }//tipo de dato correcto Integer
		public string hora_registro { get; set; }
		public string celular { get; set; }
		public string sexo { get; set; }
		public string codigo_postal { get; set; }
		public string estado_civil { get; set; }
		public float precio { get; set; }
		public int numero_habitacion { get; set; }//tipo de dato correcto Integer
		
		public int idusu {get; set;}
		
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
		  
		  public void addregistronuevo()//forulario cuando se de click Registrar cliente
		  {
		  	string sql=string.Format("INSERT INTO checkin_registro(folioregistro,precio,fe_registro,fs_registro,cantidad_ninios,cantidad_adultos,hora_registro,numero_habitacion,idusu) VALUES('{0}',{1},'{2}','{3}',{4},{5},'{6}',{7},{8})",
		  	                         folioregistro,precio,fe_registro,fs_registro,cantidad_ninios,cantidad_adultos,hora_registro,numero_habitacion,idusu);
		  	FrameBD.SQLIDU(sql);
		  }
		  
		  public void getdatoshuespedesexistentes(ComboBox cmb)//obtener los datos, no inporta como se llame el combobox afuera
		  {
		  	//PASO 1: definimos los datos que llenaran al combobox
		  	string buscarid = "SELECT idusu,nombre,apellido_p,apellido_m FROM huespedes";
		  	
		  	//PASO 2: vinculamos los datos al Datasoource
		  	cmb.DataSource=FrameBD.SQLCOMBO(buscarid);
		  	
		  	//PASO 3 : especificar el valor a mostrar al usuario
		  	cmb.DisplayMember="nombre,apellido_p,apellido_m";
		  	
		  	//PASO 4: Definir la clave primaria
		  	cmb.ValueMember="idusu";
		  	
		  }
	}
}
