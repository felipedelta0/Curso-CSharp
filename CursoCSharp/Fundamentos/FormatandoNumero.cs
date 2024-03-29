﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // Casas Decimais
            Console.WriteLine(valor.ToString("C")); // Currency
            Console.WriteLine(valor.ToString("P")); //Percentual
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            CultureInfo cultura2 = new CultureInfo("en-US");

            Console.WriteLine(valor.ToString("C0", cultura));
            Console.WriteLine(valor.ToString("C3", cultura2));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D4")); // Completa com zeros
        }
    }
}
