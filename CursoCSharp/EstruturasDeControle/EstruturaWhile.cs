using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnteriorBackgroud = Console.BackgroundColor;
                    var corAnteriorForeground = Console.ForegroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Número encontrado em {0} tentativas.", tentativas);
                    Console.BackgroundColor = corAnteriorBackgroud;
                    Console.ForegroundColor = corAnteriorForeground;
                } else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas Restantes: {0}", tentativasRestantes);
                } else
                {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas Restantes: {0}", tentativasRestantes);
                }
            }

            Console.WriteLine("Game Over!");
        }
    }
}
