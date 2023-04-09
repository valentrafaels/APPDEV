using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thaw6
{
    public partial class Form2 : Form
    {
        Button[,] button;
        string[] abcetc;
        List<string> abcetc2;
        string jawaban;
        int tebakx;
        int tebaky;
        int totalguess;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int x = 10; int y = 10;
            tebakx = 0; tebaky = 0;
            abcetc = new string[26] { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
            totalguess = Form1.GuessInputs;
            int wordlength = 5;
            button = new Button[wordlength, totalguess];
                for (int i = 0; i < wordlength; i++)
                {
                    for (int j = 0; j < totalguess; j++)
                    {
                        button[i, j] = new Button();
                        button[i, j].Tag = i.ToString() + ", " + j.ToString();
                        button[i, j].Size = new Size(50, 50);
                        button[i, j].Location = new Point(x, y);
                        this.Controls.Add(button[i, j]);
                        y += 50;
                    }
                    x += 50;
                    y = 10;
                }
            int tombolx = 304;
            int tomboly = 35;
            foreach (string a in abcetc)
                {
                    if (a == "A")
                    {
                        tombolx = 331;
                        tomboly = 86;
                    }
                    if (a == "Z")
                    {
                        tombolx = 380;
                        tomboly = 137;
                    }
                    Button forLetter = new Button();
                    forLetter.Text = a;
                    forLetter.Location = new Point(tombolx, tomboly);
                    forLetter.Size = new Size(45, 45);
                    forLetter.Click += forLetter_Click;
                    this.Controls.Add(forLetter);
                    tombolx += 47;
                }
                Button forEnter = new Button();
                forEnter.Location = new Point(305, 137);
                forEnter.Size = new Size(71, 45);
                forEnter.Text = "Enter";
                forEnter.Click += forEnter_Click;
                this.Controls.Add(forEnter);

                Button forDelete = new Button();
                forDelete.Location = new Point(709, 137);
                forDelete.Size = new Size(70, 45);
                forDelete.Text = "Delete";
                forDelete.Click += forDelete_Click;
                this.Controls.Add(forDelete);    

                string file = "Wordle Word List.txt";
                string[]wordLine = File.ReadAllLines(file);
                abcetc2 = new List<string>();
                foreach (string a in wordLine)
                {
                    abcetc2.AddRange(a.Split(','));
                }
                jawaban = abcetc2[new Random().Next(abcetc2.Count - 1)].ToUpper();
            
        }

        private void forLetter_Click(object sender, EventArgs e)
        {
            var forSending = sender as Button;
            if (tebakx != 5)
            {
                button[tebakx, tebaky].Text = forSending.Text;
                tebakx++;
            }
        }

        private void forEnter_Click(object sender, EventArgs e)
        {
            int green = 0;
            if (tebakx != 5)
            {
                MessageBox.Show("Panjangnya harus 5 huruf!" + tebakx.ToString());
            }
            else
            {
                string forWord = "";
                for (int i = 0; i < tebakx; i++)
                {
                    forWord += button[i, tebaky].Text;
                }
                if (abcetc2.Contains(forWord.ToLower()))
                {
                    for (int i = 0; i < tebakx; i++)
                    {
                        if (jawaban.Contains(button[i, tebaky].Text))
                        {
                            button[i, tebaky].BackColor = Color.Yellow;
                        }
                        if (jawaban[i].ToString() == button[i, tebaky].Text)
                        {
                            button[i, tebaky].BackColor = Color.Green;
                            green++;
                        }
                    }
                    tebaky++;
                    if (green != 5 && tebaky == totalguess)
                    {
                        MessageBox.Show("Game is over! Correct word is " + jawaban);
                        this.Close();
                    }
                    else
                    {
                        tebakx = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Word Not found in word list!");
                }
            }
        }
        private void forDelete_Click(object sender, EventArgs e)
        {
            if(tebakx != 0)
            {
                tebakx--;
                button[tebakx, tebaky].Text = "";
            }
        }
    }
}
