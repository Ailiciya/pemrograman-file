using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Animal
    {
        public class Hewan
        {
            public string Name { get; set; }
            public virtual void speak()
            {
                Console.WriteLine("semua hewann bersuara");
            }
        }

        public class Cat : Animal
        {
            public void Bersuara()
            {
                Console.WriteLine("kucing bersuara : meong");
            }
        }

        public class Cow : Animal
        {
            public void Bersuara()
            {
                Console.WriteLine("sapi bersuara : mooooo");
            }
        }
        public class Aligator : Animal
        {
            public void Bersuara()
            {
                Console.WriteLine("buaya bersuara : hay manizz");
            }
        }

        public class Chicken : Animal
        {
            public void Bersuara()
            {
                Console.WriteLine("ayam bersuara : kukuruyuk");
            }
        }

    }
}
