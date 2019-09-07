using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa homem = new Pessoa();
            homem.Nome = "Luis Felipe";
            homem.Idade = 23;
            homem.ApresentarNoConsole();

            Pessoa mulher = new Pessoa();
            mulher.Nome = "Celisa";
            mulher.Idade = 25;
            var apresentacaoMulher = mulher.Apresentar();
            Console.WriteLine(apresentacaoMulher);

            homem.Limpar();
            homem.ApresentarNoConsole();

            mulher.Limpar();
            apresentacaoMulher = mulher.Apresentar();
            Console.WriteLine(apresentacaoMulher);
        }
    }
}
