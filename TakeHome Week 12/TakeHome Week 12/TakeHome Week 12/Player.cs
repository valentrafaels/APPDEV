using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace TakeHome_Week_12
{
    public partial class Player : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtPlayer, dtTeam;
        string connection, command;
        public Player()
        {
            InitializeComponent();
            connection = "server=localhost;user=root;pwd=root;database=premier_league";
            sqlConnection = new MySqlConnection(connection);
            sqlConnection.Open();
        }

        private void Player_Load(object sender, EventArgs e)
        {
            updatePlayer();
        }

        private void btn_Dlt_Click(object sender, EventArgs e)
        {
            int angka = dgv_Player.RowCount;
            if (angka <= 11)
            {
                MessageBox.Show("Total number of players are not greater than 11");
            } else
            {
                int selectedrowindex = dgv_Player.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Player.Rows[selectedrowindex];
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                try
                {
                    sqlConnection.Open();
                    command = $"update player set `status` = 0 where player_name = '{name}';";
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
            updatePlayer();
        }

        private void cmbBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPlayer = new DataTable();
            command = $"SELECT p.player_name as 'Name', n.nation as 'Nationality', p.playing_pos as 'Position', p.team_number as 'Number', p.height as 'Height', p.weight as 'Weight', p.birthdate as 'Birthdate' from player p, nationality n, team t where n.nationality_id = p.nationality_id and t.team_id = p.team_id and p.team_id = '{cmbBox_Team.SelectedValue.ToString()}' and p.status = 1;";
            comboBox(dtPlayer, command);
            dgv_Player.DataSource = dtPlayer;
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            Manager manager= new Manager();
            this.Hide();
            manager.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
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

        private void updatePlayer()
        {
            dtTeam = new DataTable();
            dtPlayer = new DataTable();
            command = "select * from team;";
            comboBox(dtTeam, command);
            cmbBox_Team.DataSource = dtTeam;
            cmbBox_Team.DisplayMember = "team_name";
            cmbBox_Team.ValueMember = "team_id";
        }
    }
}
