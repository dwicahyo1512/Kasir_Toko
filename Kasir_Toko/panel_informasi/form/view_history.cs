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
    public partial class view_history : Form
    {
        private readonly panel_history _parent;
        public string id, date, total_harga, total_barang;

        private void view_history_Shown(object sender, EventArgs e)
        {
            Display();
            textBox1.Text = date;
        }

     

        private void Search_tabel_TextChanged(object sender, EventArgs e)
        {
            DbBarang.DisplayAndSearch("SELECT transaksi.transaksi_id, transaksi.barang_id, barang.satuan_nama, barang.kategori_nama, barang.barang_nama, barang.harga_barang, transaksi.barang_total, barang.barang_ket FROM transaksi JOIN barang ON transaksi.barang_id = barang.barang_id WHERE transaksi.total_transaksi_id = " + id + "  AND barang.barang_nama LIKE '%" + Search_tabel.Text + "%' ", dataGridView);
        }

        public view_history(panel_history parent)
        {
            InitializeComponent();
            _parent = parent;
        }

   
        public void Display()
        {
            DbBarang.DisplayAndSearch("SELECT transaksi.transaksi_id,transaksi.barang_id,barang.satuan_nama,barang.kategori_nama , barang.barang_nama,barang.harga_barang,transaksi.barang_total  ,barang.barang_ket FROM transaksi JOIN barang ON transaksi.barang_id = barang.barang_id WHERE transaksi.total_transaksi_id = " + id + " ", dataGridView);
        }

    }
}
