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
    public partial class AddWorker : Form
    {
        private Form retDashboard;

        public AddWorker(Form formDashboard)
        {
            InitializeComponent();
            retDashboard = formDashboard;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            retDashboard.Show();     
            this.Close();
        }
    }
}
