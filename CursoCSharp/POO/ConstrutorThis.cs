﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.POO
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal (string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializado.");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }

        public override string ToString()
        {
            return $"{Nome} tem {Altura}cm de altura.";
        }
    }
    class ConstrutorThis
    {
        public static void Executar()
        {
            Cachorro spike = new Cachorro("Spike");
            Cachorro layca = new Cachorro("Layca", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(layca.ToString());
        }
    }
}
