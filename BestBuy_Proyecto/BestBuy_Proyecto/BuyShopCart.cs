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
    public partial class BuyShopCart : Form
    {
        public BuyShopCart()
        {
            InitializeComponent();    
        }

        private void BuyShopCart_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id", Type.GetType("System.Int"));
            dt.Columns.Add("Nombre", Type.GetType("System.String"));
            dt.Columns.Add("Carrito", Type.GetType("System.Int"));

            DataRow dataRow = dt.NewRow();

            dataRow["id"] = frmShopCart.productDataList[0];

            //MySqlDataAdapter adaptador = new MySqlDataAdapter(Equipo, MySqlParameters.mySqlConnection);

            //adaptador.Fill(dt);
            //dataGridView1.DataSource = dt;
        }
    }
}
