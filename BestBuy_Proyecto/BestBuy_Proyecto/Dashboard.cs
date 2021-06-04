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
    public partial class frmDashboard : Form
    {
        public static Form dashboard;

        string selectHMworkersQuery = "SELECT MAX(ID_EMPLEADO) FROM EMPLEADO";
        string selectHMusersQuery = "SELECT MAX(ID_CLIENTE) FROM CLIENTE";
        string selectHMproductsQuery = "SELECT SUM(STOCK_PRODUCTO) FROM PRODUCTO";

        public frmDashboard()
        {
            InitializeComponent();
            dashboard = this;
        }

        .
            loadDashboard();
        }

        private void frmDashboard_VisibleChanged(object sender, EventArgs e)
        {
            loadDashboard();
        }

        private void lblAddWorker_Click(object sender, EventArgs e)
        {
            frmAddWorker addWorker = new frmAddWorker(dashboard);
            addWorker.Show();
            this.Hide();
        }

        private void picBoxProduct_Click(object sender, EventArgs e)
        {
            ProductDashboard productDashboard = new ProductDashboard();
            productDashboard.Show();
            this.Hide();
        }

        private void picBoxLog_Click(object sender, EventArgs e)
        {
            LogDashboard logDashboard = new LogDashboard();
            logDashboard.Show();
            this.Hide();
        }

        public void loadDashboard()
        {
            try
            {
                MySqlParameters.startMySqlConnection();

                MySqlParameters.mySqlCommand = new MySqlCommand(selectHMworkersQuery, MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    while (MySqlParameters.dataReader.Read())
                        lblHMworkers.Text = MySqlParameters.dataReader.GetString(0);
                }
                else
                {
                    MessageBox.Show("La consulta solicitada no contiene registros.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                MySqlParameters.dataReader.Close();

                MySqlParameters.mySqlCommand = new MySqlCommand(selectHMusersQuery, MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    while (MySqlParameters.dataReader.Read())
                        lblHMusers.Text = MySqlParameters.dataReader.GetString(0);
                }
                else
                {
                    MessageBox.Show("La consulta solicitada no contiene registros.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                MySqlParameters.dataReader.Close();

                MySqlParameters.mySqlCommand = new MySqlCommand(selectHMproductsQuery, MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    while (MySqlParameters.dataReader.Read())
                        lblHMproducts.Text = MySqlParameters.dataReader.GetString(0);
                }
                else
                {
                    MessageBox.Show("La consulta solicitada no contiene registros.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                MySqlParameters.dataReader.Close();

                MySqlParameters.mySqlConnection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Conexion fallida, intentelo de nuevo: " + ex.Message, "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
