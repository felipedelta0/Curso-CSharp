using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);
    class LambdasDelegate
    {
        public static void Executar()
        {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(17, 25));
            Console.WriteLine(sub(100, 58));
            Console.WriteLine(mult(21, 2));
        }
    }
}
