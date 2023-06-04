using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    static class Program
    {
        static void Main()
        {
            // Membuat objek Person menggunakan konstruktor
            Person person1 = new Person("Kevin", 19);
            person1.InfoPerson();

            // Membuat objek Karyawan menggunakan konstruktor
            Karyawan karyawan1 = new Karyawan("Kokomi", 20, "01");
            karyawan1.InfoPerson();
        }
    }
}