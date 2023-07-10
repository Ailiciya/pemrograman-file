using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Ayam : Hewan
    {
        public override void bersuara()
        {
            Console.WriteLine("jenis hewan ini {0}", jenisHewan);
            Console.WriteLine("memiliki jumlah kaki {0}", jmlKaki);
            Console.WriteLine("kukuruyukkkkkk");
        }
    }
}
