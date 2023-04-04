using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Pert5
{
    public class Mobil
    {
        private string merek;
        private int tahun;

        // Constructor 1

        public Mobil(string m, int t)
        {
            merek = m;
            tahun = t;
        }
        // Constructor 2

        public Mobil()
        {
            merek = "Belum diatur";
            tahun = 0;
        }
        public void Info()
        {
            Console.WriteLine("Mobil {0} tahun {1}", merek, tahun);
            Console.ReadKey();
        }

    }
}
