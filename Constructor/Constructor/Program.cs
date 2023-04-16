using Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llll
{
    internal class Program
    {
        static void Main(string[] agrs)
        {
            Mahasiswa mahasiswa1 = new Mahasiswa("Kevin","22.11.4870","Kaltim");
            Console.WriteLine(mahasiswa1.nama + "\n" + mahasiswa1.nim + "\n" + mahasiswa1.asal);
            Console.WriteLine("-----------------------------------");


            Mahasiswa mahasiswa2 = new Mahasiswa();
            mahasiswa2.SetMahasiswa("Kevin","08888888");
            mahasiswa2.SetAsal("Kaltim");
            Console.WriteLine(mahasiswa2);

            Console.ReadKey();
        }
    
    }
}