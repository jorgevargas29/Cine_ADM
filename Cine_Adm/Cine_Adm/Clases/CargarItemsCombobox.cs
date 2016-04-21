using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Cine_Adm
{
    class CargarItemsCombobox
    {
        
        string conexion = "Data Source=USER;Initial Catalog=CINE;Integrated Security=True;";
        SqlConnection sqlconn;
        SqlDataReader sqldr;
        SqlCommand sqlcomm;
        public CargarItemsCombobox(){
        try{
        sqlconn= new SqlConnection(conexion);
        sqlconn.Open();

        }
        catch (Exception e) { }
        }
       public void llenaritem(ComboBox cb ){
           try{
               sqlcomm = new SqlCommand("select SC_CUIDAD from SUCURSAL", sqlconn);
               sqldr = sqlcomm.ExecuteReader();
               while (sqldr.Read())
               {
                   cb.Items.Add(sqldr["SC_CUIDAD"].ToString());
               } sqldr.Close();
           }
            catch (Exception e) {
            
            }

       }

       public void llenaritemT(ComboBox cb)
       {
           try
           {
               sqlcomm = new SqlCommand("select ID_SUCURSAL from SUCURSAL", sqlconn);
               sqldr = sqlcomm.ExecuteReader();
               while (sqldr.Read())
               {
                   cb.Items.Add(sqldr["ID_SUCURSAL"].ToString());
               } sqldr.Close();
           }
           catch (Exception e)
           {

           }

       }
       public void llenaritemP(ComboBox cb)
       {
           try
           {
               sqlcomm = new SqlCommand("select PL_TITULO from PELICULA", sqlconn);
               sqldr = sqlcomm.ExecuteReader();
               while (sqldr.Read())
               {
                   cb.Items.Add(sqldr["PL_TITULO"].ToString());
               } sqldr.Close();
           }
           catch (Exception e)
           {

           }

       }

       public void llenaritemH(ComboBox cb)
       {
           try
           {
               sqlcomm = new SqlCommand("select FN_HORARIO from PPROYECCIO", sqlconn);
               sqldr = sqlcomm.ExecuteReader();
               while (sqldr.Read())
               {
                   cb.Items.Add(sqldr["FN_HORARIO"].ToString());
               } sqldr.Close();
           }
           catch (Exception e)
           {

           }

       }

    }
    }

