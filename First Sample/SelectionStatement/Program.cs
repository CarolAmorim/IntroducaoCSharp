using System;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            /* a region possibilita a organização do código
             * permitindo a minimização de um trecho, 
             * para sua identificação
             */
            #region if
            int a = 5;

            if (a == 10)
                Console.WriteLine("A = 5");
            else
                Console.WriteLine("A <> 5");

            // Comentário de uma linha

            /* comentário
             * de
             * multiplas
             * linhas
             */

            Console.ReadKey();

            #endregion
        }
    }
}
