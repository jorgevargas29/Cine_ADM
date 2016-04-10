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

namespace Cine_Adm
{
    public partial class trabajador_agr : Form
    {

        string sql;
        string conexion = "Data Source=USER;Initial Catalog=CINE;Integrated Security=True;";
        DataTable dt;
        SqlConnection sqlconn;
        SqlDataAdapter sqlda;
        SqlCommand sqlcomm;

        string selec = "select " +
             "ID_TRABAJADOR" + " as 'Cod.Trabajador', " +
              "TB_NOMBRE" + " as Nombre, " +
               "TB_CEDULA" + " as Cedula, " +
              "TB_APELLIDO" + " as Apellido, " +
              "TB_APELLIDO_MATERNO" + " as 'Ap.Materno', " +
              "TB_EMAIL" + " as Correo, " +
              "TB_TELEFONO" + " as Telefono, " +
              "TB_EDAD" + " as Edad, " +
              "TB_USUARIO" + " as Usuario," +
               "TB_PASSWORD" + " as 'Contraseña'" +
              " from " + "TRABAJADOR";

        public trabajador_agr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            sqlcomm = new SqlCommand();

            DataTable dt = new DataTable();
            sql = "insert into empleado (" +
                "ID_TRABAJADOR," +
                "TB_NOMBRE," +
                "TB_CEDULA," +
                "TB_APELLIDO," +
                "TB_APELLIDO_MATERNO," +
                "TB_EMAIL," +
                "TB_TELEFONO," +
                "TB_EDAD," +
                 "TB_USUARIO," +
                "TB_PASSWORD" +
                ") values (" +
                "'" + textBox7.Text + "'," +
                "'" + textBox1.Text + "'," +
                "'" + textBox9.Text + "'," +
                "'" + textBox2.Text + "'," +
                 "'" + textBox3.Text + "'," +
                "'" + textBox10.Text + "'," +
                "'" + textBox11.Text + "'," +
                "'" + textBox4.Text + "'," +
                 "'" + textBox5.Text + "'," +
                "'" + textBox6.Text + "'" +
                 ")";
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            sqlconn.Close();
            sql = selec;
            sqlconn.Open();
            sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
        }

        private void trabajador_agr_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            sql = selec;
            sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
