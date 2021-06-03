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
        public Form retSearch;
        
        int productID;
        string selectProductPriceQuery = "SELECT PRECIO_PRODUCTO FROM PRODUCTO WHERE ID_PRODUCTO=";
        float price;
        
        
        public frmSelectProduct(Form search, int _productID)
        {
            InitializeComponent();
            retSearch = search;
            productID = _productID;
            selectProductPriceQuery += productID.ToString();


        }
                

        private void lblReturn_Click(object sender, EventArgs e)
        {
            retSearch.Show();
            this.Hide();
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {
            
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

                MySqlParameters.mySqlConnection.Close();
            }

            catch(MySqlException ex)
            {
                MessageBox.Show("Conexión fallida, vuelva a intentar: "+ ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            lblPrice.Text = price.ToString();


            if (productID == 1)
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.mac;
            }
            if(productID==2 )
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.HPEspectre;
            }
            if (productID == 3)
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.LGThin;
            }
            if (productID == 4)
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.EstantePlegable;
            }
            if (productID == 5)
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.MouseSteren;
            }
            if (productID == 6)
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.Adata;
            }
         
        }

        private void numericUpDownProducts_ValueChanged(object sender, EventArgs e)
        {
            float TotalPrice = price * (float)numericUpDownProducts.Value;

            lblOpTotal.Text = TotalPrice.ToString();


        }
    }
}
