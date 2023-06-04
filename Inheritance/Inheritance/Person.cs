using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using System;

namespace Inheritance
{
    public class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method
        public void InfoPerson()
        {
            Console.WriteLine("Nama saya {0} dan umur saya {1} tahun", Name, Age);
            Console.ReadLine();
        }
    }

    // Turunan dari class Person
    public class Karyawan : Person
    {
        // Properties karyawan
        public string KaryawanID { get; set; }
        public string Subject { get; set; }

        // Constructor
        public Karyawan(string name, int age, string karyawanID) : base(name, age)
        {
            KaryawanID = karyawanID;
        }

        // Override method
        public new void InfoPerson()
        {
            Console.WriteLine("Nama saya {0}, umur saya {1} tahun, dan ID karyawan saya {2}", Name, Age, KaryawanID);
            Console.ReadLine();
        }
    }

}
