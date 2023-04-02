namespace thaw5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button_Add = new Button();
            button_Filter = new Button();
            dataGridView1 = new DataGridView();
            comboBox_Filter = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox_Nama_Details = new TextBox();
            textBox_Harga = new TextBox();
            textBox_Stock = new TextBox();
            comboBox_Category_Details = new ComboBox();
            button_AddProduct = new Button();
            button_EditProduct = new Button();
            button_RemoveProduct = new Button();
            dataGridView2 = new DataGridView();
            label8 = new Label();
            textBox_Nama_Category = new TextBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 46);
            label1.Name = "label1";
            label1.Size = new Size(185, 59);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(900, 46);
            label2.Name = "label2";
            label2.Size = new Size(210, 59);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // button_Add
            // 
            button_Add.Location = new Point(322, 96);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(95, 42);
            button_Add.TabIndex = 2;
            button_Add.Text = "All";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // button_Filter
            // 
            button_Filter.Location = new Point(423, 96);
            button_Filter.Name = "button_Filter";
            button_Filter.Size = new Size(95, 42);
            button_Filter.TabIndex = 3;
            button_Filter.Text = "Filter:";
            button_Filter.UseVisualStyleBackColor = true;
            button_Filter.Click += button_Filter_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(730, 515);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // comboBox_Filter
            // 
            comboBox_Filter.Enabled = false;
            comboBox_Filter.FormattingEnabled = true;
            comboBox_Filter.Location = new Point(528, 97);
            comboBox_Filter.Name = "comboBox_Filter";
            comboBox_Filter.Size = new Size(242, 40);
            comboBox_Filter.TabIndex = 5;
            comboBox_Filter.SelectedIndexChanged += comboBox_Filter_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 679);
            label3.Name = "label3";
            label3.Size = new Size(163, 59);
            label3.TabIndex = 6;
            label3.Text = "Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 750);
            label4.Name = "label4";
            label4.Size = new Size(89, 32);
            label4.TabIndex = 7;
            label4.Text = "Nama :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 793);
            label5.Name = "label5";
            label5.Size = new Size(122, 32);
            label5.TabIndex = 8;
            label5.Text = "Category :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 839);
            label6.Name = "label6";
            label6.Size = new Size(89, 32);
            label6.TabIndex = 9;
            label6.Text = "Harga :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 883);
            label7.Name = "label7";
            label7.Size = new Size(83, 32);
            label7.TabIndex = 10;
            label7.Text = "Stock :";
            // 
            // textBox_Nama_Details
            // 
            textBox_Nama_Details.Location = new Point(152, 747);
            textBox_Nama_Details.Name = "textBox_Nama_Details";
            textBox_Nama_Details.Size = new Size(619, 39);
            textBox_Nama_Details.TabIndex = 11;
            // 
            // textBox_Harga
            // 
            textBox_Harga.Location = new Point(152, 839);
            textBox_Harga.Name = "textBox_Harga";
            textBox_Harga.Size = new Size(241, 39);
            textBox_Harga.TabIndex = 12;
            // 
            // textBox_Stock
            // 
            textBox_Stock.Location = new Point(152, 884);
            textBox_Stock.Name = "textBox_Stock";
            textBox_Stock.Size = new Size(241, 39);
            textBox_Stock.TabIndex = 13;
            // 
            // comboBox_Category_Details
            // 
            comboBox_Category_Details.FormattingEnabled = true;
            comboBox_Category_Details.Location = new Point(151, 793);
            comboBox_Category_Details.Name = "comboBox_Category_Details";
            comboBox_Category_Details.Size = new Size(242, 40);
            comboBox_Category_Details.TabIndex = 14;
            // 
            // button_AddProduct
            // 
            button_AddProduct.BackColor = Color.Lime;
            button_AddProduct.Location = new Point(399, 793);
            button_AddProduct.Name = "button_AddProduct";
            button_AddProduct.Size = new Size(122, 130);
            button_AddProduct.TabIndex = 15;
            button_AddProduct.Text = "Add Product";
            button_AddProduct.UseVisualStyleBackColor = false;
            button_AddProduct.Click += button_AddProduct_Click;
            // 
            // button_EditProduct
            // 
            button_EditProduct.BackColor = Color.Yellow;
            button_EditProduct.Location = new Point(525, 793);
            button_EditProduct.Name = "button_EditProduct";
            button_EditProduct.Size = new Size(122, 130);
            button_EditProduct.TabIndex = 16;
            button_EditProduct.Text = "Edit Product";
            button_EditProduct.UseVisualStyleBackColor = false;
            button_EditProduct.Click += button_EditProduct_Click;
            // 
            // button_RemoveProduct
            // 
            button_RemoveProduct.BackColor = Color.Red;
            button_RemoveProduct.Location = new Point(649, 794);
            button_RemoveProduct.Name = "button_RemoveProduct";
            button_RemoveProduct.Size = new Size(122, 130);
            button_RemoveProduct.TabIndex = 17;
            button_RemoveProduct.Text = "Remove Product";
            button_RemoveProduct.UseVisualStyleBackColor = false;
            button_RemoveProduct.Click += button_RemoveProduct_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(900, 146);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.RowTemplate.Height = 41;
            dataGridView2.Size = new Size(403, 380);
            dataGridView2.TabIndex = 18;
            dataGridView2.CellMouseClick += dataGridView2_CellMouseClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(900, 547);
            label8.Name = "label8";
            label8.Size = new Size(89, 32);
            label8.TabIndex = 19;
            label8.Text = "Nama :";
            // 
            // textBox_Nama_Category
            // 
            textBox_Nama_Category.Location = new Point(995, 544);
            textBox_Nama_Category.Name = "textBox_Nama_Category";
            textBox_Nama_Category.Size = new Size(308, 39);
            textBox_Nama_Category.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(1057, 593);
            button1.Name = "button1";
            button1.Size = new Size(122, 130);
            button1.TabIndex = 21;
            button1.Text = "Add Category";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(1181, 593);
            button2.Name = "button2";
            button2.Size = new Size(122, 130);
            button2.TabIndex = 22;
            button2.Text = "Remove Category";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(984, 729);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 305);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(1341, 1007);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox_Nama_Category);
            Controls.Add(label8);
            Controls.Add(dataGridView2);
            Controls.Add(button_RemoveProduct);
            Controls.Add(button_EditProduct);
            Controls.Add(button_AddProduct);
            Controls.Add(comboBox_Category_Details);
            Controls.Add(textBox_Stock);
            Controls.Add(textBox_Harga);
            Controls.Add(textBox_Nama_Details);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox_Filter);
            Controls.Add(dataGridView1);
            Controls.Add(button_Filter);
            Controls.Add(button_Add);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_Add;
        private Button button_Filter;
        private DataGridView dataGridView1;
        private ComboBox comboBox_Filter;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox_Nama_Details;
        private TextBox textBox_Harga;
        private TextBox textBox_Stock;
        private ComboBox comboBox_Category_Details;
        private Button button_AddProduct;
        private Button button_EditProduct;
        private Button button_RemoveProduct;
        private DataGridView dataGridView2;
        private Label label8;
        private TextBox textBox_Nama_Category;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
    }
}