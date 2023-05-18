using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHome_Week_12
{
    public partial class Manager : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtTeam, dtManager1, dtManager2, dtID;
        string connection, command;
        public Manager()
        {
            InitializeComponent();
            connection = "server=localhost;user=root;pwd=root;database=premier_league";
            sqlConnection = new MySqlConnection(connection);
            sqlConnection.Open();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
            dtTeam = new DataTable();
            dtManager1 = new DataTable();
            command = "select * from team;";
            comboBox(dtTeam, command);
            cmbBox_Team.DataSource = dtTeam;
            cmbBox_Team.DisplayMember = "team_name";
            cmbBox_Team.ValueMember = "team_id";

            command = "select m.manager_name as 'Name', m.birthdate as 'Birthdate', n.nation as 'Nationality' from manager m, nationality n where m.nationality_id = n.nationality_id and m.working = 0;";
            comboBox(dtManager1, command);
            dgvInactive.DataSource = dtManager1;
        }

        private void cmbBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtManager2 = new DataTable();
            command = $"select m.manager_name as 'Name', t.team_name as 'Team Name', m.birthdate as 'Birthdate', n.nation as 'Nationality' from manager m, nationality n, team t where m.nationality_id = n.nationality_id and m.manager_id = t.manager_id and t.team_name = '{cmbBox_Team.Text}';";
            comboBox(dtManager2, command);
            dgvManager.DataSource = dtManager2;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dgvInactive.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgvInactive.Rows[selectedrowindex];
            string name = Convert.ToString(selectedRow.Cells["Name"].Value);
            string name1 = Convert.ToString(dgvManager.Rows[0].Cells["Name"].Value);

            command = $"update manager set working = 1 where manager_name = '{name}';";
            keDataBase(command);

            command = $"update manager set working = 0 where manager_name = '{name1}';";
            keDataBase(command);

            dtID = new DataTable();
            command = $"select manager_id from manager where manager_name ='{name}';";
            comboBox(dtID, command);

            string id = dtID.Rows[0][0].ToString();
            command = $"update team set manager_id = '{id}' where team_id = '{cmbBox_Team.SelectedValue.ToString()}'; ";
            keDataBase(command);

            dtManager1 = new DataTable(); dtManager2 = new DataTable();
            command = "select m.manager_name as 'Name', m.birthdate as 'Birthdate', n.nation as 'Nationality' from manager m, nationality n where m.nationality_id = n.nationality_id and m.working = 0;";
            comboBox(dtManager1, command);
            dgvInactive.DataSource = dtManager1;

            command = $"select m.manager_name as 'Name', t.team_name as 'Team Name', m.birthdate as 'Birthdate', n.nation as 'Nationality' from manager m, nationality n, team t where m.nationality_id = n.nationality_id and m.manager_id = t.manager_id and t.team_name = '{cmbBox_Team.Text}';";
            comboBox(dtManager2, command);
            dgvManager.DataSource = dtManager2;
        }

        private void btn_AddPlayer_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btn_Player_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            this.Hide();
            player.Show();
        }

        private void comboBox(DataTable dataTable, string com)
        {
            try
            {
                command = com;
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        private void keDataBase(string com)
        {
            try
            {
                sqlConnection.Open();
                command = com;
                sqlCommand = new MySqlCommand(command, sqlConnection);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
