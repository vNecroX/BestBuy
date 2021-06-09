using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestBuy_Proyecto
{
    public partial class frmCarrito : Form
    {
        public frmCarrito()
        {
            InitializeComponent();
        }
        string selectCategorie;
        public void frmBusqueda()
        {
            try
            {
                MySqlParameters.startMySqlConnection();
                selectCategorie = "SELECT * FROM categoria WHERE nombre_categoria = '"+comboBox1+"'";

            }
            catch
            {
                
            }
        }
       
    }
}
