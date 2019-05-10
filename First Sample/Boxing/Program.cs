using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Boxing
            //
            int a = 10;
            object o = (object)a;
            //System.Object

            // Retornando tipo
            //
            Console.WriteLine(o.GetType().ToString());

            // Casting - Convertendo tipo - Unboxing
            //
            int b = (int)o;

            // Já tenho acesso ao meu valor inteiro sem declarar variável para receber resultado
            //
            ((int)o).ToString();
            Console.WriteLine(((int)o).ToString());

            // Possui uma declaração de tipo
            //
            System.Type t = b.GetType();
            Console.WriteLine(t.Name);

            Console.ReadKey();
        }
    }
}
