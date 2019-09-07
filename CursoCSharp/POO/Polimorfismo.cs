using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.POO
{
    public class Comida
    {
        public double Peso;

        public Comida(double peso)
        {
            Peso = peso;
        }

        public Comida() { }
    }
    public class Feijao : Comida
    {
        public Feijao(double peso) : base(peso) { }
    }

    public class Arroz : Comida { }

    public class Carne : Comida { }
    public class Pessoa
    {
        public double Peso;

        public void Comer(Comida comida)
        {
            Peso += comida.Peso;
        }

        //public void Comer(Feijao feijao)
        //{
        //    Peso += feijao.Peso;
        //}

        //public void Comer(Arroz arroz)
        //{
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne)
        //{
        //    Peso += carne.Peso;
        //}
    }
    class Polimorfismo
    {
        public static void Executar()
        {
            Feijao ingrediente1 = new Feijao(0.300);
            //ingrediente1.Peso = 0.300;

            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.250;

            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.300;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}");
        }
    }
}
