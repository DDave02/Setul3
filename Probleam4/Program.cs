using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleam4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
            Console.WriteLine("Dati marimea unui vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int minim, maxim,aparitieMinim=1,aparitieMaxim=1;
            Console.WriteLine("Dati elementele vectorului pe randuri separate: ");
            v[0] = int.Parse(Console.ReadLine());
            minim = v[0];
            maxim = v[0];
            for (int i = 1; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (minim > v[i])
                {
                    aparitieMinim = 1;
                    minim = v[i];
                }
                else if (minim == v[i])
                    aparitieMinim++;
                if (maxim < v[i])
                {
                    aparitieMaxim = 1;
                    maxim = v[i];
                }
                else if (maxim == v[i])
                    aparitieMaxim++;
            }
            Console.WriteLine($"Numarul maxim din vector este {maxim} si apare de {aparitieMaxim} ori.");
            Console.WriteLine($"Numarul minim din vector este {minim} si apare de {aparitieMinim} ori.");
        }
    }
}
