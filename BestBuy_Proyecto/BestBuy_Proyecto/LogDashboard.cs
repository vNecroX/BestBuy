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
    public partial class LogDashboard : Form
    {
        private Form formHome;

        public LogDashboard()
        {
            InitializeComponent();
        }

        private void LogDashboard_Load(object sender, EventArgs e)
        {
            formHome = frmDashboard.ActiveForm;
            try
            {
                MySqlParameters.startMySqlConnection();

                MySqlParameters.mySqlCommand = new MySqlCommand("SELECT cliente.nombre_cliente AS 'Nombre Cliente', compra.fecha_compra AS 'Fecha Compra', sum(producto.precio_producto * detcompra.cantidad_producto) AS 'Total Compra' FROM compra INNER JOIN cliente INNER JOIN producto INNER JOIN detcompra WHERE cliente.id_cliente = compra.id_cliente AND compra.id_compra = detcompra.id_compra AND producto.id_producto = detcompra.id_producto GROUP BY compra.id_compra ORDER BY compra.fecha_compra ASC", MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlDataAdapter sda = new MySqlDataAdapter(MySqlParameters.mySqlCommand);
                DataTable table = new DataTable();
                sda.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dgvLog.DataSource = bSource;

                MySqlParameters.dataReader.Close();

                MySqlParameters.mySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Conexion fallida, intentelo de nuevo: " + ex.Message, "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formHome.Show();
        }

        private void LogDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            formHome.Show();
        }
    }
}
