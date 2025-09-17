/*
  	Objetivo do programa: 	Você está montando um cadastro para uma empresa de vendas na internet, e precisa fornecer este "formulário de dados de clientes". 
						  	Não se preocupe neste momento se irá ou não guardar este dado em algum lugar. 
							Pergunte e obtenha os seguintes dados e depois exiba todos na tela:
								- Nome Completo
								- Data de Nascimento
								- Cidade/Pais de Origem(Nascimento)
								- Endereco completo de onde mora
								- Pais onde reside
								- Data do Cadastro
								- Escolaridade: (Ensino Básico/Ensino Fundamental/Ensino Superior) 
	Data da criacao: 2025-08-28
	Criado por: @programacaomentoria
	Ultima atualizacao: 2025-09-15
	Alterado por: @rafaelfischer
*/
using System;

namespace ConsoleApp.exercicios.grupo_1.exercicio8 { 
    public class Exercicios8 { 
        public static void Main(string[] args) { 
            Console.WriteLine("Exercicio 8 - Cadastro de Clientes");
            Console.WriteLine("-------------------");

            Console.Write("Nome Completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            string dataNascimento = Console.ReadLine();

            Console.Write("Cidade/Pais de Origem (Nascimento): ");
            string cidadePaisOrigem = Console.ReadLine();

            Console.Write("Endereco completo de onde mora: ");
            string enderecoCompleto = Console.ReadLine();

            Console.Write("Pais onde reside: ");
            string paisResidencia = Console.ReadLine();

            Console.Write("Data do Cadastro: ");
            string dataCadastro = Console.ReadLine();

            Console.Write("Escolaridade (Ensino Básico/Ensino Fundamental/Ensino Superior): ");
            string escolaridade = Console.ReadLine();

            Console.WriteLine("\n============================");
            Console.WriteLine("Dados do Cliente Cadastrado:");
            Console.WriteLine("============================");
            Console.WriteLine($"Nome Completo: {nomeCompleto}");
            Console.WriteLine($"Data de Nascimento: {dataNascimento}");
            Console.WriteLine($"Cidade/Pais de Origem: {cidadePaisOrigem}");
            Console.WriteLine($"Endereco Completo: {enderecoCompleto}");
            Console.WriteLine($"Pais de Residencia: {paisResidencia}");
            Console.WriteLine($"Data do Cadastro: {dataCadastro}");
            Console.WriteLine($"Escolaridade: {escolaridade}");
        } 
    } 
}