using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir_Toko.panel_informasi
{
    internal class kasir
    {
        public string barang_id { get; set; }
        public string barang_nama { get; set; }
        public string barang_total { get; set; }

        public kasir(string barang_id, string barang_nama, string barang_total)
        {
            this.barang_id = barang_id;
            this.barang_nama = barang_nama;
            this.barang_total = barang_total;
        }
    }
}
