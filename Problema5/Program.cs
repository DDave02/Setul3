using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
            //Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 
            Console.WriteLine("Dati marimea unui vector: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati valoarea care trebuie inserata in vector: ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati pozitia in care trebuie inserata: ");
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati elementele vectorului pe randuri diferite: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int[] vIns = new int[n + 1];
            for (int i = 0; i <= n; i++)
            {
                if (i < k - 1)
                    vIns[i] = v[i];
                else if (i == k)
                    vIns[i] = e;
                else
                    vIns[i] = v[i - 1];
            }
            Console.WriteLine("Dupa inserare vectorul devine:" );
            for (int i = 0; i <= n; i++)
            {
                Console.Write(" "+vIns[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
