using Kasir_Toko.panel_informasi;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akun_Toko.panel_informasi
{
    internal class DbDataAkun
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=kasir_toko";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Mysql Connection! \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }

        public static void AddAkun(akun std)
        {
            string sql = "INSERT INTO kasir VALUES (null,@akun_nama, @password, @email, @telepon, @tgl_lahir, null)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@akun_nama", MySqlDbType.VarChar).Value = std.kasir_nama;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = std.password;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = std.email;
            cmd.Parameters.Add("@telepon", MySqlDbType.VarChar).Value = std.telepon;
            cmd.Parameters.Add("@tgl_lahir", MySqlDbType.VarChar).Value = std.tgl_lahir;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menambah Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("akun tidak Dimasukkan \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void UpdateAkun(akun std,string id)
        {
            string sql = "UPDATE kasir SET kasir_nama=@nama, password=@password, email=@email, telepon=@telepon, tgl_lahir=@tgl_lahir WHERE kasir_id=@kasir_id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@kasir_id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = std.kasir_nama;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = std.password;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = std.email;
            cmd.Parameters.Add("@telepon", MySqlDbType.VarChar).Value = std.telepon;
            cmd.Parameters.Add("@tgl_lahir", MySqlDbType.VarChar).Value = std.tgl_lahir;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("update tidak berhasil \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeletekAkun(string id)
        {
            string sql = "DELETE FROM kasir WHERE kasir_id = @kasir_id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@kasir_id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil menghapus data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal menghapus data! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();
        }
        public static void LoadComboBox(string query, string namaTabel, string displayItem, ComboBox cmb)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();

            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, namaTabel);
            cmb.DisplayMember = displayItem;
            cmb.ValueMember = displayItem;
            cmb.DataSource = dataSet.Tables[namaTabel];

            conn.Close();
        }
    }
}
