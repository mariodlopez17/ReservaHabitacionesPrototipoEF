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
    public partial class Reserva : Form
    {
        string connectionString = @"Server=localhost;Database=colchoneria;Uid=root;Pwd=root;";
        int pk_idordenes_tbl_ordenes = 0;
        public Reserva()
        {
            InitializeComponent();
        }


        void Clear()
        {
           /* textBox2.Text = textBox3.Text = textBox4.Text = dateTimePicker3.Text = textBox1.Text = dateTimePicker1.Text = dateTimePicker2.Text = comboBox1.Text = "";*/
            pk_idordenes_tbl_ordenes = 0;

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ordenes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           /* using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("pa_produccion_ordenes_agregareditar", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_pk_idordenes_tbl_ordenes", pk_idordenes_tbl_ordenes);
                mySqlCmd.Parameters.AddWithValue("_fk_idrecetas_tbl_recetas", textBox2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_prioridad_tbl_ordenes", comboBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_producto_fabricar_tbl_ordenes", textBox3.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_cantidad_tbl_ordenes", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fechaini_tbl_ordenes", dateTimePicker1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fechaentrega_tbl_ordenes", dateTimePicker2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fechacreacion_orden_tbl_ordenes", dateTimePicker3.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_detalle_tbl_ordenes", textBox1.Text.Trim());
                mySqlCmd.ExecuteNonQuery();

                MessageBox.Show("Registro ingresado!");

                Clear();*/

            }
        }


  
    }

