using akun_Toko.panel_informasi;
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
    public partial class panel_akun_kasir : Form
    {
        form_akun form;
        public panel_akun_kasir()
        {
            InitializeComponent();
            form = new form_akun(this);
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.nama = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.password = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.email = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.telepon = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.tgl_lahir = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
                if (MessageBox.Show("apakah kamu yakin mau menghapus data ini?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbDataAkun.DeletekAkun(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
        public void Display()
        {
            DbDataAkun.DisplayAndSearch("SELECT kasir_id, kasir_nama, password, email, telepon, tgl_lahir, LastLogin FROM kasir", dataGridView);
        }
        private void add_barang_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void panel_akun_kasir_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void Search_tabel_TextChanged(object sender, EventArgs e)
        {
            DbDataAkun.DisplayAndSearch("SELECT kasir_id, kasir_nama, password, email, telepon, tgl_lahir, LastLogin FROM kasir WHERE kasir_nama LIKE '%" + Search_tabel.Text + "%'", dataGridView);
        }
    }
}
