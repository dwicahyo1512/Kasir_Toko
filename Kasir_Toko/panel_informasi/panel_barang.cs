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
        form_barang form;

        public panel_barang()
        {
            InitializeComponent();
            form = new form_barang(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void Display()
        {
           DbBarang.DisplayAndSearch("SELECT barang_id,satuan_nama, kategori_nama, barang_nama,harga_barang ,stok_barang , barang_ket FROM barang", dataGridView);
        }
        private void add_barang_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void panel_barang_Shown(object sender, EventArgs e)
        {
            Display();
            
        }

        private void Search_tabel_TextChanged(object sender, EventArgs e)
        {
            DbBarang.DisplayAndSearch("SELECT barang_id,satuan_nama, kategori_nama, barang_nama,harga_barang ,stok_barang , barang_ket FROM barang WHERE barang_nama LIKE '%"+ Search_tabel.Text +"%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                //edit
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.satuan = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.kategori = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.nama = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.harga = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.stok = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.keterangan = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if(e.ColumnIndex == 1)
            {
                //delete
                if(MessageBox.Show("apakah kamu yakin mau menghapus data ini?", "information",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information) == DialogResult.Yes){
                    DbBarang.DeleteBarang(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
