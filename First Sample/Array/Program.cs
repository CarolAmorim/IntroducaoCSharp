using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Array
            //

            // Single dimensional
            //
            int[] a1 = new int[3];
            a1[0] = 10;
            a1[1] = 20;
            a1[2] = 30;

            // Declaração dinâmica
            //
            bool[] a2 = new bool[] { true, true, false };

            string[] a3 = { "one", "Two", "Three" };

            Console.WriteLine(a3.Length);

            // array multidimensional
            //
            int[,] ma1 = new int[3, 3];
            ma1[0, 0] = 10;

            // Listas com tamanho e tipo não Definido  -- ArrayList
            //
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add("Dez");
            al.Add(true);

            Console.ReadKey();
        }
    }
}
