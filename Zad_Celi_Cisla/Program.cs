using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_Celi_Cisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vivedi cislo za a=");
            int a=int.Parse(Console.ReadLine());

            Console.Write("Vivedi cislo za b=");
            int b = int.Parse(Console.ReadLine());

            int c = a + b + 2*a*b;
            Console.WriteLine("c=" + c);
            
        }
    }
}
