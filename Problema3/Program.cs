using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
            //Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).  
            Console.WriteLine("Dati marimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int minim,maxim;
            Console.WriteLine("Dati elementele vectorului pe randuri diferite: ");
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            minim = Array.IndexOf(v, v.Min());
            maxim = Array.IndexOf(v, v.Max());
            Console.WriteLine($"Valoarea minima al vectorului se afla pe pozitia {minim} iar valoarea maxima pe pozitia {maxim}.");
        }
    }
}
