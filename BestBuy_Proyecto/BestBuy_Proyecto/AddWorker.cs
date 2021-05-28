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
    public partial class frmAddWorker : Form
    {
        private Form retDashboard;

        string selectRolesQuery = "SELECT NOMBRE_CARGO FROM CARGO";

        public frmAddWorker(Form formDashboard)
        {
            InitializeComponent();
            retDashboard = formDashboard;
        }

        private void frmAddWorker_Load(object sender, EventArgs e)
        {
            try
            {
                GlobalVariables.mySqlConnection = new MySqlConnection(GlobalVariables.connectionString);
                GlobalVariables.mySqlConnection.Open();

                GlobalVariables.mySqlCommand = new MySqlCommand(selectRolesQuery, GlobalVariables.mySqlConnection);
                GlobalVariables.mySqlCommand.CommandTimeout = 60;

                GlobalVariables.dataReader = GlobalVariables.mySqlCommand.ExecuteReader();

                if (GlobalVariables.dataReader.HasRows)
                {
                    while (GlobalVariables.dataReader.Read())
                        cmbWorkerRole.Items.Add(GlobalVariables.dataReader.GetString(0));
                }
                else
                {
                    MessageBox.Show("La consulta solicitada no contiene registros.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                GlobalVariables.mySqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Conexion fallida, intentelo de nuevo: " + ex.Message, "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            //Here goes more stuff. . 

            GlobalVariables.mySqlConnection.Close();
            retDashboard.Show();
            this.Close();
        }
    }
}
