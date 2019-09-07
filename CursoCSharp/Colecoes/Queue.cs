using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Queue // First In, First Out
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Luis Felipe");
            fila.Enqueue("Celisa");
            fila.Enqueue("Camila");
            fila.Enqueue("Leandro");
            fila.Enqueue("Kevin");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            //salada.Enqueue(42);
            //salada.Enqueue("Asa");
            //salada.Enqueue(true);
            //salada.Enqueue(3.14);

            Console.WriteLine(fila.Contains("Celisa"));
        }
    }
}
