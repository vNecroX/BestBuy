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
        string selectRoleIdQuery;
        string insertNewWorkerQuery;

        public frmAddWorker(Form formDashboard)
        {
            InitializeComponent();
            retDashboard = formDashboard;
        }

        private void frmAddWorker_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlParameters.startMySqlConnection();

                MySqlParameters.mySqlCommand = new MySqlCommand(selectRolesQuery, MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    while (MySqlParameters.dataReader.Read())
                        cmbWorkerRole.Items.Add(MySqlParameters.dataReader.GetString(0));
                }
                else
                {
                    MessageBox.Show("La consulta solicitada no contiene registros.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                MySqlParameters.dataReader.Close();

                MySqlParameters.mySqlConnection.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Conexion fallida, intentelo de nuevo: " + ex.Message, "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlParameters.startMySqlConnection();

                selectRoleIdQuery = "SELECT CARGO.ID_CARGO FROM CARGO INNER JOIN EMPLEADO ON CARGO.ID_CARGO = EMPLEADO.ID_CARGO WHERE CARGO.NOMBRE_CARGO = '" + cmbWorkerRole.Text + "'";
                MySqlParameters.mySqlCommand = new MySqlCommand(selectRoleIdQuery, MySqlParameters.mySqlConnection);
                MySqlParameters.mySqlCommand.CommandTimeout = 60;

                MySqlParameters.dataReader = MySqlParameters.mySqlCommand.ExecuteReader();

                if (MySqlParameters.dataReader.HasRows)
                {
                    while (MySqlParameters.dataReader.Read())
                        selectRoleIdQuery = MySqlParameters.dataReader.GetString(0);
                }
                else
                {
                    MessageBox.Show("La consulta solicitada no contiene registros.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                MySqlParameters.dataReader.Close();

                insertNewWorkerQuery = "INSERT INTO EMPLEADO (ID_CARGO, NOMBRE_EMPLEADO, PSSW_EMPLEADO) VALUES(" + selectRoleIdQuery + ", '" + txtBoxWorkerName.Text + "', '" + txtBoxWorkerPssw.Text + "')";
                MySqlParameters.mySqlCommand = new MySqlCommand(insertNewWorkerQuery, MySqlParameters.mySqlConnection);

                try
                {
                    MySqlParameters.mySqlCommand.ExecuteNonQuery();
                    MessageBox.Show("El empleado " + txtBoxWorkerName.Text + " ha sido agregado.", "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("La consulta solicitada no tuvo exito: " + ex.Message, "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                MySqlParameters.mySqlConnection.Close();

                retDashboard.Show();
                this.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Conexion fallida, intentelo de nuevo: " + ex.Message, "Aviso.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
