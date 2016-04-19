using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cine_Adm
{
    class Usuario
    {
        public string cadenadeconexion;
        protected string sql;
        protected SqlConnection sqlconn;
        protected SqlCommand sqlcomm;
        protected string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

       

        public Usuario() {
            this.cadenadeconexion = @"Data Source=USER;Initial Catalog=CINE;Integrated Security=True;";
            this.sqlconn = new SqlConnection(this.cadenadeconexion);

        
        }
        
    }
}
