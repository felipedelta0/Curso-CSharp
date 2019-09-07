using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a} {b}");

            // Não se preocupe com o código
            // Algo como Ponteiros do C
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Luis Felipe";

            dynamic d = c;
            d.nome = "Celisa";

            Console.WriteLine($"{c.nome} {d.nome}");
        }
    }
}
