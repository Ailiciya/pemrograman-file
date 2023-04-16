using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Mahasiswa
    {
        // field
        public string nama;
        public string nim;
        public string asal;

        //constructor
        public Mahasiswa(string nama, string nim, string asal) 
        {
        this.nama = nama;
        this.nim = nim;
        this.asal = asal;
        }

        public Mahasiswa()
        {

        }
        
        //method
        public void SetMahasiswa(string nama, string nim)
        {
            this.nama = nama;
            this.nim = nim;
            Console.WriteLine("nama mahasiswa : (0)", this.nama);
            Console.WriteLine("nama mahasiswa : (0)", this.nim);
            Console.ReadKey();
        }

        public void SetAsal(string setAsal)
        {
            this.asal = asal;
            Console.WriteLine("asal mahasiswa dari : {0}", this.asal);
            Console.ReadKey();
        }
    }
}
