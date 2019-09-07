using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(1996, 5, 6);
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0:D2}/{1:D2}/{2}",
                Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    class Readonly
    {
        public static void Executar()
        {
            var novoCliente = new Cliente("Luis Felipe", new DateTime(1990, 8, 7));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());

        }
    }
}
