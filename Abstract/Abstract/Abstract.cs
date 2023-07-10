using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class Hewan
    {
        public string jenisHewan { get; set; }
        public int jmlKaki { get; set; }
        public abstract void bersuara();
    }
}
