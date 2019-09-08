﻿using System;
using CursoCSharp.ClassesEMetodos;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    public class Caixa<T>
    {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        public T metodoGenerico(T valor)
        {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor()
        {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0) { }
    }

    class CaixaProduto : Caixa<Produto>
    {
        public CaixaProduto() : base(new Produto()) { }
    }

    class Genericos
    {
        public static void Executar()
        {
            var caixa1 = new Caixa<int>(42);

            Console.WriteLine(caixa1.metodoGenerico(666));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("AsaDelta");
            Console.WriteLine(caixa2.metodoGenerico("Master"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
