using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class BMW
    {
        private string Namamodel;
        private string warna;
        private int harga;
        private static int jumlahMobil = 0;

        public BMW(string namamodel, string warna, int harga)
        {
            Namamodel = namamodel;
            this.warna = warna;
            this.harga = harga;
            jumlahMobil++;
        }

        public string getNamamodel()
        {
            return Namamodel;
        }

        public string getwarna()
        {
            return warna;
        }

        public int getHarga()
        {
            return harga;
        }

        public static int getJumlahMobil()
        {
            return jumlahMobil;
        }
    }
}
