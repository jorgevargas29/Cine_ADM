using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cine_Adm
{
    class Usuario2:Usuario
    {
         string usuario;
         string contra;
        string acceso;
           public Usuario2(){
            this.usuario = string.Empty;
            this.contra = string.Empty;
            sql = string.Empty;
}

        public string Acceso
        {
            get { return acceso; }
            set { acceso = value; }
        }

        public string Usuarios
        {
            get { return usuario; }
            set { usuario = value; }
        }
        

        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }


        public bool buscar()
        {
            bool resul = false;
            this.sql = string.Format(@"select ID_TRABAJADOR from TRABAJADOR where TB_USUARIO='{0}'and TB_PASSWORD='{1}' and TB_ACCESO='{2}'", this.Usuarios, this.Contra,this.Acceso);
            this.sqlcomm = new SqlCommand(this.sql,this.sqlconn);
            sqlconn.Open();
            SqlDataReader read = null;
            read= this.sqlcomm.ExecuteReader();
            if(read.Read()){
                resul=true;
                this.mensaje="Bienvenido";
            }
            else{
                this.mensaje="Datos incorrectos";
            }
            this.sqlconn.Close();
            return resul;

            }
        }
    }
    

