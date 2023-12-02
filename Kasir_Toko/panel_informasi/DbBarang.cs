using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir_Toko.panel_informasi
{
    internal class DbBarang
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

        public static void AddBarang(barang std)
        {
            string sql = "INSERT INTO barang VALUES (Null, Null, Null, @barang_nama, @stok_barang, @harga_barang, @barang_ket, @satuan_nama, @kategori_nama, Null)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@satuan_nama", MySqlDbType.VarChar).Value = std.satuan;
            cmd.Parameters.Add("@kategori_nama", MySqlDbType.VarChar).Value = std.kategori;
            cmd.Parameters.Add("@barang_nama", MySqlDbType.VarChar).Value = std.barang_nama;
            cmd.Parameters.Add("@stok_barang", MySqlDbType.VarChar).Value = std.stok_barang;
            cmd.Parameters.Add("@harga_barang", MySqlDbType.VarChar).Value = std.harga_barang;
            cmd.Parameters.Add("@barang_ket", MySqlDbType.VarChar).Value = std.barang_keterangan;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menambah Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Barang tidak Dimasukkan \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void UpdateBarang(barang std,string id)
        {
            string sql = "UPDATE barang SET kategori_id=@kategori_id, satuan_id=@satuan_id, barang_nama=@barang_nama, stok_barang=@stok_barang, harga_barang=@harga_barang, barang_ket=@barang_ket WHERE barang_id = @barang_id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@kategori_id", MySqlDbType.VarChar).Value = std.kategori;
            cmd.Parameters.Add("@satuan_id", MySqlDbType.VarChar).Value = std.satuan;
            cmd.Parameters.Add("@barang_nama", MySqlDbType.VarChar).Value = std.barang_nama;
            cmd.Parameters.Add("@stok_barang", MySqlDbType.VarChar).Value = std.stok_barang;
            cmd.Parameters.Add("@harga_barang", MySqlDbType.VarChar).Value = std.harga_barang;
            cmd.Parameters.Add("@barang_ket", MySqlDbType.VarChar).Value = std.barang_keterangan;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("update tidak berhasil \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void DeleteBarang(string id)
        {
            string sql = "DELETE FROM barang WHERE barang_id = @barang_id";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@barang_id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil menghapus data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
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
            //dgv.DataSource = tbl;
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
