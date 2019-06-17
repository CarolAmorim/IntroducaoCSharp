using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSample
{
    class Aluno
    {   // O construtor representa oinstanciamento do objeto
        //
        public Aluno()
        {            
            Console.WriteLine("Aluno constructor");                       
        }
        // Quando não há declaração de visibilidade é considerado privado
        // Fields
        private string nome;
        int idade;

        // Propriedades
        // sintaxe pública para trabalhar com os fields
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }

        // Destrutor
        ~Aluno()
        {
            Console.WriteLine("Aluno destrutor");
            Console.ReadKey();
        }
    }
}
