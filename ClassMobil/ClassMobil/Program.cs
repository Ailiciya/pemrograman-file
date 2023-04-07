using System;

public class Mobil
{
    public string warna;
    public int jumlahPintu;
    public string merek;
    public string model;
    public int tahunKeluaran;
    public int kecepatan;
    public string suaraKlakson;

    public void Gas(int kecepatan)
    {
        this.kecepatan = kecepatan;
    }

    public void Klakson(string suara)
    {
        suaraKlakson = suara;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine("\nMobil saya berwarna {0}\nMerek {1}\nModel {2}\nKeluaran tahun {3}\nDengan jumlah pintu sebanyak {4}\nKecepatan {5}\nSuara klakson {6}", warna, merek, model, tahunKeluaran, jumlahPintu, kecepatan, suaraKlakson);
    }
}

public class Program
{
    public static void Main()
    {
        Mobil mobilSaya = new Mobil();

        Console.Write("\nMasukkan warna mobil kamu: ");
        mobilSaya.warna = Console.ReadLine();

        Console.Write("\nMasukkan merek mobil kamu: ");
        mobilSaya.merek = Console.ReadLine();

        Console.Write("\nMasukkan model mobil kamu: ");
        mobilSaya.model = Console.ReadLine();

        Console.Write("\nMasukkan tahun keluaran mobil kamu: ");
        mobilSaya.tahunKeluaran = int.Parse(Console.ReadLine());

        Console.Write("\nMasukkan jumlah pintu mobil kamu: ");
        mobilSaya.jumlahPintu = int.Parse(Console.ReadLine());

        Console.Write("\nMasukkan kecepatan mobil kamu: ");
        int kecepatan = int.Parse(Console.ReadLine());
        mobilSaya.Gas(kecepatan);

        Console.Write("\nMasukkan suara klakson mobil kamu: ");
        string suaraKlakson = Console.ReadLine();
        mobilSaya.Klakson(suaraKlakson);

        mobilSaya.TampilkanInfo();

        Console.ReadKey();
    }
}
