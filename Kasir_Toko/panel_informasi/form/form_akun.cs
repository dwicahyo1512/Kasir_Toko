using akun_Toko.panel_informasi;
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
    public partial class form_akun : Form
    {
        private readonly panel_akun_kasir _parent;
        public string id, nama, password, email, telepon, tgl_lahir;

       

        private void clear_button_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public form_akun(panel_akun_kasir parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public void UpdateInfo()
        {
            btnsave.Text = "Update";
            nama_box.Text = nama;
            password_box.Text = password;
            email_box.Text = email;
            box_telepon.Text = telepon;
            dateTimePicker1.Text = tgl_lahir;
        }
        public void SaveInfo()
        {
            btnsave.Text = "Save";
        }
        public void Clear()
        {
            nama_box.Text = box_telepon.Text = password_box.Text = email_box.Text = dateTimePicker1.Text = string.Empty;
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            //create
            if (nama_box.Text.Trim().Length < 3)
            {
                MessageBox.Show("Nama tidak boleh kosong ( huruf harus lebih 3 Huruf) ");
                return;
            }
            if (password_box.Text.Trim().Length == 0)
            {
                MessageBox.Show("Password tidak boleh kosong");
                return;
            }
            if (email_box.Text.Trim().Length == 0)
            {
                MessageBox.Show("email tidak boleh kosong");
                return;
            }
            if (btnsave.Text == "Save")
            {
                akun std = new akun(nama_box.Text.Trim(), password_box.Text.Trim(),email_box.Text.Trim(),box_telepon.Text.Trim(),dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                DbDataAkun.AddAkun(std);
                Clear();
            }
            if (btnsave.Text == "Update")
            {
                akun std = new akun(nama_box.Text.Trim(), password_box.Text.Trim(), email_box.Text.Trim(), box_telepon.Text.Trim(), dateTimePicker1.Value.ToString("yyyy/MM/dd"));
                DbDataAkun.UpdateAkun(std, id);
            }
            _parent.Display();
        }
    }
}
