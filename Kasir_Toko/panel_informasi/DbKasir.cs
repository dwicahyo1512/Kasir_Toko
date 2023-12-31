﻿using Kasir_Toko.panel_informasi.form;
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
    internal class DbKasir
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

        public static void Addkasir(kasir std)
        {
            string sql = "INSERT INTO transaksi VALUES (Null, @barang_id, Null, @barang_nama, @barang_total)";
            string sql2 = "UPDATE barang SET stok_barang = stok_barang - @barang_total_update WHERE barang_id = @barang_id_update";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@barang_id", MySqlDbType.VarChar).Value = std.barang_id;
            cmd.Parameters.Add("@barang_nama", MySqlDbType.VarChar).Value = std.barang_nama;
            cmd.Parameters.Add("@barang_total", MySqlDbType.Int64).Value = std.barang_total;
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.Parameters.Add("@barang_total_update", MySqlDbType.Int64).Value = std.barang_total;
            cmd2.Parameters.Add("@barang_id_update", MySqlDbType.VarChar).Value = std.barang_id;
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Berhasil Menambah Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("kasir tidak Dimasukkan \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void Updatekasir(kasir std,string id, string total_box)
        {
            string sql = "UPDATE transaksi SET barang_id=@barang_id, total_transaksi_id=null, barang_nama=@barang_nama, barang_total=@barang_total WHERE transaksi_id=@transaksi_id";
            string sql2 = "UPDATE barang SET stok_barang = stok_barang + @barang_total_box - @barang_total_update WHERE barang_id = @barang_id_update";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@transaksi_id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@barang_id", MySqlDbType.VarChar).Value = std.barang_id;
            cmd.Parameters.Add("@barang_nama", MySqlDbType.VarChar).Value = std.barang_nama;
            cmd.Parameters.Add("@barang_total", MySqlDbType.Int64).Value = std.barang_total;
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.Parameters.Add("@barang_total_update", MySqlDbType.Int64).Value = std.barang_total;
            cmd2.Parameters.Add("@barang_id_update", MySqlDbType.VarChar).Value = std.barang_id;
            cmd2.Parameters.Add("@barang_total_box", MySqlDbType.VarChar).Value = total_box;
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Berhasil Update Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("update tidak berhasil \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        public static void Deletekasir(string id, string id_barang, string total)
        {
            string sql = "DELETE FROM transaksi WHERE transaksi_id = @transaksi_id";
            string sql2 = "UPDATE barang SET stok_barang = stok_barang +@barang_total_update WHERE barang_id = @barang_id_update";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@transaksi_id", MySqlDbType.VarChar).Value = id;
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            cmd2.Parameters.Add("@barang_total_update", MySqlDbType.Int64).Value = total;
            cmd2.Parameters.Add("@barang_id_update", MySqlDbType.VarChar).Value = id_barang;
            try
            {
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Berhasil menghapus data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal menghapus data! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        public static void AddTransaksi(Transaksi std)
        {
            string sqlInsert = "INSERT INTO total_transaksi (total_harga, total_barang) VALUES (@total_harga, @total_barang);";
            string sqlUpdate = "UPDATE transaksi SET total_transaksi_id = (SELECT LAST_INSERT_ID()) WHERE total_transaksi_id IS NULL;";

            MySqlConnection conn = GetConnection();
            MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conn);
            cmdInsert.Parameters.Add("@total_harga", MySqlDbType.VarChar).Value = std.total_harga;
            cmdInsert.Parameters.Add("@total_barang", MySqlDbType.VarChar).Value = std.total_barang;
            MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);

            try
            {
                cmdInsert.ExecuteNonQuery(); // Jalankan operasi INSERT
                cmdUpdate.ExecuteNonQuery(); // Jalankan operasi UPDATE
                MessageBox.Show($"harga Barang: {std.total_harga} \n jumlah barang: {std.total_barang} \n telah berhasil ditambahkan ke transaksi. Transaksi telah diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Transaksi tidak Dimasukkan \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        public static void DeleteHistory(string id)
        {
            string sql = "DELETE FROM total_transaksi WHERE total_transaksi_id=@transaksi_total";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@transaksi_total", MySqlDbType.VarChar).Value = id;
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
        public static void LoadComboBox(string query, string namaTabel, string id, string displayItem, ComboBox cmb)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();

            MySqlDataAdapter adp = new MySqlDataAdapter(sql, conn);
            DataSet dataSet = new DataSet();
            adp.Fill(dataSet, namaTabel);
            cmb.DisplayMember = displayItem;
            cmb.ValueMember = id;
            cmb.DataSource = dataSet.Tables[namaTabel];

            conn.Close();
        }
    }
}
