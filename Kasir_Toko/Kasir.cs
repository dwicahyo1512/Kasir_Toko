using Kasir_Toko.panel_informasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_Toko
{
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm1 = new login();
            frm1.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void Satuan_Click(object sender, EventArgs e)
        {
            loadform(new panel_satuan());
        }

        private void kategori_Click(object sender, EventArgs e)
        {
            loadform(new panel_kategori());
        }

        private void barang_Click(object sender, EventArgs e)
        {
            loadform(new panel_barang());
        }

        private void kasir_count_Click(object sender, EventArgs e)
        {
            loadform(new panel_kasir());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loadform(new panel_akun_kasir());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new panel_history());
        }
    }
}
