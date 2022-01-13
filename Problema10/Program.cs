using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.
            //Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 
            Console.WriteLine("Dati marimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Dati nuamrul cautat: ");
            int k = int.Parse(Console.ReadLine());
            int poz = -1;
            int[] v = new int[n];
            Console.WriteLine("Dati elementele vectorului: ");
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            if (k > v[n / 2])
                for (int i = n / 2; i < n; i++)
                {
                    if (k == v[i])
                    {
                        poz = i;
                        break;
                    }
                }
            else if (k < v[n / 2])
                for (int i = 0; i < n / 2; i++)
                {
                    if (k == v[i])
                    {
                        poz = i;
                        break;
                    }
                }
            else
                poz = n / 2;
            Console.WriteLine("Pozitia = "+poz);
        }
    }
}
