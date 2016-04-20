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
        Boolean clicked = false;
        public usuario_compra()
        {
            InitializeComponent();
            guardarImagen_ListView();
        }

        private void cargarImage() {
            // FileStream pic = new FileStream(@"../../Source/Posters/dsfsd.jpg");
            //pBox1.Image = Image.FromFile(@"../../Source/Posters/dsfsd.jpg");
            //pBox1.Load("'/Posters/dsfsd.jpg");
        }
        private void usuario_compra_Load(object sender, EventArgs e)
        {
            string sql;
            string conexion = "Data Source=JORGE-PC\\SQLEXPRESS;Initial Catalog=CINE;Integrated Security=True;";
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

            comboBox1.DataSource = cargarCbxPelicula();
            comboBox1.DisplayMember = "PELICULA";
            comboBox1.ValueMember = "PL_TITULO";
        }

        public void guardarImagen_ListView() {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Jorge\Documents\Cine_ADM\Cine_Adm\Source\Posters");
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    this.imageList1.Images.Add(Image.FromFile(file.FullName));
                }
                catch
                {
                    Console.WriteLine("No es un archivo de imagen");
                }
            }
            this.listView1.View = View.LargeIcon;
            this.imageList1.ImageSize = new Size(32, 32);
            this.listView1.LargeImageList = this.imageList1;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (button89.Enabled == true && clicked == false)
            {
                button89.Image = Properties.Resources.seat1;
                clicked = true; 
            }
            else if (clicked == true)
            {
                button89.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (button88.Enabled == true && clicked == false)
            {
                button88.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button88.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            if (button87.Enabled == true && clicked == false)
            {
                button87.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button87.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (button63.Enabled == true && clicked == false)
            {
                button63.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button63.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            if (button86.Enabled == true && clicked == false)
            {
                button86.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button86.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            if (button85.Enabled == true && clicked == false)
            {
                button85.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button85.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            if (button84.Enabled == true && clicked == false)
            {
                button84.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button84.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            if (button83.Enabled == true && clicked == false)
            {
                button83.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button83.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            if (button82.Enabled == true && clicked == false)
            {
                button82.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button82.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            if (button81.Enabled == true && clicked == false)
            {
                button81.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button81.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            if (button80.Enabled == true && clicked == false)
            {
                button80.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button80.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            if (button79.Enabled == true && clicked == false)
            {
                button79.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button79.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (button78.Enabled == true && clicked == false)
            {
                button78.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button78.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (button77.Enabled == true && clicked == false)
            {
                button77.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button77.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private DataTable cargarCbxPelicula()
        {
            string sql;
            string conexion = "Data Source=JORGE-PC\\SQLEXPRESS;Initial Catalog=CINE;Integrated Security=True;";
            DataTable dt = new DataTable();
            sql = "select " +
                 "PL_TITULO" +
                 " from " + "PELICULA";
            SqlConnection sqlconn = new SqlConnection(conexion);
            sqlconn.Open();//abre conexion

            SqlDataAdapter sqlda = new SqlDataAdapter(sql, sqlconn);
            sqlda.Fill(dt);
            sqlconn.Close();
            return dt;
        }
    }
}
