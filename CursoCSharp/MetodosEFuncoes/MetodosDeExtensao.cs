using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int outroNumero)
        {
            return num + outroNumero;
        }

        public static int Subtracao(this int num, int outroNumero)
        {
            return num - outroNumero;
        }

        public static int Multiplicacao(this int num, int outroNumero)
        {
            return num * outroNumero;
        }
    }

    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 37;
            int numero2 = 55;
            int numero3 = 21;

            Console.WriteLine(numero.Soma(5));
            Console.WriteLine(numero2.Subtracao(13));
            Console.WriteLine(numero3.Multiplicacao(2));

            Console.WriteLine(2.Soma(40));
            Console.WriteLine(50.Subtracao(8));
            Console.WriteLine(7.Multiplicacao(6));
        }
    }
}
