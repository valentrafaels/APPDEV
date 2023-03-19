namespace thaw3
{
    public partial class Form1 : Form
    {
        bool forButtonItu = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_OpenNext_Click(object sender, EventArgs e)
        {
            Form2 Second_Window_Form = new Form2();
            Second_Window_Form.MainForm = this;
            Second_Window_Form.Show();
            forButtonItu = true;

            if (checkBox_truecontent.Checked && forButtonItu == true)
            {
                button_Submit1.Enabled = true;
            }
        }

        private void button_Submit1_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" && textBox_FavArtist.Text == "")
            {
                MessageBox.Show("Cannot Be Empty Lah");
            }
            else 
            {
                Form2.Instance.labelform.Text = "Hi My name is " + textBox_Name.Text +" and My Favorite Artist is " + textBox_FavArtist.Text;
            }
        }

        private void checkBox_truecontent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_truecontent.Checked && forButtonItu == true)
            {
                button_Submit1.Enabled = true;
            }
        }
    }
}