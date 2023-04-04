using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloading1
{
    internal class Overloading
    {
        public int CariNilaiMin(int a, int b)
        {
            int min;
            if (a < b)
            {
                Console.WriteLine("Nilai min dari kedua nilai adalah : {0}", min = a);
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Nilai min dari kedua nilai adalah : {0}", min = b);
                Console.ReadLine();
            }
                return min;

        }
        public int CariNilaiMax(int a, int b)
        {
            int max;
            if (a > b)
            {
                Console.WriteLine("Nilai max dari kedua nilai adalah: {0}", max = a);
            }
            else
            {
                Console.WriteLine("Nilai max dari kedua nilai adalah: {0}", max = b);
            }

            return max;
        }
    }
}
