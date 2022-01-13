using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da un vector cu n elemente si o valoare k.
            //Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
            Console.WriteLine("Dati marimea unui vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.WriteLine("Dati numarul cautat: ");
            int k = int.Parse(Console.ReadLine());
            bool afis = false;
            Console.WriteLine("Dati elementele vectorului pe randuri separate: ");
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
                if(v[i]==k)
                {
                    Console.WriteLine($"Elementul se afla pe pozitia {i}");
                    afis = true;
                    break;
                }
            if(afis==false)
                Console.WriteLine("-1");
        }
    }
}
