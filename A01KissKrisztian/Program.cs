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
        static int Maximumertek()
        {
            //Console.Writeline(Lista.Max);
            int maxertek = 0;
            for (int i = 0; i < Lista.Count; i++)
            {
                if (maxertek < Lista[i])
                {
                    maxertek = Lista[i];
                }
            }
            
            return maxertek;
        }
        static int Egyediek()
        {
            int szamlalo = 0;
            StreamWriter iras = new StreamWriter("Egyediek.txt");
            for (int i = 0; i < Lista.Count; i++)
            {
                if (Lista[i] % 5 == 0 && Lista[i] % 7 == 0)
                {
                    szamlalo++;
                    iras.WriteLine(Lista[i]);
                }
            }
            iras.Close();
            
            return szamlalo;
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Console.WriteLine($"A maximum: {Maximumertek()}");
            Console.WriteLine($"5 és 7 oszthatóak száma: {Egyediek()}");
            Console.ReadLine();
        }
    }
}
