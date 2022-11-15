using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaProduccion
{
    public partial class ver_reserva : Form
    {
        public ver_reserva()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5101";
            TextBox[] Grupotextbox = { num_orden, num_receta, prioridadtxt, prod_fabricar, textBox4, fechainic, fechacrea };
            TextBox[] Idtextbox = { num_orden, num_receta };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "colchoneria");
        }
    }
}
