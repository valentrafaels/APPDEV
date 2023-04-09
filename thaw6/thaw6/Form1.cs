namespace thaw6
{
    public partial class Form1 : Form
    {
        public static int GuessInputs;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_GuessCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_GuessCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button_forPlay_Click(object sender, EventArgs e)
        {

            if (textBox_GuessCount.Text == "")
            {
                MessageBox.Show("Isi dulu Bos!");
            }
            else
            {
                GuessInputs = Convert.ToInt32(textBox_GuessCount.Text);
                if (GuessInputs < 3)
                {
                    MessageBox.Show("Harus 3 Keatas!");
                }
                else
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();
                }
            }
            
            
        }
    }
}