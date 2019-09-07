using System;
using Encapsulamento;

namespace CursoCSharp.POO
{
    class Encapsulamento
    {
        public class FilhoNaoReconhecido : SubCelebridade
        {
            public new void MeusAcessos()
            {
                Console.WriteLine("FilhoNaoReconhecido...");

                Console.WriteLine(InfoPublica);
                Console.WriteLine(CorDoOlho);
                //Console.WriteLine(NumeroCelular);
                Console.WriteLine(JeitoDeFalar);
                //Console.WriteLine(SegredoDeFamilia);
                //Console.WriteLine(UsaMuitoPhotoshop);
            }
        }

        public class AmigoDistante
        {
            public readonly SubCelebridade amigo = new SubCelebridade();

            public void MeusAcessos()
            {
                Console.WriteLine("AmigoDistante...");

                Console.WriteLine(amigo.InfoPublica);
                //Console.WriteLine(amigo.CorDoOlho);
                //Console.WriteLine(amigo.NumeroCelular);
                //Console.WriteLine(amigo.JeitoDeFalar);
                //Console.WriteLine(amigo.SegredoDeFamilia);
                //Console.WriteLine(amigo.UsaMuitoPhotoshop);
            }
        }
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }
    }
}
