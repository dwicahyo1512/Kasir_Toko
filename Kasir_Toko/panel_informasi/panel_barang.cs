using Kasir_Toko.panel_informasi.form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_Toko.panel_informasi
{
    public partial class panel_barang : Form
    {
        public panel_barang()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void Display()
        {
           DbBarang.DisplayAndSearch("SELECT barang_id, kategori_id, satuan_id, barang_nama, stok_barang, harga_barang, barang_ket FROM barang", dataGridView);
        }
        private void add_barang_Click(object sender, EventArgs e)
        {
            form_barang form = new form_barang(this);
            form.ShowDialog();
        }

        private void panel_barang_Shown(object sender, EventArgs e)
        {
            Display();
        }

   
    }
}
