using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá, eu sou {this.Nome} e tenho {this.Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(this.Apresentar());
        }

        public void Limpar()
        {
            Nome = "";
            Idade = 0;
        }
    }
}
