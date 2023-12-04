using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir_Toko.panel_informasi
{
    internal class Transaksi
    {
        public string total_barang { get; set; }
        public string total_harga { get; set; }

        public Transaksi(string total_barang, string total_harga)
        {
            this.total_barang = total_barang;
            this.total_harga = total_harga;
        }
    }
}
