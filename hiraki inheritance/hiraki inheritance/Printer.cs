using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrinterWindows
{
    public abstract class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printing....");
        }
    }

    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension : 31*53");
        }

        public override void Print()
        {
            Console.WriteLine("Epson printing.....");
        }
    }

    public class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension : 47*79");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printing......");
        }
    }

    public class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension : 51*37");
        }

        public override void Print()
        {
            Console.WriteLine("LaserJet printing.....");
        }
    }
}
