using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rotire. Se da un vector cu n elemente.
            //Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
            Console.WriteLine("Dati marimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati elementele vectorului: ");
            for(int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int[] rot = new int[n];
            rot[0] = v[n - 1];
            for(int i=1;i<n;i++)
            {
                rot[i] = v[i-1];
            }
            Console.WriteLine("Vectorul dupa rotire este: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(rot[i]+" ");
            }
        }
    }
}
