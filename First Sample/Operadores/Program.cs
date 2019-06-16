using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sintaxe
            /*
            int a = 10;
            int b = 2;
            
            // Adição
            Console.WriteLine(a+b);

            // Subtraçao
            Console.WriteLine(a - b);

            // Multiplicação
            Console.WriteLine(a*b);

            // Divisão
            Console.WriteLine(a / b);

            // Resto
            Console.WriteLine(5%2);

            // Primary
            // ++ Incremento
            // -- decremento

            // Comparativos
            if (a > b)
                Console.WriteLine("a > b");
            //
            if (a >= b)  // => Lâmbida Expession
                Console.WriteLine("a >= b");
            //
            if(a == b)
                Console.WriteLine("a == b");
            //
            if(a != b)
                Console.WriteLine("a != b");

            // Lógicos
            // XOR
            if (false ^ true)
                Console.WriteLine("true");

            // Condicionais
            //And
            if (true && true)
                Console.WriteLine("true");
            //Or
            if (false || true)
                Console.WriteLine("true");

           */
            #endregion

            //
            Console.WriteLine("Valor 1: ");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor 2: ");
            int v2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Soma: "+Convert.ToString(v1+v2));
            Console.WriteLine("Subtração: " + Convert.ToString(v1 - v2));
            Console.WriteLine("Divisão: " + Convert.ToString(v1 / v2));
            Console.WriteLine("Multiplicação: " + Convert.ToString(v1 * v2));
            Console.WriteLine();

            if (v1 > 0 && v2 > 0)
                Console.WriteLine("Valores 1 e 2 são maiores que zero.");

            if (v1 + v2 <= 0 || v1 - v2 <= 0 || v1 * v2 <= 0 || v1/v2 <= 0)
                Console.WriteLine("Uma ou mais operações possuiem valor menor ou igual a zero.");
            // Espera um click para fechar a janela
            //
            Console.ReadKey();

        }
    }
}
