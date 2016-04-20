using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cine_Adm
{
    public partial class venta_boletos : Form
    {
        Boolean clicked = false;
        public venta_boletos()
        {
            InitializeComponent();
        }
        private DataTable cargarCbxPelicula()
        {
            string sql;
            string conexion = "Data Source=USER;Initial Catalog=CINE;Integrated Security=True;";
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
       
        private void venta_boletos_Load(object sender, EventArgs e)
        {
            CargarItemsCombobox c = new CargarItemsCombobox();
            c.llenaritemP(comboBox1);

        }
      

        #region Asientos
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

        private void button104_Click(object sender, EventArgs e)
        {
            if (button104.Enabled == true && clicked == false)
            {
                button104.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button104.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button103_Click(object sender, EventArgs e)
        {
            if (button103.Enabled == true && clicked == false)
            {
                button103.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button103.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button102_Click(object sender, EventArgs e)
        {
            if (button102.Enabled == true && clicked == false)
            {
                button102.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button102.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            if (button90.Enabled == true && clicked == false)
            {
                button90.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button90.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button101_Click(object sender, EventArgs e)
        {
            if (button101.Enabled == true && clicked == false)
            {
                button101.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button101.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            if (button100.Enabled == true && clicked == false)
            {
                button100.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button100.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button99_Click(object sender, EventArgs e)
        {
            if (button99.Enabled == true && clicked == false)
            {
                button99.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button99.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button98_Click(object sender, EventArgs e)
        {
            if (button98.Enabled == true && clicked == false)
            {
                button98.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button98.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button97_Click(object sender, EventArgs e)
        {
            if (button97.Enabled == true && clicked == false)
            {
                button97.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button97.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (button96.Enabled == true && clicked == false)
            {
                button96.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button96.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            if (button95.Enabled == true && clicked == false)
            {
                button95.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button95.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            if (button94.Enabled == true && clicked == false)
            {
                button94.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button94.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            if (button93.Enabled == true && clicked == false)
            {
                button93.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button93.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (button92.Enabled == true && clicked == false)
            {
                button92.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button92.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            if (button91.Enabled == true && clicked == false)
            {
                button91.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button91.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Enabled == true && clicked == false)
            {
                button2.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button2.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Enabled == true && clicked == false)
            {
                button3.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button3.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Enabled == true && clicked == false)
            {
                button4.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button4.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled == true && clicked == false)
            {
                button5.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button5.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Enabled == true && clicked == false)
            {
                button6.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button6.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Enabled == true && clicked == false)
            {
                button7.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button7.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Enabled == true && clicked == false)
            {
                button8.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button8.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Enabled == true && clicked == false)
            {
                button9.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button9.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Enabled == true && clicked == false)
            {
                button10.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button10.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Enabled == true && clicked == false)
            {
                button11.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button11.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Enabled == true && clicked == false)
            {
                button12.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button12.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == true && clicked == false)
            {
                button1.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button1.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Enabled == true && clicked == false)
            {
                button13.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button13.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Enabled == true && clicked == false)
            {
                button14.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button14.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Enabled == true && clicked == false)
            {
                button15.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button15.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.Enabled == true && clicked == false)
            {
                button30.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button30.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.Enabled == true && clicked == false)
            {
                button29.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button29.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.Enabled == true && clicked == false)
            {
                button28.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button28.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Enabled == true && clicked == false)
            {
                button16.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button16.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.Enabled == true && clicked == false)
            {
                button27.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button27.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.Enabled == true && clicked == false)
            {
                button26.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button26.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.Enabled == true && clicked == false)
            {
                button25.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button25.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.Enabled == true && clicked == false)
            {
                button24.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button24.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (button23.Enabled == true && clicked == false)
            {
                button23.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button23.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (button22.Enabled == true && clicked == false)
            {
                button22.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button22.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.Enabled == true && clicked == false)
            {
                button21.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button21.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.Enabled == true && clicked == false)
            {
                button20.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button20.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.Enabled == true && clicked == false)
            {
                button19.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button19.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.Enabled == true && clicked == false)
            {
                button18.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button18.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.Enabled == true && clicked == false)
            {
                button17.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button17.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (button46.Enabled == true && clicked == false)
            {
                button46.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button46.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button32.Enabled == true && clicked == false)
            {
                button32.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button32.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.Enabled == true && clicked == false)
            {
                button33.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button33.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button34.Enabled == true && clicked == false)
            {
                button34.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button34.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button35.Enabled == true && clicked == false)
            {
                button35.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button35.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button36.Enabled == true && clicked == false)
            {
                button36.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button36.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (button37.Enabled == true && clicked == false)
            {
                button37.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button37.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button38.Enabled == true && clicked == false)
            {
                button38.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button38.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (button39.Enabled == true && clicked == false)
            {
                button39.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button39.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button40.Enabled == true && clicked == false)
            {
                button40.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button40.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (button41.Enabled == true && clicked == false)
            {
                button41.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button41.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (button42.Enabled == true && clicked == false)
            {
                button42.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button42.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.Enabled == true && clicked == false)
            {
                button31.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button31.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (button43.Enabled == true && clicked == false)
            {
                button43.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button43.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (button44.Enabled == true && clicked == false)
            {
                button44.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button44.Image = Properties.Resources.seat;
                clicked = false;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (button45.Enabled == true && clicked == false)
            {
                button45.Image = Properties.Resources.seat1;
                clicked = true;
            }
            else if (clicked == true)
            {
                button45.Image = Properties.Resources.seat;
                clicked = false;
            }
        }
        #endregion
    }
}
