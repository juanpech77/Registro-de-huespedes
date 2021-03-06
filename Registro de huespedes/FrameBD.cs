﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
//using SEUTCV2.Properties;
using System.Windows.Forms;

namespace AccesoADatos
{
   
  public  class FrameBD
    {
        //string ser;
        //string por;
        //string pas;
        //string use;
        //string db;
        public static MySqlConnection conex = new MySqlConnection();
       
        public static string servidor;
        public static uint puerto;
        public static string usuario;
        public static string password;
        public static string bd;

         //defino una propiedad para el rol de usuario autentificado
        public static string rol;
        //defino una propiedaad para el tratamiento y el usuario que accede
        public static string quienAccede;

      //public FrameBD(string servidor, uint puerto, string usuario, string password, string bd)
        static FrameBD()
        {
            // TODO: Complete member initialization
            servidor = "127.0.0.1";
            puerto = 3309;
            usuario = "root";
            password = "12345";
            bd = "proyectohotel";


            conex.Close();
            MySqlConnectionStringBuilder conexs = new MySqlConnectionStringBuilder();
            conexs.Server = servidor;
            conexs.Port = puerto;//Convert.ToUInt32(por);
            conexs.Password = password; //pas;
            conexs.UserID = usuario; //use;
            conexs.Database = bd;

            //MySqlConnection conex = new MySqlConnection(conexs.ToString() );
            conex.ConnectionString = conexs.ConnectionString;
            //MySqlConnection conn = new MySqlConnection(builder.ToString());


            conex.Open(); 
            
        }
         
      public static void conectar() 
        {
            conex.Close(); 
            conex.Open(); 
              
        }


      public static  DataSet SQLSEL(string sql)
      {
          conectar();

          MySqlDataAdapter Adaptador = new MySqlDataAdapter(sql, conex);
          DataSet RsDatos = new DataSet();
          Adaptador.Fill(RsDatos, "datos");
          //SQLSEL = RsDatos;
          return (RsDatos);
          //conex.Close(); 
      }

      //TRABAJA CON COMBOBOX

      public static DataTable SQLCOMBO(string sql) 
      {
          conectar();
          MySqlDataAdapter Adap = new MySqlDataAdapter(sql,conex);
          DataTable DT = new DataTable();
          Adap.Fill(DT);
          return DT;
 
      }

      //Permite ejecutar comandos INSERT, DELETE Y UPDATE
      // De ahi deriva el IDU
      public static void SQLIDU(string sql) 
      {
           
          try
          {
              
              conectar();
              MySqlCommand comando = new MySqlCommand(sql, conex);
              comando.ExecuteNonQuery();
              //conex.Close();
              


          }
          catch (MySqlException ex) 
          {
           
              
              MessageBox.Show(ex.Message + " " + ex.Number); 
              
              
              //throw;
          }
          
      }

      public static MySqlDataReader SQLReader(string sql) 
      {
          conectar();
          MySqlCommand comando = new MySqlCommand(sql, conex);
          
         MySqlDataReader Dr = comando.ExecuteReader();
          return Dr;


      }

      public static string[] ObtieneCampo(string tabla,string condicion,string campo) 
      {
          
          string sqlaux = "SELECT " + campo +
                         " FROM " + tabla +
                         " WHERE " + condicion;

          MySqlDataReader dt =  SQLReader(sqlaux);
          int cont = 0;

          string[] respaux = new string[1]; 
          respaux[0] = "";
          
          if (dt.HasRows)
          {
             
              while (dt.Read())
              {
                  Array.Resize(ref respaux, respaux.Length + 1);

                  if (dt.GetString(0) != null)
                  {
                      respaux[cont] = dt.GetString(0);
                      cont++;
                  }
                  
              }
          }
          Array.Resize(ref respaux, respaux.Length-1);
          return respaux;

      }
      public static string[] ObtieneCampos(string tabla, string condicion, string campo)//nuevo metodo que copiamos
      {

          string sqlaux = "SELECT " + campo +
                         " FROM " + tabla +
                         " WHERE " + condicion;

          MySqlDataReader dt = SQLReader(sqlaux);
          int cont = 0;

          string[] respaux = new string[1];
          respaux[0] = "";
          
          if (dt.HasRows)
          {

              while (dt.Read())
              {

                  for (int i = 0; i < dt.FieldCount; i++)
                  {
                      Array.Resize(ref respaux, respaux.Length + 1);
                      string valor = dt.IsDBNull(i) ? String.Empty : dt.GetString(i);
                      //if (Convert.ToString(dt.GetString(i)) !="")
                          respaux[cont] = valor;
                      //else
                        //  respaux[cont] = "";
                      cont++;
                  }
                  

              }
          }
          Array.Resize(ref respaux, respaux.Length - 1);
          return respaux;

      }
      
       public static void comboComplete(string sql,ComboBox cmb,string mostrar, string pk) 
      {
          conectar();
          MySqlDataAdapter Adap = new MySqlDataAdapter(sql, conex);
          DataTable DT = new DataTable();
          Adap.Fill(DT);

          cmb.DataSource = DT;
          cmb.DisplayMember = mostrar;
          cmb.ValueMember = pk;

          AutoCompleteStringCollection stringCol = new AutoCompleteStringCollection();

          foreach (DataRow row in DT.Rows)
          {
              stringCol.Add(Convert.ToString(row[mostrar]));
          }

          cmb.AutoCompleteCustomSource = stringCol;
          cmb.AutoCompleteMode = AutoCompleteMode.Suggest;
          cmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
   
            
          
         
 
      }

    }




    
}
