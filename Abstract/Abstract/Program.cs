using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hewan ayam = new Ayam();
            Hewan kucing = new Kucing();

            ayam.jenisHewan = "ayam";
            ayam.jmlKaki = 2;

            kucing.jenisHewan = "kucing";
            kucing.jmlKaki = 4;

            
            Console.WriteLine("Pilih jenis hewan yang dimaksud [1...2]");
            Console.WriteLine("1. Ayam");
            Console.WriteLine("2. Kucing");
            Console.WriteLine("Masukkan pilihan anda");
            int pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("============================");

            //pengkondisikan

            if (pilih == 1)
                ayam.bersuara();
            else if (pilih == 2)
                kucing.bersuara();
            else
                Console.WriteLine("Nomor yang kamu pilih tidak valid, anda memilih nomor {0} \nTidak ada pada jenis hewan", pilih);
        }
    }
}