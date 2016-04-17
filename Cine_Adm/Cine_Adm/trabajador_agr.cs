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
               "TB_PASSWORD" + " as 'Contraseña'," +
               "TB_ACCESO" + " as 'Acceso'" +
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
            sql = "insert into TRABAJADOR (" +
                "ID_TRABAJADOR," +
                "TB_NOMBRE," +
                "TB_CEDULA," +
                "TB_APELLIDO," +
                "TB_APELLIDO_MATERNO," +
                "TB_EMAIL," +
                "TB_TELEFONO," +
                "TB_EDAD," +
                 "TB_USUARIO," +
                "TB_PASSWORD," +
                "TB_ACCESO" +
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
                "'" + textBox6.Text + "'," +
                "'" + textBox12.Text + "'" +
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
            limpiar();
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

        private void button2_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            sql = selec +
                " where" + " ID_TRABAJADOR = " + textBox8.Text;
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
            textBox12.Text = dt.Rows[0][10].ToString();
            dataGridView1.DataSource = dt;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                textBox9.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                textBox10.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                textBox11.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                textBox4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                textBox5.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                textBox6.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                textBox12.Text = dataGridView1.CurrentRow.Cells["Acceso"].Value.ToString();


            }

            // ver cual sirve
            //DataGridViewRow dgv = dataGridView1.Rows[e.RowIndex];
            //textBox7.Text = dgv.Cells[0].Value.ToString();
            //textBox1.Text = dgv.Cells[1].Value.ToString();
            //textBox9.Text = dgv.Cells[2].Value.ToString();
            //textBox2.Text = dgv.Cells[3].Value.ToString();
            //textBox3.Text = dgv.Cells[4].Value.ToString();
            //textBox10.Text = dgv.Cells[5].Value.ToString();
            //textBox11.Text = dgv.Cells[7].Value.ToString();
            //textBox4.Text = dgv.Cells[6].Value.ToString();
            //textBox5.Text = dgv.Cells[8].Value.ToString();
            //textBox6.Text = dgv.Cells[9].Value.ToString();
            //textBox12.Text = dgv.Cells[10].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            sqlconn.Open();
            sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            textBox7.Text = textBox8.Text;
            sql = "update" +
                " TRABAJADOR " +
                "set " +
            "TB_NOMBRE  = '" + textBox1.Text + "', " +
            "TB_CEDULA = '" + textBox9.Text + "', " +
            "TB_APELLIDO = '" + textBox2.Text + "'," +
            "TB_APELLIDO_MATERNO = '" + textBox3.Text + "'," +
            "TB_EMAIL = '" + textBox10.Text + "'," +
            "TB_TELEFONO = '" + textBox4.Text + "'," +
            "TB_EDAD = '" + textBox11.Text + "'," +
            "TB_USUARIO = '" + textBox5.Text + "'," +
            "TB_PASSWORD = '" + textBox6.Text + "'," +
            "TB_ACCESO = '" + textBox12.Text + "'" +
            " where" + " ID_TRABAJADOR  =  " + textBox7.Text;
           
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
            limpiar();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            sql = "delete from" +
            " TRABAJADOR " +
            " where " +
            "ID_TRABAJADOR = " + textBox8.Text;
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

        public void limpiar()
        {
            textBox7.Text = "";
            textBox1.Text = "";
            textBox9.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox12.Text = "";
            textBox8.Text = "";

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
          
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox12.Text = Convert.ToString(comboBox1.SelectedItem);
            textBox12.Enabled = false;
        }
    }
}
