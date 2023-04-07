using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMember
{
    internal class Mahasiswa
    {
        //Fields
        private string _nama;
        private string _nim;
        private float _ipk;
        private string _jurusan;

        //Properti
        public string Nama
        {
            get { return _nama; }
            set { _nama = value; }
        }

        public string Nim
        {
            get { return _nim; }
            set { _nim = value; }
        }

        public float Ipk
        {
            get { return _ipk; }
            set { _ipk = value; }
        }

        public string Jurusan
        {
            get { return _jurusan; }
            set { _jurusan = value; }
        }


        public void InfoMahasiswa()
        {
            Console.WriteLine("----------Profile Mahasiswa----------");
            Console.WriteLine("Dengan Nama : {0}", Nama);
            Console.WriteLine("Dengan Nim : {0}", Nim);
            Console.WriteLine("Dengan Jurusan : {0}", Jurusan); 
            Console.WriteLine("Dengan Ipk : {0}", Ipk);

            if (Ipk >= 1 && Ipk <= 3)
            {
                Console.WriteLine("Jangan bersedih bahwa kamu tidak tuntas");
            }
            else if (Ipk >= 3 && Ipk <= 3.5)
            {
                Console.WriteLine("Kerja Bagus!! Nilai kamu tuntas");
            }
            else if (Ipk > 3.5 && Ipk <= 4)
            {
                Console.WriteLine("Wow!! Kamu hebat");
            }
            else if (Ipk > 4)
            {
                Console.WriteLine("Error!!!! Nilai IPK Kamu tidak valid, nilai maksimum IPK adalah 4");
            }
            if (Ipk < 1)
            {
                Console.WriteLine("Error!!!! Nilai IPK kamu tidak valid, nilai minimum IPK adalah 1");
            }
        }
    }
}
