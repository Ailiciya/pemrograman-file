using LatihanOverloading1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOveloading1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Overloading overloading1 = new Overloading();

            int a = 236549;
            int b = 12523;

            int nilaiMin = overloading1.CariNilaiMin(a, b);
            int nilaiMax = overloading1.CariNilaiMax(a, b);

            Console.ReadLine();
        }
    }
}