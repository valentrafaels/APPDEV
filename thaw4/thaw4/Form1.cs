namespace thaw4
{



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public List<Team> teams = new List<Team>();

        private void textBox_playernumber_TextChanged(object sender, EventArgs e)
        {

        }

        public class Player
        {
            public string playerName { get; set; }
            public string playerNum { get; set; }

            public string playerPos { get; set; }
            public Player(string playerName, string playerNum, string playerPos)
            {
                this.playerName = playerName;
                this.playerNum = playerNum;
                this.playerPos = playerPos;
            }
        }

        public class Team
        {
            public string teamName { get; set; }
            public string teamCountry { get; set; }
            public string teamCity { get; set; }

            public List<Player> Players = new List<Player>();

            public Team(string teamName, string teamCountry, string teamCity)
            {
                this.teamName = teamName;
                this.teamCountry = teamCountry;
                this.teamCity = teamCity;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Team default1 = new Team("Bayern Munich", "Germany", "Munich");
            teams.Add(default1);
            Team default2 = new Team("Manchester United", "England", "Manchester");
            teams.Add(default2);
            Team default3 = new Team("Chelsea", "England", "London");
            teams.Add(default3);
            foreach (Team team in teams)
            {
                if (!comboBox_country.Items.Contains(team.teamCountry))
                {
                    comboBox_country.Items.Add(team.teamCountry);
                }
            }

            default1.Players.Add(new Player("Manuel Neuer", "01", "GK"));
            default1.Players.Add(new Player("Dayot Upamecano", "02", "DF"));
            default1.Players.Add(new Player("Matthjis de Ligt", "04", "DF"));
            default1.Players.Add(new Player("Benjamin Pavard", "05", "DF"));
            default1.Players.Add(new Player("Joshua Kimmich", "06", "MF"));
            default1.Players.Add(new Player("Serge Gnarby", "07", "FW"));
            default1.Players.Add(new Player("Leon Goretzka", "08", "MF"));
            default1.Players.Add(new Player("Leroy Sane", "10", "FW"));
            default1.Players.Add(new Player("Paul Wanner", "14", "MF"));
            default1.Players.Add(new Player("Lucas Hernandez", "21", "DF"));
            default1.Players.Add(new Player("Thomas Muller", "25", "FW"));

            default2.Players.Add(new Player("David De Gea", "01", "GK"));
            default2.Players.Add(new Player("Victor Lindelof", "02", "DF"));
            default2.Players.Add(new Player("Phil Jones", "04", "DF"));
            default2.Players.Add(new Player("Harry Maguire", "05", "DF"));
            default2.Players.Add(new Player("Lisandro Martinez", "06", "DF"));
            default2.Players.Add(new Player("Bruno Fernandez", "08", "MF"));
            default2.Players.Add(new Player("Anthony Martial", "09", "FW"));
            default2.Players.Add(new Player("Marcus Rashford", "10", "FW"));
            default2.Players.Add(new Player("Tyrell Malacia", "12", "DF"));
            default2.Players.Add(new Player("Christian Eriksen", "14", "MF"));
            default2.Players.Add(new Player("Casemiro", "18", "MF"));

            default3.Players.Add(new Player("Kepa Amizabalaga", "01", "GK"));
            default3.Players.Add(new Player("Benoit Badiashile", "04", "DF"));
            default3.Players.Add(new Player("Enzo Fernandez", "05", "MF"));
            default3.Players.Add(new Player("Thiago Silva", "06", "DF"));
            default3.Players.Add(new Player("N'Golo Kante", "07", "MF"));
            default3.Players.Add(new Player("Mateo Kovacic", "08", "MF"));
            default3.Players.Add(new Player("Pierre-Emerick Aubameyang", "09", "FW"));
            default3.Players.Add(new Player("Christian Pulisic", "10", "MF"));
            default3.Players.Add(new Player("Joao Felix", "11", "FW"));
            default3.Players.Add(new Player("Ruben Loftus-Cheek", "12", "MF"));
            default3.Players.Add(new Player("Raheem Sterling", "17", "MF"));
        }

        private void button_addteam_Click(object sender, EventArgs e)
        {
            Team team1 = new Team(textBox_teamname.Text, textBox_teamcountry.Text, textBox_teamcity.Text);
            comboBox_country.Items.Clear();
            bool adaTeam = false;
            if (textBox_teamname.Text == "" || textBox_teamcountry.Text == "" || textBox_teamcity.Text == "")
            {
                MessageBox.Show("All fields need to be filled!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Team a in teams)
                {
                    if (a.teamName == team1.teamName)
                    {
                        adaTeam = true;
                    }
                }
            }
            if (adaTeam == false)
            {
                teams.Add(team1);
            }
            else
            {
                MessageBox.Show("Team already exists, please add another team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox_teamname.Text = "";
            textBox_teamcountry.Text = "";
            textBox_teamcity.Text = "";

            foreach (Team a in teams)
            {
                if (!comboBox_country.Items.Contains(a.teamCountry))
                {
                    comboBox_country.Items.Add(a.teamCountry);
                }
            }
        }

        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_country_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string forCountry = comboBox_country.Text;
            comboBox_team.Items.Clear();
            foreach (Team a in teams)
            {
                if (a.teamCountry == forCountry)
                {
                    comboBox_team.Items.Add(a.teamName);
                }
            }
        }

        private void comboBox_team_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Team a in teams)
            {
                if (a.teamName == comboBox_team.Text)
                {
                    foreach (Player b in a.Players)
                    {
                        listBox1.Items.Add("(" + b.playerNum + ")" + b.playerName + "," + b.playerPos);
                    }
                    break;

                }
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count < 11)
            {
                MessageBox.Show("Players must be more or equal to 11!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Team a in teams)
                {
                    if (a.teamName == comboBox_team.Text)
                    {
                        foreach (Player b in a.Players)
                        {
                            if (listBox1.SelectedItem.ToString().Contains(b.playerName))
                            {
                                a.Players.Remove(b);
                                break;
                            }
                        }
                    }
                }
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button_addplayer_Click(object sender, EventArgs e)
        {
            bool notthere = true;

            if (textBox_playername.Text == "" || textBox_playernumber.Text == "" || comboBox_position.SelectedIndex == -1)
            {
                MessageBox.Show("Team already exists, please add another team.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_team.Text == "")
                {
                    MessageBox.Show("Please select a team first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Player player1 = new Player(textBox_playername.Text, textBox_playernumber.Text, comboBox_position.Text);
                    foreach (Team a in teams)
                    {
                        if (a.teamName == comboBox_team.Text)
                        {
                            foreach (Player b in a.Players)
                            {
                                if (player1.playerNum == b.playerNum)
                                {
                                    notthere = false;
                                    break;
                                }
                            }
                            if (notthere == true)
                            {
                                a.Players.Add(player1);
                            }
                            else
                            {
                                MessageBox.Show("Players with the same number is found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                    }
                }
                textBox_playername.Text = "";
                textBox_playernumber.Text = "";
                comboBox_position.SelectedIndex = -1;
            }
        }
    }
}

