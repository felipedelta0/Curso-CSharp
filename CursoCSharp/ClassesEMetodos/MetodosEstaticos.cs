using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        // Método de Instância - Só pode ser acessado da Instância
        public int Somar(int a, int b)
        {
            return a + b;
        }

        // Método de Classe ou Método Estático - Só pode ser acessado da Classe
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(21, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine("Resultado: {0}", calc.Somar(27, 15));
        }
    }
}
