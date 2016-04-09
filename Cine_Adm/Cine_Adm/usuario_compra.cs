using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Cine_Adm
{
    public partial class usuario_compra : Form
    {
        public usuario_compra()
        {
            InitializeComponent();
            //cargarImage();
        }

        //Image convertbinaryToimage(byte[] data)
        //{
        //    string sql;
        //    string conexion = "Data Source=USER;Initial Catalog=CINE;Integrated Security=True;";
        //    using (MemoryStream ms = new MemoryStream(data))
        //    {
        //        return Image.FromStream(ms);

        //    }
        //}

        //private void cargarImage()
        //{
        //    string sql;
        //    string conexion = "Data Source=USER;Initial Catalog=CINE;Integrated Security=True;";
           
        //    SqlCommand sqlcomm;
        //    SqlConnection sqlconn=new SqlConnection(conexion);
        //    sql = "select " + " PL_IMAGEN " +
        //         " from " + "PELICULA";
        //    sqlcomm = new SqlCommand(sql,sqlconn);
            
        //    SqlDataAdapter sqlda = new SqlDataAdapter(sqlcomm);
        //    DataTable dt = new DataTable();
           
        //    sqlda.Fill(dt);



        //    byte[] img = (byte[])dt.Rows[0][4];
        //    using (MemoryStream ms = new MemoryStream(img))
        //    {
        //        Image.FromStream(ms);
        //        pBox1.Image = Image.FromStream(ms);

        //    }
        //    //MemoryStream ms = new MemoryStream(Convert.ToString(img));
           
        //    ////pBox2.Image = Image.FromStream(ms);
        //    ////pBox3.Image = Image.FromStream(ms);

        //}
        private void usuario_compra_Load(object sender, EventArgs e)
        {
            string sql;
            string conexion = "Data Source=USER;Initial Catalog=CINE;Integrated Security=True;";
            DataTable dt = new DataTable();
            sql = "select " +
                "ID_PELICULA" + " as 'Cod.Pelicula' , " +
                 "PL_TITULO" + " as Titulo, " +
                 "PL_IDIOMA" + " as Idioma, " +
                 "PL_CLASIFICACION" + " as Clasificacion, " +
                 "PL_DURACION" + " as Duracion, " +
                 "PL_GENERO" + " as Genero, " +
                 "PL_SINOPSIS" + " as Sinopsis, " +
                 "PL_DIRECTOR" + " as Director, " +
                 "PL_IMAGEN" + " as Posters" +
                 " from " + "PELICULA";
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();//abre conexion

            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
        }

        private void pBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
