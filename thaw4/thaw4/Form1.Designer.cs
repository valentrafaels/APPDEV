namespace thaw4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox_country = new ComboBox();
            comboBox_team = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox_teamname = new TextBox();
            textBox_teamcountry = new TextBox();
            textBox_teamcity = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox_playername = new TextBox();
            textBox_playernumber = new TextBox();
            button_addteam = new Button();
            button_addplayer = new Button();
            listBox1 = new ListBox();
            button_remove = new Button();
            comboBox_position = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 54);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 0;
            label1.Text = "Soccer Team List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 123);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 1;
            label2.Text = "Choose Country :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 197);
            label3.Name = "label3";
            label3.Size = new Size(170, 32);
            label3.TabIndex = 2;
            label3.Text = "Choose Team :";
            // 
            // comboBox_country
            // 
            comboBox_country.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_country.FormattingEnabled = true;
            comboBox_country.Location = new Point(255, 123);
            comboBox_country.Name = "comboBox_country";
            comboBox_country.Size = new Size(242, 40);
            comboBox_country.TabIndex = 3;
            comboBox_country.SelectedIndexChanged += comboBox_country_SelectedIndexChanged;
            comboBox_country.SelectionChangeCommitted += comboBox_country_SelectionChangeCommitted;
            // 
            // comboBox_team
            // 
            comboBox_team.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_team.FormattingEnabled = true;
            comboBox_team.Items.AddRange(new object[] { "Spain" });
            comboBox_team.Location = new Point(255, 194);
            comboBox_team.Name = "comboBox_team";
            comboBox_team.Size = new Size(242, 40);
            comboBox_team.TabIndex = 4;
            comboBox_team.SelectionChangeCommitted += comboBox_team_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(782, 54);
            label4.Name = "label4";
            label4.Size = new Size(155, 32);
            label4.TabIndex = 5;
            label4.Text = "Adding Team";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(596, 123);
            label5.Name = "label5";
            label5.Size = new Size(154, 32);
            label5.TabIndex = 6;
            label5.Text = "Team Name :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(590, 203);
            label6.Name = "label6";
            label6.Size = new Size(175, 32);
            label6.TabIndex = 7;
            label6.Text = "Team Country :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(596, 287);
            label7.Name = "label7";
            label7.Size = new Size(131, 32);
            label7.TabIndex = 8;
            label7.Text = "Team City :";
            // 
            // textBox_teamname
            // 
            textBox_teamname.Location = new Point(782, 120);
            textBox_teamname.Name = "textBox_teamname";
            textBox_teamname.Size = new Size(243, 39);
            textBox_teamname.TabIndex = 9;
            // 
            // textBox_teamcountry
            // 
            textBox_teamcountry.Location = new Point(781, 196);
            textBox_teamcountry.Name = "textBox_teamcountry";
            textBox_teamcountry.Size = new Size(243, 39);
            textBox_teamcountry.TabIndex = 10;
            // 
            // textBox_teamcity
            // 
            textBox_teamcity.Location = new Point(782, 278);
            textBox_teamcity.Name = "textBox_teamcity";
            textBox_teamcity.Size = new Size(243, 39);
            textBox_teamcity.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1284, 54);
            label8.Name = "label8";
            label8.Size = new Size(162, 32);
            label8.TabIndex = 12;
            label8.Text = "Adding Player";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1078, 120);
            label9.Name = "label9";
            label9.Size = new Size(161, 32);
            label9.TabIndex = 13;
            label9.Text = "Player Name :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1074, 197);
            label10.Name = "label10";
            label10.Size = new Size(185, 32);
            label10.TabIndex = 14;
            label10.Text = "Player Number :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1074, 281);
            label11.Name = "label11";
            label11.Size = new Size(181, 32);
            label11.TabIndex = 15;
            label11.Text = "Player Position :";
            // 
            // textBox_playername
            // 
            textBox_playername.Location = new Point(1284, 117);
            textBox_playername.Name = "textBox_playername";
            textBox_playername.Size = new Size(231, 39);
            textBox_playername.TabIndex = 16;
            // 
            // textBox_playernumber
            // 
            textBox_playernumber.Location = new Point(1284, 199);
            textBox_playernumber.Name = "textBox_playernumber";
            textBox_playernumber.Size = new Size(231, 39);
            textBox_playernumber.TabIndex = 17;
            textBox_playernumber.TextChanged += textBox_playernumber_TextChanged;
            // 
            // button_addteam
            // 
            button_addteam.Location = new Point(782, 352);
            button_addteam.Name = "button_addteam";
            button_addteam.Size = new Size(150, 46);
            button_addteam.TabIndex = 19;
            button_addteam.Text = "Add";
            button_addteam.UseVisualStyleBackColor = true;
            button_addteam.Click += button_addteam_Click;
            // 
            // button_addplayer
            // 
            button_addplayer.Location = new Point(1284, 352);
            button_addplayer.Name = "button_addplayer";
            button_addplayer.Size = new Size(150, 46);
            button_addplayer.TabIndex = 20;
            button_addplayer.Text = "Add";
            button_addplayer.UseVisualStyleBackColor = true;
            button_addplayer.Click += button_addplayer_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(42, 268);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(455, 292);
            listBox1.TabIndex = 21;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(42, 581);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(150, 46);
            button_remove.TabIndex = 22;
            button_remove.Text = "Remove";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // comboBox_position
            // 
            comboBox_position.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_position.FormattingEnabled = true;
            comboBox_position.Items.AddRange(new object[] { "GK", "DF", "MF", "FW" });
            comboBox_position.Location = new Point(1284, 277);
            comboBox_position.Name = "comboBox_position";
            comboBox_position.Size = new Size(231, 40);
            comboBox_position.TabIndex = 23;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1596, 686);
            Controls.Add(comboBox_position);
            Controls.Add(button_remove);
            Controls.Add(listBox1);
            Controls.Add(button_addplayer);
            Controls.Add(button_addteam);
            Controls.Add(textBox_playernumber);
            Controls.Add(textBox_playername);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBox_teamcity);
            Controls.Add(textBox_teamcountry);
            Controls.Add(textBox_teamname);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox_team);
            Controls.Add(comboBox_country);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_country;
        private ComboBox comboBox_team;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox_teamname;
        private TextBox textBox_teamcountry;
        private TextBox textBox_teamcity;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox_playername;
        private TextBox textBox_playernumber;
        private Button button_addteam;
        private Button button_addplayer;
        private ListBox listBox1;
        private Button button_remove;
        private ComboBox comboBox_position;
    }
}