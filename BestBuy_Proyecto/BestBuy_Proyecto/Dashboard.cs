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
using System.IO.Ports;

namespace BestBuy_Proyecto
{
    public partial class frmDashboard : Form
    {
        public static Form dashboard;

        string selectHMworkersQuery = "SELECT MAX(ID_EMPLEADO) FROM EMPLEADO";
        string selectHMusersQuery = "SELECT MAX(ID_CLIENTE) FROM CLIENTE";
        string selectHMproductsQuery = "SELECT SUM(STOCK_PRODUCTO) FROM PRODUCTO";

        string selectProductsWithNoStockQuery = "SELECT ID_PRODUCTO FROM PRODUCTO WHERE STOCK_PRODUCTO = 0";
        string productsWithNoStock;

        string idSingleProduct;
        string selectStockSingleProductQuery = "SELECT STOCK_PRODUCTO FROM PRODUCTO WHERE ID_PRODUCTO = ";
        string stockSingleProduct;
        string updateStockSingleProductQuery = "UPDATE PRODUCTO SET STOCK_PRODUCTO = 10 WHERE ID_PRODUCTO = ";

        public delegate void readDataDelegate(String arduinoRequest);
        public readDataDelegate myDelegate;

        public frmDashboard()
        {
            InitializeComponent();
            arduinoSerial();
            this.myDelegate = new readDataDelegate(readData);
            dashboard = this;
        }

        public void arduinoSerial()
        {
            arduinoSerialPort.PortName = "COM3";
            arduinoSerialPort.BaudRate = 9600;
            arduinoSerialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPortListener);
            arduinoSerialPort.Open();
        }

        private void SerialPortListener(object sender, SerialDataReceivedEventArgs e)
        {
            arduinoSerialPort = (SerialPort)sender;
            string inData = arduinoSerialPort.ReadExisting();

            dashboard.Invoke(this.myDelegate, new Object[] { inData });
        }

        public void readData(String arduinoRequest)
        {
            try
            {
                MySqlParameters.startMySqlConnection();
                //MessageBox.Show(arduinoRequest);
                int temp;
                if (arduinoRequest == "A")              //storer requests for all products with no stock, through their ID's. . .
                {
                    productsWithNoStock = " ";
                    MySqlParameters.mySqlCommand = new MySqlCommand(selectProductsWithNoStockQuery, MySqlParameters.mySqlConnection);
                    MySqlParameters.mySqlCommand.CommandTimeout = 60;

                    MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                    if (MySqlParameters.dataReader.HasRows)
                    {
                        while (MySqlParameters.dataReader.Read())
                            productsWithNoStock += MySqlParameters.dataReader.GetString(0)+" ";

                        arduinoSerialPort.Write(productsWithNoStock);
                    }
                    else
                    {
                        arduinoSerialPort.Write(" ");
                    }
                }
                else if (Char.ToString(arduinoRequest[0]) == "B" && arduinoRequest.Length == 2)          //storer requests for a single product, their stock value. . .
                {
                    if (Int32.TryParse(Char.ToString(arduinoRequest[1]), out temp)) {
                        idSingleProduct = Char.ToString(arduinoRequest[1]);

                        MySqlParameters.mySqlCommand = new MySqlCommand(selectStockSingleProductQuery + idSingleProduct, MySqlParameters.mySqlConnection);
                        MySqlParameters.mySqlCommand.CommandTimeout = 60;

                        MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                        if (MySqlParameters.dataReader.HasRows)
                        {
                            MySqlParameters.dataReader.Read();
                            stockSingleProduct = MySqlParameters.dataReader.GetString(0);

                            arduinoSerialPort.Write(stockSingleProduct);
                        }
                        else
                        {
                            arduinoSerialPort.Write(" ");
                        }
                    }
                }
                else if(Char.ToString(arduinoRequest[0]) == "C" && arduinoRequest.Length == 2)          //storer fills stock for a single product. . .
                {
                    idSingleProduct = Char.ToString(arduinoRequest[1]);
                    updateStockSingleProductQuery += idSingleProduct;

                    MySqlParameters.mySqlCommand = new MySqlCommand(updateStockSingleProductQuery, MySqlParameters.mySqlConnection);
                    MySqlParameters.mySqlCommand.CommandTimeout = 60;

                    MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                    arduinoSerialPort.Write("C");
                }

                MySqlParameters.dataReader.Close();

                MySqlParameters.mySqlConnection.Close();

            }
            catch(MySqlException e)
            {
                MessageBox.Show("Conexion fallida, intentelo de nuevo: " + e.Message, "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        
        private void frmDashboard_Load(object sender, EventArgs e) { 
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

        private void frmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduinoSerialPort.IsOpen)
                arduinoSerialPort.Close();
        }
    }
}
