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
        string productor2;
        private Form retSearch;
        public frmSelectProduct(Form form, string _Productor2)
        {
            InitializeComponent();
            retSearch = form;
            productor2 = _Productor2;
        }

        private void frmSelectProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
