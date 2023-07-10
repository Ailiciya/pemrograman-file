using ConsoleApp1;
using System;
using System.Collections.Generic;

namespace LathianList
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "4870";
            mhs1.NamaMahasiswa = "Kevin";

            // membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "48799";
            mhs2.NamaMahasiswa = "Kokomi";

            // membuat objek dosen
            Dosen dosen = new Dosen();
            dosen.NIk = "0043";
            dosen.NamaDosen = "Jhon Doe";

            // membuat objek list
            List<Mahasiswa> list = new List<Mahasiswa>();

            // menambahkan elemen List
            list.Add(mhs1);
            list.Add(mhs2);

            // Cetak header tabel
            Console.WriteLine("NIM\tNAMA");
            Console.WriteLine("==============");

            // Mengakses elemen list dan mencetak NIM dan Nama Mahasiswa
            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0}\t{1}", mhs.Nim, mhs.NamaMahasiswa);
            }
        }
    }
}
