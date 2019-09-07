using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoNoConsole();

            Action<string> nomeNoConsole = (a) =>
                Console.WriteLine("Olá {0}, tudo bem?", a);

            nomeNoConsole("Asa Delta");

            Func<int> JogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 21);
            };

            Console.WriteLine(JogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");

            Console.WriteLine(conversorHex(JogarDado()));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => 
                string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(6, 5, 1996));
        }
    }
}
