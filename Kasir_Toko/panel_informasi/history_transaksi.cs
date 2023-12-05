using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir_Toko.panel_informasi
{
    internal class history_transaksi
    {
        public DateTime date_transaksi { get; set; }
        public int total_harga { get; set; }
        public int total_barang { get; set;}

        public history_transaksi(DateTime date_transaksi, int total_harga, int total_barang)
        {
            this.date_transaksi = date_transaksi;
            this.total_harga = total_harga;
            this.total_barang = total_barang;
        }
    }
}
