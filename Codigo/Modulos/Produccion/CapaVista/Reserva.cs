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
        int idreservacion = 0;
        public Reserva()
        {
            InitializeComponent();
        }


        void Clear()
        {
            textBox2.Text = comboBox1.Text = comboBox2.Text = textBox4.Text = dateTimePicker3.Text = dateTimePicker1.Text = comboBox3.Text = "";
            idreservacion = 0;

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ordenes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("reserva_agregareditar", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_idreservacion", idreservacion);
                mySqlCmd.Parameters.AddWithValue("_idcliente", comboBox1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_idhabitacion", comboBox2.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_cantidadhabitacion", textBox4.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fechainicio", dateTimePicker3.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_fechafin", dateTimePicker1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_estatus", comboBox3.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Registro Guardado");

                Clear();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Habitaciones rep = new Habitaciones();
            rep.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clientes rep = new Clientes();
            rep.Show();
        }
    }
    }


