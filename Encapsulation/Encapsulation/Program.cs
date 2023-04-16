using Encapsulation;

public class main
{
    public static void Main(string[] args)
    {
        BMW mobil1 = new BMW("iX3", "Hitam", 85095);
        BMW mobil2 = new BMW("i4", "Putih", 51400);
        
        Console.WriteLine("Mobil 1:");
        Console.WriteLine("Model: " + mobil1.getNamamodel());
        Console.WriteLine("Warna: " + mobil1.getwarna());
        Console.WriteLine("Harga: " + mobil1.getHarga());

        Console.WriteLine("\nMobil 2: ");
        Console.WriteLine("Model: " + mobil2.getNamamodel());
        Console.WriteLine("Warna: " + mobil2.getwarna());
        Console.WriteLine("Harga: " + mobil2.getHarga());
    }
}