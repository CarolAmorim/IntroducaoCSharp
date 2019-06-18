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

        public Aluno(string _nome, int _idade)
        {
            this.nome = _nome;
            this.idade = _idade;
        }

        // Quando não há declaração de visibilidade é considerado privado
        // Fields
        private string nome;
        int idade;

        // Propriedades
        // Parametrizador da classe
        // sintaxe pública para trabalhar com os fields
        public string Nome
        {
            // Get e set simples podem ser escritos de forma resumida
            // get;
            // set;
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

        // Métodos ou funções
        //
        public void Limpar()
        {
            this.idade = 0;
            this.nome = string.Empty;
        }

        public int GetTwiceAge()
        {
            int twice = this.idade * 2;
            return twice;
        }
        private void GoAge()
        {
            this.idade = 21;
        }

        public bool VerifyMajor(int _idade)
        {
           bool verify = (_idade > 18) ? true : false;
            return verify;
        }
        // Destrutor
        ~Aluno()
        {
            Console.WriteLine("Aluno destrutor");
            Console.ReadKey();
        }
    }
}
