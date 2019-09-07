using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Protegido - Herança
        protected string CorDoOlho = "Verde";

        // Interno - Mesmo Projeto (Assembly)
        internal ulong NumeroCelular = 55_11_99999_1111;

        // Interno Protegido - Henrança ou Mesmo Projeto
        protected internal string JeitoDeFalar = "Uso muitas gírias!";

        // Privado Protegido - Mesma classe ou Herança no Mesmo Projeto (C# >= 7.2)
        private protected string SegredoDeFamilia = "Somos todos loucos!";

        // Privado - é o padrão
        // private bool UsaMuitoPhotoshop = true;
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDeFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
