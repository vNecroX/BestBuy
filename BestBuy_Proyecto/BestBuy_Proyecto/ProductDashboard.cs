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
                //select detcompra.id_producto, sum(detcompra.cantidad_producto) as total from detcompra inner join compra where compra.fecha_compra>=(DATE_SUB(now(),INTERVAL 30 DAY)) AND compra.id_compra = detcompra.id_compra group by detcompra.id_producto order by total desc;
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
            consultedData resultFind = inputDataList.Find(
                 delegate (consultedData current)
                 {
                     if (current.id.Equals(cmbSearch.SelectedItem.ToString()))
                     {
                         return current.id.ToString().Equals(cmbSearch.SelectedItem.ToString());
                     }
                     else if(cmbSearch.SelectedItem.ToString().Length == 1)
                     {
                         return current.id.ToString().Equals(cmbSearch.SelectedItem.ToString());
                     }
                     else
                     {
                         return current.result.Contains(cmbSearch.SelectedItem.ToString());
                     }
                 }
            ) ;
            MessageBox.Show(resultFind.id.ToString() + " - " + resultFind.result);
        }

        private void ProductDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            formHome.Show();
        }
    }
}
