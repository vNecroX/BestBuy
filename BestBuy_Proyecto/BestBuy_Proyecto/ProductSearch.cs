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
    public partial class frmProductSearch : Form
    {
        public static string Productor;
        public Form productSearch;

        public frmProductSearch()
        {
            InitializeComponent();
            frmLogin Login = new frmLogin();
            label1.Text = "Bienvenido,"+Login.textBox1.Text;
            label2.Text = "Cerrar sesion";
            productSearch = this;
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
            frmShopCart frmSelectProduct = new frmShopCart(productSearch, Productor);
            frmSelectProduct.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmLogin Lo = new frmLogin();
            Lo.Show();
            this.Hide();
        }

        private void frmCarrito_Load(object sender, EventArgs e)
        {
            lblCounter.Text = frmShopCart.count.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //ClickImagenCarrito
            BuyShopCart carritodecompras = new BuyShopCart();
            carritodecompras.Show();
            this.Hide();

        }
    }
       
    }

