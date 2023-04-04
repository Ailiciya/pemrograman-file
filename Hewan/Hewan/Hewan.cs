using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hewan
{
    public class Hewan
    {
        public virtual void Makan()
        {
            Console.WriteLine("Hewan sedang makan Nasi padang");
            Console.ReadLine();
        }
    }
    public class Kucing:Hewan
    {
        public override void Makan()
        {
            Console.WriteLine("Kucing Sedang Makan Nasi padang");
            Console.ReadLine ();
        }
    }
}
