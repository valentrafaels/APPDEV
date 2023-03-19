namespace thaw3
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
            button_OpenNext = new Button();
            label_name = new Label();
            label1 = new Label();
            textBox_Name = new TextBox();
            textBox_FavArtist = new TextBox();
            checkBox_truecontent = new CheckBox();
            button_Submit1 = new Button();
            SuspendLayout();
            // 
            // button_OpenNext
            // 
            button_OpenNext.Location = new Point(77, 59);
            button_OpenNext.Name = "button_OpenNext";
            button_OpenNext.Size = new Size(224, 46);
            button_OpenNext.TabIndex = 0;
            button_OpenNext.Text = "Open Next Form";
            button_OpenNext.UseVisualStyleBackColor = true;
            button_OpenNext.Click += button_OpenNext_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(81, 135);
            label_name.Name = "label_name";
            label_name.Size = new Size(90, 32);
            label_name.TabIndex = 1;
            label_name.Text = "Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 191);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 2;
            label1.Text = "My Favorite Artist : ";
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(360, 135);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(337, 39);
            textBox_Name.TabIndex = 3;
            // 
            // textBox_FavArtist
            // 
            textBox_FavArtist.Location = new Point(360, 184);
            textBox_FavArtist.Name = "textBox_FavArtist";
            textBox_FavArtist.Size = new Size(337, 39);
            textBox_FavArtist.TabIndex = 4;
            // 
            // checkBox_truecontent
            // 
            checkBox_truecontent.AutoSize = true;
            checkBox_truecontent.Location = new Point(81, 266);
            checkBox_truecontent.Name = "checkBox_truecontent";
            checkBox_truecontent.Size = new Size(441, 36);
            checkBox_truecontent.TabIndex = 5;
            checkBox_truecontent.Text = "All of the content I put above is true!";
            checkBox_truecontent.UseVisualStyleBackColor = true;
            checkBox_truecontent.CheckedChanged += checkBox_truecontent_CheckedChanged;
            // 
            // button_Submit1
            // 
            button_Submit1.Enabled = false;
            button_Submit1.Location = new Point(360, 339);
            button_Submit1.Name = "button_Submit1";
            button_Submit1.Size = new Size(135, 46);
            button_Submit1.TabIndex = 6;
            button_Submit1.Text = "Submit";
            button_Submit1.UseVisualStyleBackColor = true;
            button_Submit1.Click += button_Submit1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1296, 1036);
            Controls.Add(button_Submit1);
            Controls.Add(checkBox_truecontent);
            Controls.Add(textBox_FavArtist);
            Controls.Add(textBox_Name);
            Controls.Add(label1);
            Controls.Add(label_name);
            Controls.Add(button_OpenNext);
            Name = "Form1";
            Text = "Main_Window_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_OpenNext;
        private Label label_name;
        private Label label1;
        private TextBox textBox_Name;
        private TextBox textBox_FavArtist;
        private CheckBox checkBox_truecontent;
        private Button button_Submit1;
    }
}