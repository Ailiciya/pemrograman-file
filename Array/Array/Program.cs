using System;

public class Mahasiswa
{
    public int Nomor { get; set; }
    public string Nama { get; set; }
    public string NIM { get; set; }
    public int Nilai { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        Mahasiswa mhs1 = new Mahasiswa();
        Mahasiswa mhs2 = new Mahasiswa();
        Mahasiswa mhs3 = new Mahasiswa();

        mhs1.Nomor = 1;
        mhs1.NIM = "22.11.4870";
        mhs1.Nama = "Kevin";
        mhs1.Nilai = 80;

        mhs2.Nomor = 2;
        mhs2.NIM = "22.11.5870";
        mhs2.Nama = "Raiden";
        mhs2.Nilai = 90;

        mhs3.Nomor = 3;
        mhs3.NIM = "22.11.6870";
        mhs3.Nama = "Kokomi";
        mhs3.Nilai = 100;

        Console.WriteLine("NOMOR     NIM          NAMA      NILAI");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"{mhs1.Nomor,-7}   {mhs1.NIM,-12} {mhs1.Nama,-9} {mhs1.Nilai}");
        Console.WriteLine($"{mhs2.Nomor,-7}   {mhs2.NIM,-12} {mhs2.Nama,-9} {mhs2.Nilai}");
        Console.WriteLine($"{mhs3.Nomor,-7}   {mhs3.NIM,-12} {mhs3.Nama,-9} {mhs3.Nilai}");

        Console.ReadLine();
    }
}
