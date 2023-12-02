using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kasir_Toko.panel_informasi
{
    public partial class panel_kategori : Form
    {
        public string Id_kategori;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader dr;
        int i = 0;

        dbconnection dbconn = new dbconnection();

        public panel_kategori()
        {
            InitializeComponent();
            conn = new MySqlConnection(dbconn.dbconnect());
        }
        private void panel_kategori_Load(object sender, EventArgs e)
        {
            loadRecord();
        }
        public void loadRecord()
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT kategori_id, kategori_nama, kategori_ket FROM kategori", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["kategori_id"].ToString(), dr["kategori_nama"].ToString(), dr["kategori_ket"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        public void clear()
        {
            kategori_nama.Clear();
            kategori_keterangan.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //create
            if ((kategori_nama.Text == string.Empty) || (kategori_keterangan.Text == string.Empty))
            {
                MessageBox.Show("Warning : Isi form kategori", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            else
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO kategori (kategori_id, kategori_nama, kategori_ket) VALUES(NULL,@kategori_nama, @kategori_keterangan)", conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@kategori_nama", kategori_nama.Text);
                cmd.Parameters.AddWithValue("@kategori_keterangan", kategori_keterangan.Text);

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Berhasil di save!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button10_Click(object sender, EventArgs e)
        {
            //update
            conn.Open();
            cmd = new MySqlCommand("UPDATE kategori SET `kategori_nama` =@kategori_nama, `kategori_ket` =@kategori_keterangan WHERE kategori_id =@id", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@kategori_nama", kategori_nama.Text);
            cmd.Parameters.AddWithValue("@kategori_keterangan", kategori_keterangan.Text);
            cmd.Parameters.AddWithValue("@id", Id_kategori);

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

        private void button8_Click(object sender, EventArgs e)
        {
            //delete
            conn.Open();
            cmd = new MySqlCommand("Delete from kategori WHERE kategori_id=@id", conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", Id_kategori);


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


        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Id_kategori = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            kategori_nama.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            kategori_keterangan.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Search_tabel_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new MySqlCommand("SELECT kategori_id, kategori_nama, kategori_ket FROM kategori WHERE  kategori_id like '%" + Search_tabel.Text + "%' or kategori_nama like '%" + Search_tabel.Text + "%' or kategori_ket like '%" + Search_tabel.Text + "%' ", conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["kategori_id"].ToString(), dr["kategori_nama"].ToString(), dr["kategori_ket"].ToString());
            }
            dr.Close();
            conn.Close();
        }


    }
    }
