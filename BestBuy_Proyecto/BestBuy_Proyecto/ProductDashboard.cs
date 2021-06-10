using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace BestBuy_Proyecto
{
    public partial class ProductDashboard : Form
    {
        private Form formHome;

        private struct consultedData
        {
            public int id;
            public string nombre;
        }

        private struct consultedData2
        {
            public int id, cantidad;
            public string nombre;
        }

        private List<consultedData> inputDataList = new List<consultedData>();
        private consultedData inputData = new consultedData();
        private consultedData2 inputData2 = new consultedData2();

        public ProductDashboard()
        {
            InitializeComponent();
        }

        private void ProductDashboard_Load(object sender, EventArgs e)
        {
            chartTop3.Series[0].ChartType = SeriesChartType.Pie;
            chartTop3.Palette = ChartColorPalette.Pastel;
            chartEarning.Palette = ChartColorPalette.Pastel;
            chartStock.Palette = ChartColorPalette.Pastel;
            chartTop3.Titles.Add("Top 3");
            chartStock.Titles.Add("Stock");
            chartEarning.Titles.Add("Ganancias ultima semana");
            chartStock.Visible = false;
            chartEarning.Visible = false;
            formHome = frmDashboard.ActiveForm;
            try
            {
                MySqlParameters.startMySqlConnection();

                MySqlParameters.mySqlCommand = new MySqlCommand("SELECT id_producto, nombre_producto FROM producto", MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    while (MySqlParameters.dataReader.Read())
                    {
                        inputData.id = MySqlParameters.dataReader.GetInt32("id_producto");
                        inputData.nombre = MySqlParameters.dataReader.GetString("nombre_producto");
                        cmbSearch.Items.Add(inputData.id);
                        cmbSearch.Items.Add(inputData.nombre);
                        inputDataList.Add(inputData);
                    }
                }
                else
                {
                    MessageBox.Show("La consulta solicitada no contiene registros.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                MySqlParameters.dataReader.Close();

                MySqlParameters.mySqlCommand = new MySqlCommand("select detcompra.id_producto, Producto.nombre_producto, sum(detcompra.cantidad_producto) as total from detcompra inner join compra inner join producto where producto.id_producto = detcompra.id_producto AND compra.fecha_compra>=(DATE_SUB(now(),INTERVAL 30 DAY)) AND compra.id_compra = detcompra.id_compra group by detcompra.id_producto order by total desc LIMIT 3", MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;
                
                MySqlDataAdapter sda = new MySqlDataAdapter(MySqlParameters.mySqlCommand);
                DataSet st = new DataSet();
                sda.Fill(st, "top3");

                chartTop3.DataSource = st.Tables["top3"];
                chartTop3.Series[0].XValueMember = "nombre_producto";
                chartTop3.Series[0].YValueMembers = "total";
                this.chartTop3.Titles.Add("Top 3 Productos Vendidos");
                chartTop3.Series[0].ChartType = SeriesChartType.Pie;
                chartTop3.Series[0].IsValueShownAsLabel = true;
                chartTop3.Series[0].ToolTip = "#VALX";

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
            if (cmbSearch.SelectedItem != null)
            {
                consultedData resultFind = inputDataList.Find(
                    delegate (consultedData current)
                    {
                        if (current.id.Equals(cmbSearch.SelectedItem.ToString()))
                        {
                            return current.id.ToString().Equals(cmbSearch.SelectedItem.ToString());
                        }
                        else if (cmbSearch.SelectedItem.ToString().Length == 1)
                        {
                            return current.id.ToString().Equals(cmbSearch.SelectedItem.ToString());
                        }
                        else
                        {
                            return current.nombre.Contains(cmbSearch.SelectedItem.ToString());
                        }
                    }
                );

                try
                {
                    MySqlParameters.startMySqlConnection();

                    MySqlParameters.mySqlCommand = new MySqlCommand("select nombre_producto, stock_producto from producto where id_producto = " + resultFind.id.ToString(), MySqlParameters.mySqlConnection);
                    MySqlParameters.mySqlCommand.CommandTimeout = 60;

                    MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                    chartStock.Visible = true;
                    chartStock.Series.Clear();

                    if (MySqlParameters.dataReader.HasRows)
                    {
                        MySqlParameters.dataReader.Read();
                        Series serie = chartStock.Series.Add(MySqlParameters.dataReader.GetString("nombre_producto"));
                        serie.ChartType = SeriesChartType.Column;
                        serie.Points.Add(MySqlParameters.dataReader.GetInt32("stock_producto"));
                        serie.Label = MySqlParameters.dataReader.GetInt32("stock_producto").ToString();
                    }
                    else
                    {
                        MessageBox.Show("La consulta solicitada no contiene registros.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //picProduct.ImageLocation = "https://www.sublimesolutions.com/imgs/articulos/_original_10144.jpg";
                    string temp = Application.StartupPath.Remove(Application.StartupPath.Length - 9);
                    picProduct.ImageLocation = temp + "imagenes/" + resultFind.nombre + ".jpg";

                    MySqlParameters.dataReader.Close();

                    MySqlParameters.mySqlCommand = new MySqlCommand("SELECT SUM(producto.precio_producto * detcompra.cantidad_producto) AS 'Total de Ventas', DATE_FORMAT(compra.fecha_compra, '%Y-%m-%d') AS 'Fecha de Compra' FROM compra INNER JOIN producto INNER JOIN detcompra WHERE producto.id_producto = detcompra.id_producto AND compra.id_compra = detcompra.id_compra AND compra.fecha_compra > (now()-INTERVAL 1 WEEK) AND detcompra.id_producto = " + resultFind.id.ToString() + " GROUP BY DAY(compra.fecha_compra) ORDER BY compra.fecha_compra", MySqlParameters.mySqlConnection);
                    MySqlParameters.mySqlCommand.CommandTimeout = 60;

                    MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                    chartEarning.Visible = true;
                    chartEarning.Series.Clear();

                    Series serie2 = chartEarning.Series.Add(resultFind.nombre);
                    List<string> fechas = new List<string>();
                    List<double> precios = new List<double>();
                    if (MySqlParameters.dataReader.HasRows)
                    {
                        while (MySqlParameters.dataReader.Read())
                        {
                            fechas.Add(MySqlParameters.dataReader.GetString("Fecha de Compra"));
                            precios.Add(MySqlParameters.dataReader.GetDouble("Total de Ventas"));
                        }
                    }
                    else
                    {
                        fechas.Add(DateTime.Today.ToString("yyyy-MM-dd"));
                        precios.Add(0);
                    }

                    serie2.ChartType = SeriesChartType.Line;
                    serie2.MarkerStyle = MarkerStyle.Circle;
                    serie2.Points.DataBindXY(fechas, precios);
                    for (int i = 0; i < serie2.Points.Count; i++)
                    {
                        serie2.Points[i].Label = ((float)serie2.Points[i].YValues.ElementAt(0)).ToString();
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

        private void ProductDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            formHome.Show();
        }
    }
}
