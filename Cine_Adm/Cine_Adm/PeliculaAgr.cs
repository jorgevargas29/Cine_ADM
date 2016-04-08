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
    public partial class PeliculaAgr : Form
    {
        public PeliculaAgr()
        {
            InitializeComponent();
        }

        private void PeliculaAgr_Load(object sender, EventArgs e)
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

        private void bExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(@"Data Source=(local);Initial Catalog=CINE;Integrated Security=SSPI");
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();

                // Estableciento propiedades
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO PELICULA VALUES (@ID_PELICULA, @PL_TITULO, @PL_IDIOMA, @PL_CLASIFICACION, @PL_DURACION,@PL_IMAGEN,@PL_GENERO,@PL_SINOPSIS,@PL_DIRECTOR)";

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
                this.pictureBox1.Image = null;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
