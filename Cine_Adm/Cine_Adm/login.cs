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
            entidad.Acceso = this.comboBox1.SelectedItem.ToString();
            #region acceso
            //validacion de acceso
            if (entidad.buscar() == true)
            {
                if (this.comboBox1.Text == "Administrador") {
                    MessageBox.Show(entidad.Mensaje, "CINEMA");
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.peliculasToolStripMenuItem1.Enabled = true;
                    menu.trabajadoresToolStripMenuItem.Enabled = true;
                    menu.ventaToolStripMenuItem.Enabled = true;
                    menu.carteleraToolStripMenuItem.Enabled = true;
                    menu.peliculasToolStripMenuItem.Enabled = true;
                    menu.Show();
                    this.Hide();
                }
                else if (this.comboBox1.Text == "Cliente")
                {
                   
                    MessageBox.Show(entidad.Mensaje, "CINEMA");
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.peliculasToolStripMenuItem1.Enabled = false;
                    menu.trabajadoresToolStripMenuItem.Enabled = false;
                    menu.ventaToolStripMenuItem.Enabled = true;
                    menu.carteleraToolStripMenuItem.Enabled = true;
                    menu.peliculasToolStripMenuItem.Enabled = true;
                    menu.Show();
                    this.Hide();

                }
                else if (this.comboBox1.Text == "Trabajador")
                {
                    //revisar
                    MessageBox.Show(entidad.Mensaje, "CINEMA");
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.peliculasToolStripMenuItem1.Enabled = false;
                    menu.trabajadoresToolStripMenuItem.Enabled = false;
                    menu.ventaToolStripMenuItem.Enabled = true;
                    menu.carteleraToolStripMenuItem.Enabled = true;
                    menu.peliculasToolStripMenuItem.Enabled = true;
                    menu.Show();
                    this.Hide();

                }
                

            }
            else
            {
                MessageBox.Show(entidad.Mensaje,"ERROR");
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
