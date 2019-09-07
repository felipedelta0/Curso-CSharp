using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.WriteLine("Digite um primeiro número: ");
            string palavra = Console.ReadLine();
            int numero;
            // int.TryParse(palavra, out int numero);
            int.TryParse(palavra, out numero);
            Console.WriteLine("Tentativa: {0}", numero);

            Console.WriteLine("Digite um Segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Tentativa: {0}", numero2);
        }
    }
}
