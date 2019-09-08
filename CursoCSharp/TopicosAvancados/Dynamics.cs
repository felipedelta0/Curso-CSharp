using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "Teste";
            meuObjeto = 42;
            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Luis Felipe";
            aluno.nota = 9.9;
            aluno.idade = 23;

            Console.WriteLine($"{aluno.nome} - {aluno.idade} - {aluno.nota}");
        }
    }
}
