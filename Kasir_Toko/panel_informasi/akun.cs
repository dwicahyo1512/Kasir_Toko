using MySql.Data.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir_Toko.panel_informasi
{
    internal class akun
    {
        public string kasir_nama { get; set; }
        public string password { get; set; }
        public string email {  get; set; }
        public string telepon { get; set; }
        public string tgl_lahir { get; set;}

        public akun(string kasir_nama, string password, string email, string telepon, string tgl_lahir)
        {
            this.kasir_nama = kasir_nama;
            this.password = password;
            this.email = email;
            this.telepon = telepon;
            this.tgl_lahir = tgl_lahir;
        }
    }
}
