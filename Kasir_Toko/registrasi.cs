using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kasir_Toko
{
    public partial class registrasi : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public registrasi()
        {
            InitializeComponent();
        }

        private void nama_login_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void create_registrasi_Click(object sender, EventArgs e)
        {
            if (!this.email_registrasi.Text.Contains('@') || !this.email_registrasi.Text.Contains('.'))
            {
                MessageBox.Show("Masukkan email yang valid", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password_registrasi.Text != confirm_password.Text)
            {
                MessageBox.Show("Password Tidak sama", "Error");
                return;
            }

            if (string.IsNullOrEmpty(nama_registrasi.Text) || string.IsNullOrEmpty(telepon_registrasi.Text) || string.IsNullOrEmpty(email_registrasi.Text) || string.IsNullOrEmpty(confirm_password.Text))
            {
                MessageBox.Show("Lengkapi form dengan benar!", "Error");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM Kasir_Toko.kasir WHERE kasir_nama = @nama", connection),
                cmd2 = new MySqlCommand("SELECT * FROM Kasir_Toko.kasir WHERE email = @UserEmail", connection);


                cmd1.Parameters.AddWithValue("@nama", nama_registrasi.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", email_registrasi.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Nama sudah digunakan!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email sudah digunakan!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO Kasir_Toko.kasir(`kasir_id`,`kasir_nama`,`tgl_lahir`,`email`,`telepon`, `password`) VALUES (NULL, '" + nama_registrasi.Text + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "', '" + email_registrasi.Text + "','" + telepon_registrasi.Text + "','" + password_registrasi.Text + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");

                }

                connection.Close();
            }
        }

        private void back_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm4 = new login();
            frm4.ShowDialog();
        }
    }
}
