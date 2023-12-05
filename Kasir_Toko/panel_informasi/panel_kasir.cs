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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kasir_Toko.panel_informasi
{
    public partial class panel_kasir : Form
    {
        form_kasir form;
        public panel_kasir()
        {
            InitializeComponent();
            form = new form_kasir(this);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Display()
        {
            DbKasir.DisplayAndSearch("SELECT transaksi.transaksi_id,transaksi.barang_id,barang.satuan_nama,barang.kategori_nama , barang.barang_nama,barang.harga_barang,transaksi.barang_total  ,barang.barang_ket FROM transaksi JOIN barang ON transaksi.barang_id = barang.barang_id WHERE transaksi.total_transaksi_id is null ", dataGridView);
            int totalBarang = 0;
            int totalHarga = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[8].Value != null && row.Cells[8].Value != DBNull.Value)
                {
                    int nilaiKolom = 0;
                    if (int.TryParse(row.Cells[8].Value.ToString(), out nilaiKolom))
                    {
                        totalBarang += nilaiKolom;

                        // Mengakses harga barang dari kolom tertentu (misalnya, kolom 9)
                        if (row.Cells[7].Value != null && row.Cells[7].Value != DBNull.Value)
                        {
                            int hargaBarang = 0;
                            if (int.TryParse(row.Cells[7].Value.ToString(), out hargaBarang))
                            {
                                totalHarga += nilaiKolom * hargaBarang;
                            }
                        }
                    }
                }
            }

            Boxtotal_barang.Text = totalBarang.ToString();
            textBox_total_harga.Text = totalHarga.ToString();
        }
        public void DisplayTotal_Harga()
        {
        
        }
        private void panel_kasir_Shown(object sender, EventArgs e)
        {
            Display();
        }
        private void Add_barang_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void Search_tabel_TextChanged(object sender, EventArgs e)
        {
            DbKasir.DisplayAndSearch("SELECT transaksi.transaksi_id,transaksi.barang_id, barang.satuan_nama, barang.kategori_nama, barang.barang_nama, barang.harga_barang, transaksi.barang_total, barang.barang_ket FROM transaksi JOIN barang ON transaksi.barang_id = barang.barang_id WHERE transaksi.total_transaksi_id IS NULL AND barang.barang_nama LIKE '%" + Search_tabel.Text + "%'", dataGridView);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.barang = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.total_barang = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
                if (MessageBox.Show("apakah kamu yakin mau menghapus data ini?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbKasir.Deletekasir(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString(), dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString(), dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString());
                    Display();
                }
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //transaksi
            Transaksi std = new Transaksi(Boxtotal_barang.Text.Trim(), textBox_total_harga.Text.Trim());
            DbKasir.AddTransaksi(std);
            Display();
        }
    }
}
