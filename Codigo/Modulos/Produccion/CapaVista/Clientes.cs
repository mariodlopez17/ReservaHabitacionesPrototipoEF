using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaVistaProduccion
{
    public partial class Clientes : Form
    {
        string connectionString = @"Server=localhost;Database=colchoneria;Uid=root;Pwd=root";
        int clientes = 0;
        public Clientes()
        {
            InitializeComponent();
        }

        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("clientes_viewall", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblhab = new DataTable();
                sqlDa.Fill(dtblhab);
                dataGridView1.DataSource = dtblhab;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GridFill();
        }
    }
}
