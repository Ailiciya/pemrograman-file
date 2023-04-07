using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDanObject
{
    internal class Mahasiswa1
    {
        static void Main(string[] args)
        {
            Mahasiswa mahasiswa1 = new Mahasiswa();
            Mahasiswa mahasiswa2 = new Mahasiswa();

            mahasiswa1.NAMA = "Kevin";
            mahasiswa1.NIM = "22.11.4870";
            mahasiswa1.IPK = 3.7f;

            mahasiswa1.Registrasi();

            mahasiswa2.NAMA = "Kevin";
            mahasiswa2.IsiKrs();

        }

      
    }
}
