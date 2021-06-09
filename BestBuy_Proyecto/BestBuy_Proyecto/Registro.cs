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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        string  addclient;
     

        private void button1_Click(object sender, EventArgs e)
        {
                MySqlParameters.startMySqlConnection();
                addclient = "INSERT INTO cliente (nombre_cliente, nombre_usuario, pssw_usuario) VALUES('"+ textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
                MySqlParameters.mySqlCommand = new MySqlCommand(addclient, MySqlParameters.mySqlConnection);
                try
                {

                    try
                    {
                    MySqlParameters.mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("El usuiario ha sido registrado");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Intentelo nuevamente" + ex.Message);
                    }
                MySqlParameters.mySqlConnection.Close();
                frmCarrito frmCarrito = new frmCarrito();
                frmCarrito.Show();
                this.Hide();
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
           

        }
        }
    }

