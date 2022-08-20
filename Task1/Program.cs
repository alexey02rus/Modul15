using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            arithProgression.SetStart(10);
            arithProgression.SetStep(2);
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            arithProgression.Reset();
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine(arithProgression.GetNext());
            Console.WriteLine();
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.SetStart(10);
            geomProgression.SetStep(2);
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            geomProgression.Reset();
            Console.WriteLine(geomProgression.GetNext());
            Console.WriteLine(geomProgression.GetNext());
            Console.ReadKey();
        }
    }
}
