using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_Toko.panel_informasi.form
{
    public partial class form_barang : Form
    {
        private readonly panel_barang _parent;
        public string id_barang, satuan, kategori;
        public form_barang(panel_barang parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {

        }
        private void form_barang_Load(object sender, EventArgs e)
        {
            DbBarang.LoadComboBox("SELECT * FROM satuan", "satuan", "satuan_nama", combo_satuan);
            DbBarang.LoadComboBox("SELECT * FROM kategori", "satuan", "kategori_nama", combo_kategori);
            combo_satuan.Text = satuan;
            combo_kategori.Text = kategori;
        }
        public void Clear()
        {
            combo_satuan.Text = combo_kategori.Text = nama_barang.Text = harga_barang.Text = stok_barang.Text = keterangan_barang.Text = string.Empty;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //create
            if (nama_barang.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nama tidak boleh kosong ( huruf harus lebih 3 Huruf) ");
                return;
            }
            if (harga_barang.Text.Trim().Length == 0)
            {
                MessageBox.Show("harga Barang tidak boleh kosong");
                return;
            }
            if (stok_barang.Text.Trim().Length == 0)
            {
                MessageBox.Show("stok Barang tidak boleh kosong");
                return;
            }
            if (btnsave.Text == "Save")
            {
                barang std = new barang(combo_satuan.Text.Trim(),combo_kategori.Text.Trim(),nama_barang.Text.Trim(),harga_barang.Text.Trim(), stok_barang.Text.Trim(),keterangan_barang.Text.Trim());
               DbBarang.AddBarang(std);
                Clear();
            }
            _parent.Display();
        }

       
    }
}
