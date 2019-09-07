using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper()
                .Insert(3, " World!")
                .Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("Hello, World!".Length);

            string valorImportante = null;

            // Navegação segura
            Console.WriteLine(valorImportante?.Length); // Checa se pode chamar o método ou não
        }
    }
}
