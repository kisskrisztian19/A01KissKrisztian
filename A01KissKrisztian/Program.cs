using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A01KissKrisztian
{
    class Program
    {
        static List<int> Lista = new List<int>();
        static void Beolvasas()
        {
            int seged;
            StreamReader olvas = new StreamReader("Adatok.dat");
            while (!olvas.EndOfStream)
            {
                seged = int.Parse(olvas.ReadLine()) * 2;
                Lista.Add(seged);
            }
            olvas.Close();
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Console.ReadLine();
        }
    }
}
