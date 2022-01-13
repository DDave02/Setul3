using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
            Console.WriteLine("Dati marimea unui vector: ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int suma = 0;
            Console.WriteLine("Dati elementele vectorului pe randuri separate: ");
            for(int i=0;i<n;i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<n;i++)
            {
                suma += v[i];
            }
            Console.WriteLine($"Suma elementelor din vector este: {suma} ");
        }
    }
}
