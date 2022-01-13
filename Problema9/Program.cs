using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
            Console.WriteLine("Dati marimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati nuamrul de rotiri care doriti sa le faceti: ");
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati elementele vectorului: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            while(k!=0)
            {
                int[] rot = new int[n];
                rot[0] = v[n - 1];
                for (int i = 1; i < n; i++)
                {
                    rot[i] = v[i - 1];
                }
                Array.Copy(rot, v,n);
                k--;
            }
            Console.WriteLine("Vectorul dupa rotire este: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
    }
}
