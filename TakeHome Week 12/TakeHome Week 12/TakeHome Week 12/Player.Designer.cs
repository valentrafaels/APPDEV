namespace TakeHome_Week_12
{
    partial class Player
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
            this.dgv_Player = new System.Windows.Forms.DataGridView();
            this.btn_Dlt = new System.Windows.Forms.Button();
            this.btn_manager = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(259, 43);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Player";
            // 
            // cmbBox_Team
            // 
            this.cmbBox_Team.FormattingEnabled = true;
            this.cmbBox_Team.Location = new System.Drawing.Point(261, 76);
            this.cmbBox_Team.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBox_Team.Name = "cmbBox_Team";
            this.cmbBox_Team.Size = new System.Drawing.Size(118, 21);
            this.cmbBox_Team.TabIndex = 27;
            this.cmbBox_Team.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Team_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "PICK TEAM";
            // 
            // dgv_Player
            // 
            this.dgv_Player.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Player.Location = new System.Drawing.Point(165, 122);
            this.dgv_Player.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_Player.MultiSelect = false;
            this.dgv_Player.Name = "dgv_Player";
            this.dgv_Player.RowHeadersWidth = 51;
            this.dgv_Player.RowTemplate.Height = 24;
            this.dgv_Player.Size = new System.Drawing.Size(288, 159);
            this.dgv_Player.TabIndex = 29;
            // 
            // btn_Dlt
            // 
            this.btn_Dlt.Location = new System.Drawing.Point(494, 191);
            this.btn_Dlt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Dlt.Name = "btn_Dlt";
            this.btn_Dlt.Size = new System.Drawing.Size(56, 19);
            this.btn_Dlt.TabIndex = 30;
            this.btn_Dlt.Text = "Delete";
            this.btn_Dlt.UseVisualStyleBackColor = true;
            this.btn_Dlt.Click += new System.EventHandler(this.btn_Dlt_Click);
            // 
            // btn_manager
            // 
            this.btn_manager.Location = new System.Drawing.Point(494, 108);
            this.btn_manager.Name = "btn_manager";
            this.btn_manager.Size = new System.Drawing.Size(66, 22);
            this.btn_manager.TabIndex = 31;
            this.btn_manager.Text = "Manager";
            this.btn_manager.UseVisualStyleBackColor = true;
            this.btn_manager.Click += new System.EventHandler(this.btn_manager_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(494, 147);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 23);
            this.btn_add.TabIndex = 32;
            this.btn_add.Text = "Add Player";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_manager);
            this.Controls.Add(this.btn_Dlt);
            this.Controls.Add(this.dgv_Player);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbBox_Team);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Player";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBox_Team;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgv_Player;
        private System.Windows.Forms.Button btn_Dlt;
        private System.Windows.Forms.Button btn_manager;
        private System.Windows.Forms.Button btn_add;
    }
}