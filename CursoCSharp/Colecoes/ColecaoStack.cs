using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecaoStack  // First In, Last Out
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(42);
            pilha.Push("Asa");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine($"{pilha.Count}");
        }
    }
}
