using System;
using System.Data;

namespace thaw5
{
    public partial class Form1 : Form
    {

        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        List<Product> produk = new List<Product>();
        List<Category> kategori = new List<Category>();
        List<string> id = new List<string>();
        int index = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Prodcut");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");

            dataGridView1.DataSource = dtProdukSimpan;
            dataGridView2.DataSource = dtCategory;

            produk.Add(new Product("J001", "Jas Hitam", "100000", "10", "C1"));
            produk.Add(new Product("T001", "T-shirt Black Men", "70000", "20", "C2"));
            produk.Add(new Product("T002", "T-shirt Obsessive", "75000", "16", "C2"));
            produk.Add(new Product("R001", "Rok Mini", "82000", "26", "C3"));
            produk.Add(new Product("J002", "Jeans Biru", "90000", "5", "C4"));
            produk.Add(new Product("C001", "Celana Pendek Cokelat", "60000", "11", "C4"));
            produk.Add(new Product("C002", "Cawat Blink-Blink", "1000000", "1", "C5"));
            produk.Add(new Product("R002", "Roca Shirt", "50000", "8", "C2"));

            id.Add("J001");
            id.Add("T001");
            id.Add("T002");
            id.Add("R001");
            id.Add("J002");
            id.Add("C001");
            id.Add("C002");
            id.Add("R002");

            kategori.Add(new Category("C1", "Jas"));
            kategori.Add(new Category("C2", "T-shirt"));
            kategori.Add(new Category("C3", "Rok"));
            kategori.Add(new Category("C4", "Celana"));
            kategori.Add(new Category("C5", "Cawat"));

            foreach (Product a in produk)
            {
                dtProdukSimpan.Rows.Add(a.idproduct, a.nama, a.harga, a.stock, a.idcategory);
            }

