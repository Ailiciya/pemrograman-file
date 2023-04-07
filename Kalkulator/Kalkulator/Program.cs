using System;

namespace AplikasiKalkulator
{
    class program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Selamat datang di Kalkulator Sederhana!");
            Console.WriteLine("-------------------------------------");

            Console.Write("Masukkan angka pertama: ");
            double angkaPertama = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan angka kedua: ");
            double angkaKedua = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Pilih operator:");
            Console.WriteLine("+ untuk penjumlahan");
            Console.WriteLine("- untuk pengurangan");
            Console.WriteLine("* untuk perkalian");
            Console.WriteLine("/ untuk pembagian");

            Console.Write("Masukkan operator yang dipilih: ");
            string operatorPilihan = Console.ReadLine();

            double hasil = 0;

            switch (operatorPilihan)
            {
                case "+":
                    hasil = angkaPertama + angkaKedua;
                    break;
                case "-":
                    hasil = angkaPertama - angkaKedua;
                    break;
                case "*":
                    hasil = angkaPertama * angkaKedua;
                    break;
                case "/":
                    if (angkaKedua == 0)
                    {
                        Console.WriteLine("Kesalahan: Tidak dapat membagi dengan nol!");
                        Environment.Exit(0);
                    }
                    hasil = angkaPertama / angkaKedua;
                    break;
                default:
                    Console.WriteLine("Kesalahan: Operator yang dimasukkan tidak valid!");
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hasil: " + hasil);
            Console.WriteLine("Tekan sembarang tombol untuk keluar.");
            Console.ReadKey();
        }
    }
}