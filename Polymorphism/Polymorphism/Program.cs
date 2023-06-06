using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal.Cat cat = new Animal.Cat();
            cat.Bersuara();

            Animal.Cow cow = new Animal.Cow();
            cow.Bersuara();

            Animal.Aligator aligator = new Animal.Aligator();
            aligator.Bersuara();

            Animal.Chicken chicken = new Animal.Chicken();
            chicken.Bersuara();

            Console.ReadLine();
        }
    }
}
