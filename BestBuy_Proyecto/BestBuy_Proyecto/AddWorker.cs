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

        string idRole;
        string insertNewWorker;

        public frmAddWorker(Form formDashboard)
        {
            InitializeComponent();
            retDashboard = formDashboard;
        }

        private void frmAddWorker_Load(object sender, EventArgs e)
        {
            try
            {
                startMySqlConnection();

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

                GlobalVariables.dataReader.Close();

                GlobalVariables.mySqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Conexion fallida, intentelo de nuevo: " + ex.Message, "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            try
            {
                startMySqlConnection();

                idRole = "SELECT CARGO.ID_CARGO FROM CARGO INNER JOIN EMPLEADO ON CARGO.ID_CARGO = EMPLEADO.ID_CARGO WHERE CARGO.NOMBRE_CARGO = '" + cmbWorkerRole.Text + "'";
                GlobalVariables.mySqlCommand = new MySqlCommand(idRole, GlobalVariables.mySqlConnection);
                GlobalVariables.mySqlCommand.CommandTimeout = 60;

                GlobalVariables.dataReader = GlobalVariables.mySqlCommand.ExecuteReader();

                if (GlobalVariables.dataReader.HasRows)
                {
                    while (GlobalVariables.dataReader.Read())
                        idRole = GlobalVariables.dataReader.GetString(0);
                }
                else
                {
                    MessageBox.Show("La consulta solicitada no contiene registros.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                GlobalVariables.dataReader.Close();

                insertNewWorker = "INSERT INTO EMPLEADO (ID_CARGO, NOMBRE_EMPLEADO, PSSW_EMPLEADO) VALUES (@ID_CARGO, @NOMBRE_EMPLEADO, @PSSW_EMPLEADO)";
                GlobalVariables.mySqlCommand = new MySqlCommand(insertNewWorker, GlobalVariables.mySqlConnection);
                GlobalVariables.mySqlCommand.CommandTimeout = 60;

                GlobalVariables.mySqlCommand.Parameters.AddWithValue("@ID_CARGO", idRole);
                GlobalVariables.mySqlCommand.Parameters.AddWithValue("@NOMBRE_EMPLEADO", txtBoxWorkerName.Text);
                GlobalVariables.mySqlCommand.Parameters.AddWithValue("@PSSW_EMPLEADO", txtBoxWorkerPssw.Text);

                if (GlobalVariables.mySqlCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("El empleado " + txtBoxWorkerName.Text + " ha sido agregado.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("El empleado " + txtBoxWorkerName.Text + " no ha sido agregado.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                GlobalVariables.mySqlConnection.Close();
                retDashboard.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Conexion fallida, intentelo de nuevo: " + ex.Message, "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void startMySqlConnection()
        {
            GlobalVariables.mySqlConnection = new MySqlConnection(GlobalVariables.connectionString);
            GlobalVariables.mySqlConnection.Open();
        }
    }
}
