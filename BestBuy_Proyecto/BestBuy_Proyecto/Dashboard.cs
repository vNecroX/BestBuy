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
    public partial class frmDashboard : Form
    {
        public static Form dashboard;

        public frmDashboard()
        {
            InitializeComponent();
            dashboard = this;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void lblAddWorker_Click(object sender, EventArgs e)
        {
            frmAddWorker addWorker = new frmAddWorker(dashboard);
            addWorker.Show();
            this.Hide();
        }

        private void picBoxProduct_Click(object sender, EventArgs e)
        {

        }

        private void picBoxLog_Click(object sender, EventArgs e)
        {

        }
    }
}
