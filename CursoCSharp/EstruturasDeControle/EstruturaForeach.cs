using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "Opa!";
            
            foreach (var letra in palavra)
            {
                Console.WriteLine($" {letra}");
            }

            var alunos = new String[] { "Luis Felipe", "Celisa", "Leandro", "Camila", "Kevin" };

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
