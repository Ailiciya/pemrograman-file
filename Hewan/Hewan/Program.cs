using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hewan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hewan hewan = new Hewan(); //membuat objek dari class hewan.
            Kucing kucing = new Kucing(); // membuat objek dari class turunan kucing.

            //pemanggilan method.

            hewan.Makan();
            kucing.Makan();
        }
    }
}