using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kasir_Toko.panel_informasi.form
{
    public partial class form_kasir : Form
    {
        private readonly panel_kasir _parent;
        public string id,barang,total_barang;
        public form_kasir(panel_kasir parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void form_kasir_Load(object sender, EventArgs e)
        {
            DbKasir.LoadComboBox("SELECT * FROM barang", "barang", "barang_id" ,"barang_nama", comboBox1);
            comboBox1.Text = barang;
        }
        public void UpdateInfo()
        {
            btnsave.Text = "Update";
            comboBox1.SelectedItem = barang;
            textBox1.Text = total_barang;
            autoFill();
        }
        public void autoFill()
        {
            if (comboBox1.SelectedItem != null)
            {
                DataRowView selectedDataRow = comboBox1.SelectedItem as DataRowView;
                string stok_barang = selectedDataRow.Row["stok_barang"].ToString(); // Ganti "nama_kolom" dengan nama kolom yang ingin kamu akses
                string satuan = selectedDataRow.Row["satuan_nama"].ToString();
                string kategori = selectedDataRow.Row["kategori_nama"].ToString();
                string nama_barang = selectedDataRow.Row["barang_nama"].ToString();
                string harga_barang = selectedDataRow.Row["harga_barang"].ToString();
                // Mengatur nilai TextBox berdasarkan pilihan ComboBox
                Stok_tersedia.Text = stok_barang;
                textBox_satuan.Text = satuan;
                textBox_kategori.Text = kategori;
                textBoxnama_barang.Text = nama_barang;
                textBoxharga_barang.Text = harga_barang;
            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            autoFill();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            autoFill();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
           (int.TryParse(textBox1.Text, out int nilai) && nilai == 0))
            {
                MessageBox.Show("stok Barang tidak boleh kosong atau Nilainya 0");
                return;
            }
            int nilaiTextBox;
            if (int.TryParse(textBox1.Text, out nilaiTextBox))
            {
                if (comboBox1.SelectedItem != null)
                {
                    DataRowView selectedDataRow = comboBox1.SelectedItem as DataRowView;
                    if (selectedDataRow != null && selectedDataRow.Row != null)
                    {
                        // Pastikan untuk mengakses properti Row sebelum mengambil nilai "stok_barang"
                        int stokBarangDariDatabase = Convert.ToInt32(selectedDataRow.Row["stok_barang"]);
                        if (stokBarangDariDatabase < nilaiTextBox)
                        {
                            MessageBox.Show("Stok barang tidak Boleh Melebihi total stok barang.");
                            return;
                        }
                    }
                }
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Barang Tidak Boleh Kosong(Harap memilih Barang)");
                return;
            }
            if (btnsave.Text == "Save")
            {
                if (comboBox1.SelectedItem != null && comboBox1.SelectedItem is DataRowView selectedDataRow)
                {
                    string barangID = selectedDataRow["barang_id"].ToString();
                    string stokBarang = textBox1.Text.Trim();
                    int stokBarangInt;

                    if (!int.TryParse(stokBarang, out stokBarangInt))
                    {
                        MessageBox.Show("Stok Barang harus berupa angka");
                        return;
                    }

                    kasir std = new kasir(barangID, comboBox1.Text.Trim(), stokBarang);
                    DbKasir.Addkasir(std);
                    Clear();
                    DbKasir.LoadComboBox("SELECT * FROM barang", "barang", "barang_id", "barang_nama", comboBox1);
                    comboBox1.Text = barang;
                }
            }
            if (btnsave.Text == "Update")
            {
                if (comboBox1.SelectedItem != null && comboBox1.SelectedItem is DataRowView selectedDataRow)
                {
                    string barangID = selectedDataRow["barang_id"].ToString();
                    string stokBarang = textBox1.Text.Trim();
                    int stokBarangInt;

                    if (!int.TryParse(stokBarang, out stokBarangInt))
                    {
                        MessageBox.Show("Stok Barang harus berupa angka");
                        return;
                    }

                    kasir std = new kasir(barangID, comboBox1.Text.Trim(), stokBarang);
                   
                    DbKasir.Updatekasir(std, id, total_barang);

                }
            }
            _parent.Display();
        }

      

        public void SaveInfo()
        {
            btnsave.Text = "Save";
        }
        public void Clear()
        {
            comboBox1.Text = textBox1.Text = textBox_satuan.Text = textBox_kategori.Text = textBoxnama_barang.Text = textBoxharga_barang.Text = Stok_tersedia.Text = string.Empty;
        }
    }
}
