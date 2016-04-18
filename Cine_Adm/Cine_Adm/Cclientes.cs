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
    public partial class Cclientes : Form
    {
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


        public Cclientes()
        {
            InitializeComponent();

        }

        private void Cclientes_Load(object sender, EventArgs e)
        {
            textBox7.Enabled = false;
            dt = new DataTable();
            sql = selec;
            sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
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
        private void button5_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Enabled = true; ;
            sqlconn.Open();
            Clientes_agr clie = new Clientes_agr();
            sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            sql = selec +
                " where" + " ID_CLIENTE = " + textBox8.Text;
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            textBox7.Text = textBox8.Text;
            textBox7.Enabled = false;
            textBox1.Text = dt.Rows[0][1].ToString();
            textBox9.Text = dt.Rows[0][2].ToString();
            textBox2.Text = dt.Rows[0][3].ToString();
            textBox3.Text = dt.Rows[0][4].ToString();
            textBox10.Text = dt.Rows[0][5].ToString();
            textBox4.Text = dt.Rows[0][6].ToString();
            textBox11.Text = dt.Rows[0][7].ToString();
            textBox5.Text = dt.Rows[0][8].ToString();
            textBox6.Text = dt.Rows[0][9].ToString();

            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            sql = "delete from" +
            " CLIENTE " +
            " where " +
            "ID_CLIENTE = " + textBox8.Text;
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

        private void button3_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            Clientes_agr clie = new Clientes_agr();
            sql = "update" +
                " CLIENTE " +
                "set " +
            "CL_NOMBRE  = '" + clie.textBox1.Text + "', " +
            "CL_CEDULA = '" + clie.textBox9.Text + "', " +
            "CL_APELLIDO = '" + clie.textBox2.Text + "'," +
            "CL_APELLIDO_MATERNO = '" + clie.textBox3.Text + "'," +
            "CL_EMAIL = '" + clie.textBox10.Text + "'," +
            "CL_TELEFONO = '" + clie.textBox4.Text + "'," +
            "CL_EDAD = '" + clie.textBox11.Text + "'," +
            "CL_USUARIO = '" + clie.textBox5.Text + "'," +
            "CL_PASSWORD = '" + clie.textBox6.Text + "'" +

            " where" + " ID_CLIENTE  =  " + textBox8.Text;

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
            textBox8.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clientes_agr clie = new Clientes_agr();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ////registro externo
                //clie.textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                //clie.textBox9.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                //clie.textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                //clie.textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                //clie.textBox10.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                //clie.textBox11.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                //clie.textBox4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                //clie.textBox5.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                //clie.textBox6.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                //registro interno
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox9.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox10.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox11.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes_agr clie = new Clientes_agr();
            clie.Show();
            this.Hide();
        }
    }
}
