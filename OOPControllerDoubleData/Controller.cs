using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControllerDoubleDataProcessing
{
    class Controller
    {
        List<Double> subjects;
        public Controller()
        {
            subjects = new List<Double>();
        }
        public void readFromFile()
        {
            StreamReader sr = new StreamReader("adatok.txt", Encoding.UTF8);
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                double a = Convert.ToDouble(line);
                subjects.Add(a);
            }
        }
        public int getNumberOfSubject()
        {
            return subjects.Count();
        }
    }
}
