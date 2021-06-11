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
        
        
        
        public static int count = 0;
        string productID;
        string selectProductPriceQuery ;
        float price;
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
            //var source = new BindingSource(); 
       
        
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

                MySqlParameters.mySqlConnection.Close();
            }

            catch(MySqlException ex)
            {
                MessageBox.Show("Conexión fallida, vuelva a intentar: "+ ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            lblPrice.Text = price.ToString();


            if (productID == "1")
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.mac;
            }
            if(productID=="2" )
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.HPEspectre;
            }
            if (productID == "3")
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.LGThin;
            }
            if (productID == "4")
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.EstantePlegable;
            }
            if (productID == "5")
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.MouseSteren;
            }
            if (productID == "6")
            {
                pictureBoxProduct.Image = BestBuy_Proyecto.Properties.Resources.Adata;
            }
         
        }

        private void numericUpDownProducts_ValueChanged(object sender, EventArgs e)
        {
            float TotalPrice = price * (float)numericUpDownProducts.Value;

            lblOpTotal.Text = TotalPrice.ToString();

        }

        private void pictureBoxMarketCar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto añadido", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            

            
           
            productName = "SELECT NOMBRE_PRODUCTO FROM PRODUCTO WHERE ID_PRODUCTO=";
            productName += productID;


            MySqlParameters.startMySqlConnection();

            MySqlParameters.mySqlCommand = new MySqlCommand(productName, MySqlParameters.mySqlConnection);

            MySqlParameters.mySqlCommand.CommandTimeout = 60;

            MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();
            
            if (MySqlParameters.dataReader.HasRows)
            {
                MySqlParameters.dataReader.Read();
                string name = MySqlParameters.dataReader.GetString(0);
                MessageBox.Show(name);

               
            }
            else
            {
                MessageBox.Show("Nombre no disponible", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            MySqlParameters.dataReader.Close();

            MySqlParameters.mySqlConnection.Close();

            count++;

            
    }
    }
}
