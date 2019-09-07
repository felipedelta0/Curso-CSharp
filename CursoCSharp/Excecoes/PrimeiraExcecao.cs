using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class Conta
    {
        private double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente");
            }

            Saldo -= valor;
        }
    }

    class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(7_424.42);

            try
            {
                //int.Parse("Abc");
                
                conta.Sacar(8800.00);
                Console.WriteLine("Retirada com sucesso!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
