using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TakeHome_Week_12
{
    public partial class Form1 : Form
    {
        
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dtNationality, dtTeamName;
        string connection, command;



        public Form1()
        {
            InitializeComponent();      
            connection = "server=localhost;user=root;pwd=root;database=premier_league";
            sqlConnection = new MySqlConnection(connection);
            sqlConnection.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtNationality = new DataTable();
            dtTeamName = new DataTable();

            command = "select * from nationality;";
            comboBox(dtNationality, command);
            cmbBox_Nationality.DataSource = dtNationality;
            cmbBox_Nationality.DisplayMember = "nation";
            cmbBox_Nationality.ValueMember = "nationality_id";

            command = "select * from team;";
            comboBox(dtTeamName, command);
            cmbBox_TeamName.DataSource = dtTeamName;
            cmbBox_TeamName.DisplayMember = "team_name";
            cmbBox_TeamName.ValueMember = "team_id";
        }

        private void btn_Manager_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            this.Hide();
            manager.Show();
        }

        private void btn_Player_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            this.Hide();
            player.Show();
        }

        private void btn_AddPlayer_Click(object sender, EventArgs e)
        {
            string birth = dtp_Birthdate.Value.ToString("yyyy-MM-dd");
          /*  command = $"insert into player values ('{txtBox_PlayerID.Text}','{txtBox_TeamNum.Text}','{txtBox_Name.Text}','{cmbBox_Nationality.SelectedValue.ToString()}','{txtBox_Position.Text}',{txtBox_Height.Text},{txtBox_Height.Text},'{birth}','{cmbBox_TeamName.SelectedValue.ToString()}',1,0);";
            keDataBase(command);*/
            try
            {
                sqlConnection.Open();
                command = $"insert into player values ('{txtBox_PlayerID.Text}','{txtBox_TeamNum.Text}','{txtBox_Name.Text}','{cmbBox_Nationality.SelectedValue.ToString()}','{txtBox_Position.Text}',{txtBox_Height.Text},{txtBox_Height.Text},'{birth}','{cmbBox_TeamName.SelectedValue.ToString()}',1,0);"; ;
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
    }
}
