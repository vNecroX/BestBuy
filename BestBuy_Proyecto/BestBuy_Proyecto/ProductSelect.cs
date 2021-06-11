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
    
    public partial class frmSelectProduct : Form
    {
        public struct productData
        {
            public int id;
            public string name;
            public int hm;
        }
        public static List<productData> productDataList = new List<productData>();
        public productData pData = new productData();

        public static int count = 0;
        string productID, auxProductID = "";
        string[] productsInCart = new string[10];
        public static int varietyProducts = 0;
        int i = 0;

        string selectProductPriceQuery;
        float price;

        string selectProductNameQuery;
        string productName;

        public frmSelectProduct(Form frmCarrito, string _productID)
        {
            InitializeComponent();
            productID = _productID;
        }

        private void lblReturn_Click(object sender, EventArgs e)
        {
            frmCarrito frmCarrito = new frmCarrito();
            frmCarrito.Show();
            this.Hide();
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {
            lblPrice.Text = price.ToString();

            if (productID == "1")
                pictureBoxProduct.Image = Properties.Resources.mac;
            if (productID == "2")
                pictureBoxProduct.Image = Properties.Resources.HPEspectre;
            if (productID == "3")
                pictureBoxProduct.Image = Properties.Resources.LGThin;
            if (productID == "4")
                pictureBoxProduct.Image = Properties.Resources.EstantePlegable;
            if (productID == "5")
                pictureBoxProduct.Image = Properties.Resources.MouseSteren;
            if (productID == "6")
                pictureBoxProduct.Image = Properties.Resources.Adata;

            selectProductPriceQuery = "SELECT PRECIO_PRODUCTO FROM PRODUCTO WHERE ID_PRODUCTO=";
            selectProductPriceQuery += productID;
            
            try
            {
                MySqlParameters.startMySqlConnection();

                MySqlParameters.mySqlCommand = new MySqlCommand(selectProductPriceQuery, MySqlParameters.mySqlConnection);

                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    MySqlParameters.dataReader.Read();
                    price = MySqlParameters.dataReader.GetFloat(0);    
                }
                else
                {
                    MessageBox.Show("Precio no disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                MySqlParameters.dataReader.Close();

                selectProductNameQuery = "SELECT NOMBRE_PRODUCTO FROM PRODUCTO WHERE ID_PRODUCTO=";
                selectProductNameQuery += productID;

                MySqlParameters.mySqlCommand = new MySqlCommand(selectProductNameQuery, MySqlParameters.mySqlConnection);

                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    MySqlParameters.dataReader.Read();
                    productName = MySqlParameters.dataReader.GetString(0);
                    MessageBox.Show(productName);
                }
                else
                {
                    MessageBox.Show("Nombre no disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                MySqlParameters.dataReader.Close();
                MySqlParameters.mySqlConnection.Close();
            }

            catch(MySqlException ex)
            {
                MessageBox.Show("Conexión fallida, vuelva a intentar: "+ ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void numericUpDownProducts_ValueChanged(object sender, EventArgs e)
        {
            float TotalPrice = price * (float)numericUpDownProducts.Value;

            lblOpTotal.Text = TotalPrice.ToString();
        }

        private void pictureBoxMarketCar_Click(object sender, EventArgs e)
        {
            /*
            for (; i < 6; i++)
            {
                if (productsInCart[i] == productID)
                    break;
                else
                {
                    productsInCart[varietyProducts] = productID;
                    varietyProducts++;
                }
            }
            */
                
            MessageBox.Show("Producto añadido al carrito", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            count++;
            lblCount.Text = count.ToString();

            pData.id = Int32.Parse(productID);
            pData.name = productName;
            pData.hm = count;
            productDataList.Add(pData);
        }
    }
}
