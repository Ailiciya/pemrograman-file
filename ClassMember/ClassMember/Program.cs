using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember
{
    internal class Program
    {
        internal class Program1
        {
            static void Main(string[] args)
            {
                Mahasiswa mahasiswa1 = new Mahasiswa();
                mahasiswa1.Nama = "Kevin";
                mahasiswa1.Nim = "22.11.4870";
                mahasiswa1.Jurusan = "Informatika";
                mahasiswa1.Ipk = 4.1f;
                mahasiswa1.InfoMahasiswa();
                Console.ReadLine();
            }
        }
    }
}
