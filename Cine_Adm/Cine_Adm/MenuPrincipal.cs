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
    public partial class MenuPrincipal : Form
    {
        

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           
        }
       

        private void peliculasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PeliculaAgr peli = new PeliculaAgr();
            peli.Show();
        }

        private void seleccionDeSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cine_controller csucursal = new cine_controller();
            csucursal.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trabajador_agr trabajador = new trabajador_agr();
            trabajador.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            venta_boletos boleto = new venta_boletos();
            boleto.Show();
        }

        private void peliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuario_compra peli = new usuario_compra();
            peli.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cclientes cliente = new Cclientes();
            cliente.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes_agr agr = new Clientes_agr();
            agr.Show();
        }
     
    }
}
