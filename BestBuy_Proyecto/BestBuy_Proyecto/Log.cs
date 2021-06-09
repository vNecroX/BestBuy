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
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }
 

        public void Log()
        {


            try
            {
                MySqlParameters.startMySqlConnection();
                MySqlParameters.mySqlCommand = new MySqlCommand("SELECT * FROM cliente WHERE nombre_usuario= '" + textBox1.Text + "'AND pssw_usuario= '" + textBox2.Text + "'", MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    while (MySqlParameters.dataReader.Read())
                    {
                        MessageBox.Show("Haz ingresado");
                      frmCarrito frmCarrito = new frmCarrito();
                        frmCarrito.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("A ocurrido un error intentelo mas tarde");
                }

                MySqlParameters.dataReader.Close();

                MySqlParameters.mySqlConnection.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Log();
        }

        private void lblCrear_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Hide();
        }
    }
}
