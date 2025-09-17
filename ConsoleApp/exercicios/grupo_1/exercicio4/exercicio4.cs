/*
    Objetivo do programa: Calcule o quadrado de um número
    Data da criacao: 2025-08-28
    Criado por: @programacaomentoria
    Alterado por: @rafaelfischer
*/
using System;

namespace ConsoleApp.exercicios.grupo_1.exercicio4 { 
    public class Exercicios4 { 
        public static void Main(string[] args) { 
            Console.WriteLine("Programa para calcular o quadrado de um numero");
            Console.WriteLine("----------------------------------------------");

            Console.Write("Digite um numero: ");
            float numero = float.Parse(Console.ReadLine());

            float quadrado = numero * numero;
            Console.WriteLine($"O quadrado de {numero:F2} e: {quadrado:F2}");
        } 
    } 
}