using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse. Se da un vector nu n elemente.
            //Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul
            //al doilea devine penultimul etc
            Console.WriteLine("Dati marimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati elementele vectorului: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
           // metoda1(n, v);
            metoda2(n,v);
        }

        private static void metoda2(int n, int[] v)
        {
            int k = n - 1;
            int[] rev = new int[n];
                for (int i = 0; i < n ; i++)
                {
                    rev[k] = v[i];
                    k--;
                }
                Console.WriteLine("Vectorul inversat este: ");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(rev[i] + " ");
                }
            

        }

        private static void metoda1(int n, int[] v)
        {
            Array.Reverse(v);
            Console.WriteLine("Elementele inversate sunt: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i]+" ");
            }
        }
    }
}
