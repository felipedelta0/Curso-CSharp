using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno() { Nome = "Luis", Idade = 23, Nota = 8.5 },
                new Aluno() { Nome = "Celisa", Idade = 25, Nota = 8.0 },
                new Aluno() { Nome = "Leandro", Idade = 24, Nota = 4.3 },
                new Aluno() { Nome = "Camila", Idade = 32, Nota = 9.5 },
                new Aluno() { Nome = "Kevin", Idade = 24, Nota = 7.7 },
                new Aluno() { Nome = "Alex", Idade = 32, Nota = 7.5 },
                new Aluno() { Nome = "Leandro", Idade = 33, Nota = 6.8 },
            };

            var luis = alunos.Single(aluno => aluno.Nome.Equals("Luis"));
            Console.WriteLine($"{luis.Nota} - {luis.Nome} - {luis.Idade}");

            var celisaum = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Celisaum"));
            Console.WriteLine(celisaum);

            if (celisaum == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }

            var leandro = alunos.First(aluno => aluno.Nome.Equals("Leandro"));
            Console.WriteLine($"{leandro.Nota} - {leandro.Nome} - {leandro.Idade}");

            var camila1 = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Camila1"));

            if (camila1 == null)
            {
                Console.WriteLine("Aluno Inexistente");
            }

            var outroLeandro = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Leandro"));
            Console.WriteLine($"{outroLeandro.Nota} - {outroLeandro.Nome} - {outroLeandro.Idade}");

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);

            var mediaAprovados = alunos.Where(a => a.Nota >= 7).Average(aluno => aluno.Nota);
            Console.WriteLine(mediaAprovados);
        }
    }
}
