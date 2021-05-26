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
    public partial class frm_Login : Form
    {
        public static Form dashboard;

        public frm_Login()
        {
            InitializeComponent();
            dashboard = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new AddWorker(dashboard);
            addWorker.Show();
            this.Hide();
        }
    }
}
