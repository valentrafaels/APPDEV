namespace TakeHome_Week_12
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.cmbBox_Team = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Player = new System.Windows.Forms.Button();
            this.btn_AddPlayer = new System.Windows.Forms.Button();
            this.dgvManager = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInactive = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInactive)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Manager";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cmbBox_Team
            // 
            this.cmbBox_Team.FormattingEnabled = true;
            this.cmbBox_Team.Location = new System.Drawing.Point(344, 91);
            this.cmbBox_Team.Name = "cmbBox_Team";
            this.cmbBox_Team.Size = new System.Drawing.Size(156, 24);
            this.cmbBox_Team.TabIndex = 24;
            this.cmbBox_Team.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Team_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(232, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "PICK TEAM";
            // 
            // btn_Player
            // 
            this.btn_Player.Location = new System.Drawing.Point(633, 121);
            this.btn_Player.Name = "btn_Player";
            this.btn_Player.Size = new System.Drawing.Size(75, 23);
            this.btn_Player.TabIndex = 27;
            this.btn_Player.Text = "Player";
            this.btn_Player.UseVisualStyleBackColor = true;
            this.btn_Player.Click += new System.EventHandler(this.btn_Player_Click);
            // 
            // btn_AddPlayer
            // 
            this.btn_AddPlayer.Location = new System.Drawing.Point(615, 92);
            this.btn_AddPlayer.Name = "btn_AddPlayer";
            this.btn_AddPlayer.Size = new System.Drawing.Size(107, 23);
            this.btn_AddPlayer.TabIndex = 26;
            this.btn_AddPlayer.Text = "Add Player";
            this.btn_AddPlayer.UseVisualStyleBackColor = true;
            this.btn_AddPlayer.Click += new System.EventHandler(this.btn_AddPlayer_Click);
            // 
            // dgvManager
            // 
            this.dgvManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManager.Location = new System.Drawing.Point(23, 148);
            this.dgvManager.MultiSelect = false;
            this.dgvManager.Name = "dgvManager";
            this.dgvManager.RowHeadersWidth = 51;
            this.dgvManager.RowTemplate.Height = 24;
            this.dgvManager.Size = new System.Drawing.Size(454, 112);
            this.dgvManager.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Manager of the team";
            // 
            // dgvInactive
            // 
            this.dgvInactive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInactive.Location = new System.Drawing.Point(224, 295);
            this.dgvInactive.MultiSelect = false;
            this.dgvInactive.Name = "dgvInactive";
            this.dgvInactive.RowHeadersWidth = 51;
            this.dgvInactive.RowTemplate.Height = 24;
            this.dgvInactive.Size = new System.Drawing.Size(436, 143);
            this.dgvInactive.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Inactive Manager";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(677, 352);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 32;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvInactive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvManager);
            this.Controls.Add(this.btn_Player);
            this.Controls.Add(this.btn_AddPlayer);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbBox_Team);
            this.Controls.Add(this.label11);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInactive)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBox_Team;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Player;
        private System.Windows.Forms.Button btn_AddPlayer;
        private System.Windows.Forms.DataGridView dgvManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInactive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Update;
    }
}