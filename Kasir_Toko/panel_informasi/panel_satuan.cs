using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kasir_Toko.panel_informasi
{
    public partial class panel_satuan : Form
    {
        public string Id_satuan;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        int i = 0;

        dbconnection dbconn = new dbconnection();

        public panel_satuan()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconn.dbconnect());
        }
        private void panel_satuan_Load(object sender, EventArgs e)
        {
            loadRecord();
        }
        public void loadRecord()
        {
           dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT satuan_id, satuan_nama, satuan_ket FROM satuan", conn);
            dr=cmd.ExecuteReader(); 
            while(dr.Read()) {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["satuan_id"].ToString(), dr["satuan_nama"].ToString(), dr["satuan_ket"].ToString());
            }
            dr.Close();
            conn.Close();
        }
        
        public void clear()
        {
            satuan_nama.Clear();
            satuan_keterangan.Clear();
        }
        private void Create_button_Click(object sender, EventArgs e)
        {
            if ((satuan_nama.Text == string.Empty) || (satuan_keterangan.Text == string.Empty)){
                MessageBox.Show("Warning : Isi form satuan", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            } else
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO satuan (satuan_id, satuan_nama, satuan_ket) VALUES(NULL,@satuan_nama, @satuan_keterangan)", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@satuan_nama", satuan_nama.Text);
                cmd.Parameters.AddWithValue("@satuan_keterangan", satuan_keterangan.Text);

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Berhasil di save!", "CRUD",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tidak Berhasil di save!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                conn.Close();
                loadRecord();
                clear();
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("UPDATE satuan SET `satuan_nama` =@satuan_nama, `satuan_ket` =@satuan_keterangan WHERE satuan_id =@id", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@satuan_nama", satuan_nama.Text);
            cmd.Parameters.AddWithValue("@satuan_keterangan", satuan_keterangan.Text);
            cmd.Parameters.AddWithValue("@id",Id_satuan);

            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Berhasil di Update!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tidak Berhasil di Update!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn.Close();
            loadRecord();
            clear();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new MySqlCommand("Delete from satuan WHERE satuan_id=@id", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id",Id_satuan);


            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Berhasil di Hapus!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Tidak Berhasil di Hapus!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            conn.Close();
            loadRecord();
            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_satuan = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            satuan_nama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            satuan_keterangan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Search_tabel_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT satuan_id, satuan_nama, satuan_ket FROM satuan WHERE satuan_nama like '%" + satuan_nama.Text +  "%' or satuan_keterangan like '%" + satuan_keterangan.Text + "%' ", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["satuan_nama"].ToString(), dr["satuan_ket"].ToString());
            }
            dr.Close();
            conn.Close();
        }
    }
}
