using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir_Toko.panel_informasi
{
    internal class barang
    {
        public string satuan { get; set; }
        public string kategori { get; set; }
        public string barang_nama {  get; set; }
        public string harga_barang { get; set; }
        public string stok_barang { get; set;}
        public string barang_keterangan { get; set;}

        public barang(string satuan, string kategori, string barang_nama, string harga_barang, string stok_barang, string barang_keterangan)
        {
            this.satuan = satuan;
            this.kategori = kategori;
            this.barang_nama = barang_nama;
            this.harga_barang = harga_barang;
            this.stok_barang = stok_barang;
            this.barang_keterangan = barang_keterangan;
        }
    }
}
