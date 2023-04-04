using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pert5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Penjumlahan(int a , int b)
            {
                return a + b;
            }
            int hasil = Penjumlahan(2, 3);
            Console.WriteLine(hasil);
            Console.ReadKey();
        }
    }
}