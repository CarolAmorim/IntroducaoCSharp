using System;
using System.Collections;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public string autor;
            public int codigo;
            public int anoPublicacao;

        }
        static void Main(string[] args)
        {
            // Do While - 
            // Faz enquanto condição for verdadeira
            // entra uma vez no loop e depois verifica
            int a = 100;
            do
            {
                Console.WriteLine(a.ToString());
                //
                a += 10;
            } while (a < 100);

            // While - veririca e depois executa a exibição
            //
            a = 0;
            while(a < 100)
            {
                Console.Write(a.ToString() + ", ");
                //
                a += 10;
            }
            Console.WriteLine("");

            // For
            // repetição determinada
            for (int i = 0; i < 9;i+=2)
            {
                Console.Write(i.ToString() + ", ");
            }
            Console.WriteLine("");

            /* Struct
             * tipo de valor normalmente usado para encapsular pequenos grupos
             * de variáveis relacionadas
             */
            Livro l1;
            l1.autor = "Machado de Assis";
            l1.codigo = 1;
            l1.titulo = "Dom Casmurro";
            l1.anoPublicacao = 1940;

            Livro l2;
            l2.autor = "Jorge Amado";
            l2.codigo = 2;
            l2.titulo = "Gabriela";
            l2.anoPublicacao = 2035;


            // for - each
            // Usado em varredura de coleções
            //ArrayList Livros = new ArrayList();
            List<Livro> Livros= new List<Livro>();
            Livros.Add(l1);
            Livros.Add(l2);
            //
            foreach (Livro item in Livros)
            {
                Console.WriteLine("************ Livro **************");
                Console.WriteLine("Livro Código : " + item.codigo.ToString());
                Console.WriteLine("Livro Autor : " + item.autor.ToString());
                Console.WriteLine("Livro Titulo : " + item.titulo.ToString());
                Console.WriteLine("Livro Publicação : " + item.anoPublicacao.ToString());
                Console.WriteLine("**********************************");

            }
            Console.WriteLine("");

            // Anonymous types
            // LINQ
            // variáveis não nuláveis           
            var valores = new[] {new { idade = 18, nome = "luis"},
                                 new { idade = 20, nome = "Alberto"}};
            //
            foreach (var item in valores)
            {
                Console.WriteLine("Nome : " + item.nome.ToString());
                Console.WriteLine("Idade : " + item.idade.ToString());
            }

            // Tipos numéricos são não-nulos
            //
            int? l = null; 
            // adicionando o ?  torna a variável nulable
            Console.ReadKey();
        }
    }
}
