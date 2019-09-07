using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class UsandoDelegate
    {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }

        static void MeuImprimirSoma(double x, double y)
        {
            Console.WriteLine(x + y);
        }

        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(15, 27));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(25, 17);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(37, 5));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(40, 2);
        }
    }
}
