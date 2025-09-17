/*
    Objetivo do programa: Perguntar o nome de quem está usando o programa e sua idade. Faça duas perguntas.
    Data da criacao: 2025-08-28
    Criado por: @programacaomentoria
    Alterado por: @rafaelfischer
*/
using System;

namespace ConsoleApp.exercicios.grupo_1.exercicio2 { 
    public class Exercicios2 { 
        public static void Main(string[] args) { 
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Ola, {nome}! Voce tem {idade} anos.");
        } 
    } 
}