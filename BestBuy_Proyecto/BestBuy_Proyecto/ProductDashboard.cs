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
    public partial class ProductDashboard : Form
    {
        private Form formHome;

        private struct consultedData
        {
            public int id;
            public string result;
            public bool productFlag;
        }

        private List<consultedData> inputDataList = new List<consultedData>();
        private consultedData inputData = new consultedData();

        public ProductDashboard()
        {
            InitializeComponent();
        }

        private void ProductDashboard_Load(object sender, EventArgs e)
        {
            formHome = frmDashboard.ActiveForm;
            try
            {
                int i = 0;
                MySqlParameters.startMySqlConnection();

                MySqlParameters.mySqlCommand = new MySqlCommand("SELECT id_producto, nombre_producto FROM producto", MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    while (MySqlParameters.dataReader.Read())
                    {
                        inputData.id = MySqlParameters.dataReader.GetInt32("id_producto");
                        inputData.result = MySqlParameters.dataReader.GetString("nombre_producto");
                        inputData.productFlag = true;
                        cmbSearch.Items.Add(inputData.id);
                        cmbSearch.Items.Add(inputData.result);
                        inputDataList.Add(inputData);
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("La consulta solicitada no contiene registros.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                MySqlParameters.dataReader.Close();

                MySqlParameters.mySqlCommand = new MySqlCommand("SELECT id_categoria, nombre_categoria FROM categoria", MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    while (MySqlParameters.dataReader.Read())
                    {
                        inputData.id = MySqlParameters.dataReader.GetInt32("id_categoria");
                        inputData.result = MySqlParameters.dataReader.GetString("nombre_categoria");
                        inputData.productFlag = false;
                        cmbSearch.Items.Add(inputData.result);
                        inputDataList.Add(inputData);
                        i++;
                    }
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            formHome.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("searching...");
        }

        private void ProductDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            formHome.Show();
        }
    }
}
