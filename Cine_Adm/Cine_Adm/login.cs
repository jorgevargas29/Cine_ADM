using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cine_Adm
{
    public partial class login : Form
    {
        public int nivel;
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario2 entidad = new Usuario2();
            entidad.Usuarios = this.textBox1.Text;
            entidad.Contra = this.textBox2.Text;

            if (entidad.buscar() == true)
            {
                MessageBox.Show(entidad.Mensaje,"CINEMA");

            }
            else
            {
                MessageBox.Show(entidad.Mensaje,"ERROR");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