            foreach (Category b in kategori)
            {
                dtCategory.Rows.Add(b.id, b.nama);
                comboBox_Category_Details.Items.Add(b.nama);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (Category a in kategori)
            {
                if (a.nama == textBox_Nama_Category.Text)
                {
                    count++;
                }

            }
            if (count == 1)
            {
                MessageBox.Show("Code Error");
            }
            else
            {
                index++;
                kategori.Add(new Category("C" + index, textBox_Nama_Category.Text));

                dtCategory.Rows.Clear();
                comboBox_Category_Details.Items.Clear();
                comboBox_Filter.Items.Clear();
                foreach (Category b in kategori.ToList())
                {
                    dtCategory.Rows.Add(b.id, b.nama);
                    comboBox_Filter.Items.Add(b.nama);
                    comboBox_Category_Details.Items.Add(b.nama);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int PlusOnDGV = dataGridView2.CurrentCell.RowIndex;
            string TakingCode = dataGridView2.Rows[PlusOnDGV].Cells[0].Value.ToString();
            string IntOnCode = TakingCode.Substring(1, 1);
            dtCategory.Rows[PlusOnDGV].Delete();
            kategori.RemoveAt(PlusOnDGV);
            comboBox_Category_Details.Items.Clear();
            comboBox_Filter.Items.Clear();
            int counts = 0;
            foreach (Category a in kategori.ToList())
            {

                comboBox_Filter.Items.Add(kategori[counts].nama);
                comboBox_Filter.Items.Add(kategori[counts].nama);
                counts++;
            }

            comboBox_Filter.Text = string.Empty;
            dtProdukSimpan.Rows.Clear();
            foreach (string b in id.ToList())
            {
                id.Remove(b);
            }

            foreach (Product c in produk.ToList())
            {


                if (IntOnCode != c.idcategory.Substring(1, 1))
                    dtProdukSimpan.Rows.Add(c.idproduct, c.nama, c.harga, c.stock, c.idcategory);



                if (IntOnCode == c.idcategory.Substring(1, 1))
                {
                    produk.Remove(c);

                }
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            dtProdukSimpan.Rows.Clear();
            comboBox_Filter.Text = string.Empty;

            foreach (Product a in produk)
            {
                dtProdukSimpan.Rows.Add(a.idproduct, a.nama, a.harga, a.stock, a.idcategory);
            }
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            comboBox_Filter.Enabled = true;
            comboBox_Filter.Items.Clear();
            foreach (Category a in kategori.ToList())
            {
                comboBox_Filter.Items.Add(a.nama);
            }
        }

        private void comboBox_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string save = "";
            int takeint = 0;
            string filter = comboBox_Filter.SelectedItem.ToString();
            foreach (Category p in kategori.ToList())
            {
                if (p.nama.ToString() == filter)
                {
                    save = p.id.Substring(1, 1);
                    takeint = Convert.ToInt32(save);

                }
            }
            dtProdukSimpan.Rows.Clear();
            foreach (Product a in produk)
            {
                if (a.idcategory.Substring(1, 1) == takeint.ToString())
                {
                    dtProdukSimpan.Rows.Add(a.idproduct, a.nama, a.idcategory, a.stock, a.idcategory);
                }

            }
        }

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int a = dataGridView2.CurrentCell.RowIndex;
            textBox_Nama_Category.Text = dataGridView2.Rows[a].Cells[1].Value.ToString();
        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            string inttaker = "";
            string forCategory = comboBox_Category_Details.Text;
            int count = 0;
            if (textBox_Nama_Details.Text == string.Empty || textBox_Harga.Text == string.Empty || textBox_Harga.Text == string.Empty || comboBox_Category_Details.Text == string.Empty)
            {
                MessageBox.Show("Cannot Add Emptiness, Please Fill!");
            }
            else
            {
                foreach (Category a in kategori.ToList())
                {
                    if (a.nama == forCategory)
                    {
                        inttaker = a.id.Substring(1, 1);
                    }
                }
                produk.Add(new Product("222", textBox_Nama_Details.Text, textBox_Harga.Text, textBox_Stock.Text, "C" + inttaker));
                dtProdukSimpan.Rows.Clear();
                foreach (string b in id.ToList())
                {
                    id.Remove(b);
                }
                foreach (Product c in produk.ToList())
                {
                    count = 0;
                    if (c.idproduct == "222")
                    {
                        id.Add(c.nama.Substring(0, 1));
                        count++;
                    }
                    else
                    {
                        id.Add(c.idproduct);
                    }
                    int check = 0;
                    foreach (string a in id.ToList())
                    {
                        if (a.Substring(0, 1) == c.nama.Substring(0, 1))
                        {
                            check++;
                        }
                    }
                    if (count == 0)
                    {
                        dtProdukSimpan.Rows.Add(c.idproduct, c.nama, c.harga, c.stock, c.idcategory);
                    }
                    if (count >= 1)
                    {
                        produk.Remove(c);
                        produk.Add(new Product(c.nama.Substring(0, 1) + "00" + check, c.nama, c.harga, c.stock, c.idcategory));
                        dtProdukSimpan.Rows.Add(c.nama.Substring(0, 1) + "00" + check, c.nama, c.harga, c.stock, c.idcategory);
                    }

                }


            }
        }

        private void button_EditProduct_Click(object sender, EventArgs e)
        {
            string name = textBox_Nama_Details.Text;
            string forCategory = comboBox_Category_Details.Text;
            string inttakers = "";

            dtProdukSimpan.Rows.Clear();
            int counting = 0;
            foreach (Category a in kategori.ToList())
            {
                if (a.nama == forCategory)
                {
                    inttakers = a.id.Substring(1, 1);
                }
            }
            foreach (Product a in produk.ToList())
            {
                counting = 0;
                if (a.nama == forCategory)
                {

                    counting++;
                    produk.Remove(a);

                }
                if (counting > 0)
                {

                    produk.Add(new Product(a.idproduct, a.nama, textBox_Harga.Text, textBox_Stock.Text, "C" + inttakers));

                }
            }
            foreach (Product h in produk.ToList())
            {


                dtProdukSimpan.Rows.Add(h.idproduct, h.nama, h.harga, h.stock, h.idcategory);
            }
        }

        private void button_RemoveProduct_Click(object sender, EventArgs e)
        {
            if (comboBox_Filter.Text == string.Empty)
            {
                int a = dataGridView1.CurrentCell.RowIndex;
                string productname = dataGridView1.Rows[a].Cells[1].Value.ToString();
                dtProdukSimpan.Rows[a].Delete();
                produk.RemoveAt(a);
                textBox_Nama_Details.Text = "";
                textBox_Harga.Text = "";
                textBox_Stock.Text = "";
                comboBox_Category_Details.Text = "";
            }
            if (comboBox_Filter.Text != "")
            {

                dtProdukSimpan.Rows.Clear();
                foreach (Category cat in kategori)
                {

                    if (cat.nama == comboBox_Filter.Text)
                    {
                        foreach (Product a in produk.ToList())
                        {
                            if (a.nama == textBox_Nama_Details.Text)
                            {
                                produk.Remove(a);
                            }
                            if (a.nama != textBox_Nama_Details.Text)
                            {
                                dtProdukSimpan.Rows.Add(a.idproduct, a.nama, a.harga, a.idproduct, a.idcategory);
                            }
                        }

                    }
                    comboBox_Filter.Text = "";

                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int a = dataGridView1.CurrentCell.RowIndex;
            textBox_Nama_Details.Text = dataGridView1.Rows[a].Cells[1].Value.ToString();
            textBox_Harga.Text = dataGridView1.Rows[a].Cells[2].Value.ToString();
            textBox_Stock.Text = dataGridView1.Rows[a].Cells[3].Value.ToString();
            string kodecategory = dataGridView1.Rows[a].Cells[4].Value.ToString();
            string forID = kodecategory.Substring(1, 1); 
            foreach (Category b in kategori.ToList())
            {
                if (b.id.Substring(1, 1) == forID)
                {
                    comboBox_Category_Details.Text = b.nama;
                }
            }
        }
    }
}