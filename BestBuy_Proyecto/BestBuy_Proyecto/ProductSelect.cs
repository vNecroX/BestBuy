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
    public partial class frmSelectProduct : Form
    {
        private Form retSearch;
        public frmSelectProduct(Form form)
        {
            InitializeComponent();
            retSearch = form;
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
