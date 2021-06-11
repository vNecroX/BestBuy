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

namespace BestBuy_Proyecto
{
    public partial class frmCarrito : Form
    {
        public static string Productor;
        Form Carrito;
        public frmCarrito()
        {
            InitializeComponent();
            frmLog Log = new frmLog();
            label1.Text = "Bienvenido,"+Log.textBox1.Text;
            label2.Text = "Cerrar sesion";
            Carrito = this;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Equipo")
            {
                MySqlParameters.startMySqlConnection();
                string Equipo = "SELECT * FROM producto WHERE id_categoria= '1'";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(Equipo, MySqlParameters.mySqlConnection);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MySqlParameters.startMySqlConnection();
                string Accesorio = "SELECT * FROM producto WHERE id_categoria= '2'";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(Accesorio, MySqlParameters.mySqlConnection);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Productor = dataGridView1.SelectedCells[0].Value.ToString();
            frmSelectProduct frmSelectProduct = new frmSelectProduct(Carrito, Productor);
            frmSelectProduct.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmLog Lo = new frmLog();
            Lo.Show();
            this.Hide();
        }
    }
       
    }

