using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cine_Adm
{
    public partial class cine_controller : Form
    {
        public cine_controller()
        {
            InitializeComponent();
        }

        private void cine_controller_Load(object sender, EventArgs e)
        {
            CargarItemsCombobox c = new CargarItemsCombobox();
            c.llenaritem(comboBox1);
             linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://www.youtube.com/watch?v=k4iHpy1z1fg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido", " CINEMA MELLROSE ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);
        }
        }
    }

