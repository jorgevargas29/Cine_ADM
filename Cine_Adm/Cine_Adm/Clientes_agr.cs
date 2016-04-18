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
    public partial class Clientes_agr : Form
    {
        // el id se genera automaticamnete
        string sql;
        string conexion = "Data Source=USER;Initial Catalog=CINE;Integrated Security=True;";
        DataTable dt;
        SqlConnection sqlconn;
        SqlDataAdapter sqlda;
        SqlCommand sqlcomm;

        string selec = "select " +
             "ID_CLIENTE" + " as 'Cod.Cliente', " +
              "CL_NOMBRE" + " as Nombre, " +
               "CL_CEDULA" + " as Cedula, " +
              "CL_APELLIDO" + " as Apellido, " +
              "CL_APELLIDO_MATERNO" + " as 'Ap.Materno', " +
              "CL_EMAIL" + " as Correo, " +
              "CL_TELEFONO" + " as Telefono, " +
              "CL_EDAD" + " as Edad, " +
              "CL_USUARIO" + " as Usuario," +
               "CL_PASSWORD" + " as 'Contraseña'" +
              " from " + "CLIENTE";

       
        public Clientes_agr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            Cclientes cli = new Cclientes();
            sqlcomm = new SqlCommand();

            DataTable dt = new DataTable();
            sql = "insert into CLIENTE (" +
                "CL_NOMBRE," +
                "CL_CEDULA," +
                "CL_APELLIDO," +
                "CL_APELLIDO_MATERNO," +
                "CL_EMAIL," +
                "CL_TELEFONO," +
                "CL_EDAD," +
                 "CL_USUARIO," +
                "CL_PASSWORD" +
                ") values (" +
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
           cli.dataGridView1.DataSource = dt;
            limpiar();

        }
        public void limpiar()
        {
           
            textBox1.Text = "";
            textBox9.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
          

        }

        private void Clientes_agr_Load(object sender, EventArgs e)
        {
            textBox7.Enabled = false;
            dt = new DataTable();
            sql = selec;
            sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cclientes c = new Cclientes();
            c.Show();
            this.Hide();
        }
    }
}
