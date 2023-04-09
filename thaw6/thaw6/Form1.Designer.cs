namespace thaw6
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
            textBox_GuessCount = new TextBox();
            button_forPlay = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 26);
            label1.Name = "label1";
            label1.Size = new Size(348, 100);
            label1.TabIndex = 0;
            label1.Text = "WORDLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 122);
            label2.Name = "label2";
            label2.Size = new Size(283, 25);
            label2.TabIndex = 1;
            label2.Text = "Set How Much You Can Guess!";
            // 
            // textBox_GuessCount
            // 
            textBox_GuessCount.Location = new Point(74, 160);
            textBox_GuessCount.Name = "textBox_GuessCount";
            textBox_GuessCount.Size = new Size(200, 39);
            textBox_GuessCount.TabIndex = 2;
            textBox_GuessCount.TextChanged += textBox_GuessCount_TextChanged;
            textBox_GuessCount.KeyPress += textBox_GuessCount_KeyPress;
            // 
            // button_forPlay
            // 
            button_forPlay.Location = new Point(113, 210);
            button_forPlay.Name = "button_forPlay";
            button_forPlay.Size = new Size(127, 46);
            button_forPlay.TabIndex = 3;
            button_forPlay.Text = "Play!";
            button_forPlay.UseVisualStyleBackColor = true;
            button_forPlay.Click += button_forPlay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 388);
            Controls.Add(button_forPlay);
            Controls.Add(textBox_GuessCount);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "A";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_GuessCount;
        private Button button_forPlay;
    }
}