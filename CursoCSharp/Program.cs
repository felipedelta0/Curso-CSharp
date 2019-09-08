﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                { "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar },
                { "Comentários - Fundamentos", Comentarios.Executar },
                { "Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                { "Inferência - Fundamentos", Inferencia.Executar },
                { "Interpolação - Fundamentos", Interpolacao.Executar },
                { "Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                { "Lendo Dados - Fundamentos", LendoDados.Executar },
                { "Formatando Número - Fundamentos", FormatandoNumero.Executar },
                { "Conversões - Fundamentos", Conversoes.Executar },
                { "Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                { "Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                { "Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                { "Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                { "Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                { "Operador Ternário - Fundamentos", OperadorTernario.Executar },

                // Estruturas de Controle
                { "Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                { "Estrutura If / Else - Estruturas de Controle", EstruturaIfElse.Executar },
                { "Estrutura If / Else If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                { "Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                { "Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                { "Estrutura Do / While - Estruturas de Controle", EstruturaDoWhile.Executar },
                { "Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                { "Estrutura Foreach - Estruturas de Controle", EstruturaForeach.Executar },
                { "Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                { "Usando Continue - Estruturas de Controle", UsandoContinue.Executar },

                // Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar },
                { "Construtores - Classes e Métodos", Construtores.Executar },
                { "Métodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                { "Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                { "Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                { "Parâmetros - Classes e Métodos", Params.Executar },
                { "Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                { "Getter e Setters - Classes e Métodos", GetSet.Executar },
                { "Propriedades (Props) - Classes e Métodos", Props.Executar },
                { "Atributos Readonly - Classes e Métodos", Readonly.Executar },
                { "Enumerator - Classes e Métodos", ExemploEnum.Executar },
                { "Struct - Classes e Métodos", ExemploStruct.Executar },
                { "Struct VS Classe - Classes e Métodos", StructVsClasse.Executar },
                { "Valor VS Refêrencia - Classes e Métodos", ValorVsReferencia.Executar },
                { "Parâmetros por Refêrencia - Classes e Métodos", ParametrosPorReferencia.Executar },
                { "Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar },

                // Coleções
                { "Arrays - Coleções", Colecoes.Array.Executar },
                { "List - Coleções", Colecoes.ArrayList.Executar },
                { "Array List - Coleções", ColecoesArrayList.Executar },
                { "Coleções Set - Coleções", ColecoesSet.Executar },
                { "Fila (Queue) - Coleções", Queue.Executar },
                { "Igualdade - Coleções", Igualdade.Executar },
                { "Stack - Coleções", ColecaoStack.Executar },
                { "Dictionary - Coleções", ColecoesDictionary.Executar },

                // POO - Programação Orientada a Objetos
                { "Herança - POO", Heranca.Executar },
                { "Construtor This - POO", ConstrutorThis.Executar },
                { "Encapsulamento - POO", POO.Encapsulamento.Executar },
                { "Polimorfismo - POO", Polimorfismo.Executar },
                { "Abstratismo - POO", Abstract.Executar },
                { "Interface - POO", Interface.Executar },
                { "Sealed - POO", Sealed.Executar },

                // Métodos e Funções
                { "Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar },
                { "Lambda Como Delegate - Métodos & Funções", LambdasDelegate.Executar },
                { "Usando Delegate - Métodos & Funções", UsandoDelegate.Executar },
                { "Delegate Como Funções Anônimas - Métodos & Funções", DelegateFuncAnonima.Executar },
                { "Delegate Como Parâmetros - Métodos & Funções", DelegatesComoParametros.Executar },
                { "Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar },

                // Exceções
                { "Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
                { "Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar },

                // Usando API
                { "Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar },
                { "Lendro Arquivos - Usando API", LendoArquivos.Executar },
                { "Exempo File Info - Usando API", ExempoFileInfo.Executar },
                { "Diretórios - Usando API", Diretorios.Executar },
                { "Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar },
                { "Exemplo Path - Usando API", ExemploPath.Executar },
                { "Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar },

                // Tópicos Aavnçados
                { "LINQ #1 - Tópicos Avançados", LINQ1.Executar },
                { "LINQ #2 - Tópicos Avançados", LINQ2.Executar },
                { "Nullables - Tópicos Avançados", Nullables.Executar },
                { "Dynamics - Tópicos Avançados", Dynamics.Executar },
                { "Generics - Tópicos Avançados", Genericos.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}