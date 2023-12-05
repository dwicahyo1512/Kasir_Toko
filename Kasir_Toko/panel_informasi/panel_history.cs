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
    public partial class panel_history : Form
    {
        view_history form;
        public panel_history()
        {
            InitializeComponent();
            form = new view_history(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void Display()
        {
            DbKasir.DisplayAndSearch("SELECT total_transaksi_id, date_transaksi, total_harga, total_barang FROM total_transaksi", dataGridView1);

        }

        private void panel_history_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int searchValue))
            {
                // Gunakan nilai searchValue dalam kueri SQL
                DbKasir.DisplayAndSearch("SELECT total_transaksi_id, date_transaksi, total_harga, total_barang FROM total_transaksi WHERE total_harga LIKE '%" + searchValue + "%'  OR total_barang LIKE '%" + searchValue + "%' ", dataGridView1);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //edit
                form.id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.date = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.total_harga = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.total_barang = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                //delete
                if (MessageBox.Show("apakah kamu yakin mau menghapus data ini?", "information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbKasir.DeleteHistory(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
