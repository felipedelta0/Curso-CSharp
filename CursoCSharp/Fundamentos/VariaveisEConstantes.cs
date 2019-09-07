using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Área da Circunferência
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + (PI * raio * raio));

            // Tipos internos 
            // Dica: sbyte.MinValue ou sbyte.MaxValue para pegar o menor e maior valor
            // Obs: Aplicar acima e mostrar em todos
            // uint e derivados = unsigned

            // Tipos com tamanho de 1 byte
            bool estaChovendo = true; // true e false
            byte by;    // 0 a 255
            sbyte sb;   // -128 a 127

            Console.WriteLine("Byte Mínimo: " + byte.MinValue);
            Console.WriteLine("Byte Máximo: " + byte.MaxValue);
            Console.WriteLine("Sbyte Minimo: " + sbyte.MinValue);
            Console.WriteLine("Sbyte Minimo: " + sbyte.MaxValue);

            // Tipos com tamanho de 2 bytes
            short sh;   // -32768 a 32767
            ushort uh;  // 0 a 65535
            char ch;    // caracteres em aspas simples, exemplo: 'a', 'ç', 'j'

            // Tipos com tamanho de 4 bytes
            int it;     // -2147483648 a 2147483647
            uint ut;    // 0 a 4294967295
            float fl;   // até 10 ^ 38 - necessario colocar f ou F no final

            // Tipos com tamanho de 8 bytes
            long lg;    // -9223372036854775808L a 9223372036854775807L
            ulong ul;   // 0 a 18446744073709551615
            double db;  // até 10 ^ 308

            // Tipos com tamanho de 16 bytes
            decimal dc; // até 28 casas decimais

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);
        }
    }
}
