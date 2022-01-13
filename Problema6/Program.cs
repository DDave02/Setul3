using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k.
            //Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
            Console.WriteLine("Dati marimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati pozitia elementului care va fi sters: ");
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati valorile elementelor vectorului pe randuri diferite: ");
            for (int i = 0; i < n; i++)
            {
                v[i] =int.Parse(Console.ReadLine());
            }
            int[] x = new int[n];
            for(int i=k;i<n-1;i++)
            {
                v[i] = v[i+1];
            }
            Console.WriteLine("Vectorul dupa elementul sters: ");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write(v[i]+" ");
            }
        }
    }
}
