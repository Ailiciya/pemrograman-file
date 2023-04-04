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
            Mobil mobil1 = new Mobil("Toyota", 2000); // ada parameter input.
            Mobil mobil2 = new Mobil(); // tidak ada parameter input.
            mobil1.Info();
            mobil2.Info();
        }
    }
}