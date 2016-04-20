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
    public partial class PeliculaAgr : Form
    {
        
        string sql;
            string conexion = "Data Source=JORGE-PC\\SQLEXPRESS;Initial Catalog=CINE;Integrated Security=True;";
            DataTable dt;
         SqlConnection sqlconn;
         SqlDataAdapter sqlda;
         SqlCommand sqlcomm;

           string selec = "select " +
                "ID_PELICULA" + " as 'Cod.Pelicula' , " +
                 "PL_TITULO" + " as Titulo, " +
                 "PL_IDIOMA" + " as Idioma, " +
                 "PL_CLASIFICACION" + " as Clasificacion, " +
                 "PL_DURACION" + " as Duracion, " +
                 "PL_GENERO" + " as Genero, " +
                 "PL_SINOPSIS" + " as Sinopsis, " +
                 "PL_DIRECTOR" + " as Director," +
                  "PL_IMAGEN" + " as Posters" +
                 " from " + "PELICULA";



          
        public PeliculaAgr()
        {
            InitializeComponent();
        }

        private void PeliculaAgr_Load(object sender, EventArgs e)
        {
            
             dt = new DataTable();
            sql=selec; 
             sqlconn = new SqlConnection(conexion);
            sqlconn.Open();
            sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[8].Visible = false;
        }
       public void VerImagen(PictureBox imagen, ComboBox comb)
        {
            SqlCommand com = new SqlCommand("select " + "PL_IMAGEN" +
               " from " + "PELICULA" + " where " + "ID_PELICULA = '" + comb.SelectedValue.ToString() + "' ", sqlconn);
            SqlDataAdapter sqda = new SqlDataAdapter(com);
            DataSet set = new DataSet("PELICULA");
            sqda.Fill(set, "PELICULA");
            byte[] dato = new byte[0];
            DataRow dr = set.Tables["PL_IMAGEN"].Rows[0];

            dato = (byte[])dr["PL_IMAGEN"];

            System.IO.MemoryStream ms = new System.IO.MemoryStream(dato);
            imagen.Image = System.Drawing.Bitmap.FromStream(ms);

        }
        private void bExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }
        public void GuardarImagen()
        {
            //SaveFileDialog Guardar = new SaveFileDialog();
            //Guardar.Filter = "JPEG(*.jpg)|*.jpg|BMP(*.bmp)|*.BMP";
            //Image Imagen = pictureBox1.Image;
            //Guardar.ShowDialog();
            //Imagen.Save(Guardar.FileName);
            {
                // Be sure that you use an appropriate escape sequence (such as the 
                // @) when specifying the location of the file.
                System.Drawing.Image myImage = Image.FromFile
                (System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.Personal)
                + @"../../Source/Posters/");
                //imageList1.Images.Add(myImage);
            }
        }
        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(conexion);
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO PELICULA VALUES (@ID_PELICULA, @PL_TITULO, @PL_IDIOMA, @PL_CLASIFICACION, @PL_DURACION,@PL_GENERO,@PL_SINOPSIS,@PL_DIRECTOR,@PL_IMAGEN)";

                // Creando los parámetros necesarios
                cmd.Parameters.Add("@ID_PELICULA", System.Data.SqlDbType.Int);
                cmd.Parameters.Add("@PL_TITULO", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@PL_IDIOMA", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@PL_CLASIFICACION", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@PL_DURACION", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@PL_IMAGEN", System.Data.SqlDbType.Image);
                cmd.Parameters.Add("@PL_GENERO", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@PL_SINOPSIS", System.Data.SqlDbType.NVarChar);
                cmd.Parameters.Add("@PL_DIRECTOR", System.Data.SqlDbType.NVarChar);



                // Asignando los valores a los atributos
                cmd.Parameters["@ID_PELICULA"].Value = Convert.ToInt32(textBox1.Text);
                cmd.Parameters["@PL_TITULO"].Value = textBox2.Text;
                cmd.Parameters["@PL_IDIOMA"].Value = textBox3.Text;
                cmd.Parameters["@PL_CLASIFICACION"].Value = textBox8.Text;
                cmd.Parameters["@PL_DURACION"].Value = textBox6.Text;
                cmd.Parameters["@PL_GENERO"].Value = textBox4.Text;
                cmd.Parameters["@PL_SINOPSIS"].Value = textBox7.Text;
                cmd.Parameters["@PL_DIRECTOR"].Value = textBox5.Text;


                // Asignando el valor de la imagen

                // Stream usado como buffer
                 System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // Se guarda la imagen en el buffer
                pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                // Se extraen los bytes del buffer para asignarlos como valor para el
                // parámetro.
                cmd.Parameters["@PL_IMAGEN"].Value = ms.GetBuffer();
               GuardarImagen();

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro Guardado Correctamente");
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";
              
               
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            sql = "update" + 
                "PELICULA"+
                "set"+
                "PL_TITULO  = '" + textBox2.Text + "', " +
            "PL_IDIOMA = '" + textBox3.Text + "', " +
            "PL_CLASIFICACION = '" + textBox8.Text + "'," +
            "PL_DURACION = '" + textBox6.Text + "'," +
            "PL_GENERO = '" + textBox4.Text + "'," +
            "PL_SINOPSIS = '" + textBox7.Text + "'," +
            "PL_DIRECTOR = '" + textBox5.Text + "'," +
            "PL_IMAGEN = '" + pictureBox1 + "'" +

            " where" +" ID_PELICULA = " + textBox1.Text;
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

        private void button5_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            sql = selec +
                " where" + " ID_PELICULA = " + textBox1.Text;
            sqlcomm.Connection = sqlconn;
            sqlcomm.CommandText = sql;
            sqlcomm.CommandType = CommandType.Text;
            sqlcomm.ExecuteNonQuery();
            sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            textBox2.Text = dt.Rows[0][1].ToString();
            textBox3.Text = dt.Rows[0][2].ToString();
            textBox6.Text = dt.Rows[0][3].ToString();
            textBox5.Text = dt.Rows[0][4].ToString();
            textBox4.Text = dt.Rows[0][5].ToString();
            textBox8.Text = dt.Rows[0][6].ToString();
            textBox7.Text = dt.Rows[0][7].ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            sqlcomm = new SqlCommand();
            string sql;
            DataTable dt = new DataTable();
            sql = "delete from" +
            " PELICULA " +
            " where " +
            "ID_PELICULA = " + textBox1.Text;
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

    }
}
