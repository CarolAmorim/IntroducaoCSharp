using System;

/*
 *  O NameSpace é uma unidade organizacional
 *  do framework para classes, organizado classes do mesmo tipo
 */
namespace ClassSample
{
    /* Uma classe representa diferentes estruturas
     * Instanciamos ela para obter uma unidade em memória dessa classe
     */ 
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia objeto em aluno
            //
            Aluno a1 = new Aluno();
            a1.Nome = "Carol";
            a1.Idade = 22;
            
            // Espera um click para fechar a janela
            //
            Console.ReadKey();
        }
    }
}
