using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class Igualdade
    {
        public static void Executar()
        {
            Produto p1 = new Produto("Sorvete", 5);
            Produto p2 = new Produto("Sorvete", 5);
            Produto p3 = p2;

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p2 == p3);

            Console.WriteLine(p1.Equals(p2));
        }
    }
}
