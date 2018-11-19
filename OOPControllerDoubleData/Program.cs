using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControllerDoubleDataProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller c = new Controller();
            c.readFromFile();
            Console.WriteLine("Beolvasott adatok száma: " + c.getNumberOfSubject());
            Console.ReadKey();
        }
    }
}
