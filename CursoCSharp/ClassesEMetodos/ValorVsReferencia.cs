using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia
    {
        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} - {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} - {copiaNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Luis Felipe",
                Idade = 23
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} - {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} - {copiaDep.Idade}");

            copiaDep.Nome = "Asa Delta";
            dep.Idade = 42;

            Console.WriteLine($"{dep.Nome} - {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} - {copiaDep.Idade}");
        }
    }
}
