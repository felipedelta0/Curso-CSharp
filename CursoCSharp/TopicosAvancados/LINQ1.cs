using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1
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
                new Aluno() { Nome = "Jane", Idade = 33, Nota = 6.8 },
            };

            Console.WriteLine("=== Aprovados =================");
            var aprovados = alunos.Where(a => a.Nota > 8 ? true : false).OrderBy(a => a.Nota);
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome + " - " + aluno.Idade);
            }

            Console.WriteLine("\n\n=== Reprovados ================");
            var reprovados = alunos.Where(a => a.Nota <= 8 ? true : false).OrderBy(a => -a.Idade);
            foreach (var aluno in reprovados)
            {
                Console.WriteLine(aluno.Nome + " - " + aluno.Idade);
            }

            Console.WriteLine("\n\n=== Chamada ===================");
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n\n=== Aprovados (Por Idade) =====");
            var alunosAprovados = 
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
