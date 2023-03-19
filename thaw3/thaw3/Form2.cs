using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thaw3
{
    public partial class Form2 : Form
    {
        public static Form2 Instance;

        public Label labelform;
        public Form1 MainForm;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
            labelform = label3;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_Magic_Click(object sender, EventArgs e)
        {

            if (!radioButton_red1.Checked && !radioButton_Green1.Checked && !radioButton_Blue1.Checked && !radioButton_Brown.Checked && radioButton_Yellow.Checked && !radioButton_Red2.Checked && !radioButton_Green2.Checked && !radioButton_Blue2.Checked)
            {
                MessageBox.Show("Cannot Be Empty Lah");
            }
            else
            {
                if (radioButton_red1.Checked)
                {
                    MainForm.BackColor = Color.Red;
                }
                if (radioButton_Green1.Checked)
                {
                    MainForm.BackColor = Color.Green;
                }
                if (radioButton_Blue1.Checked)
                {
                    MainForm.BackColor = Color.Blue;
                }
                if (radioButton_Brown.Checked)
                {
                    MainForm.BackColor = Color.Brown;
                }
                if (radioButton_Yellow.Checked)
                {
                    MainForm.BackColor = Color.Yellow;
                }
                if (radioButton_Red2.Checked)
                {
                    MainForm.ForeColor = Color.Red;
                }
                if (radioButton_Green2.Checked)
                {
                    MainForm.ForeColor = Color.Green;
                }
                if (radioButton_Blue2.Checked)
                {
                    MainForm.ForeColor = Color.Blue;
                }
            }
        }

        private void checkBox_ToA_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ToA.Checked && checkBox_TrueChoice.Checked)
            {
                button_Magic.Enabled = true;
            }
        }

        private void checkBox_TrueChoice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ToA.Checked && checkBox_TrueChoice.Checked)
            {
                button_Magic.Enabled = true;
            }
        }
    }
}
