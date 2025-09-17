/*
  	Objetivo do programa: Calcule a área de um retângulo
							Area = comprimento * altura
    Data da criacao: 2025-08-28
    Criado por: @programacaomentoria
    Alterado por: @rafaelfischer
*/
using System;

namespace ConsoleApp.exercicios.grupo_1.exercicio7 { 
    public class Exercicios7 { 
        public static void Main(string[] args) { 
            Console.WriteLine("Calculo da area de um retangulo");
            Console.WriteLine("-------------------------------");

            Console.Write("Informe o comprimento: ");
            float comprimento = float.Parse(Console.ReadLine());

            Console.Write("Informe a altura: ");
            float altura = float.Parse(Console.ReadLine());

            float area = comprimento * altura;
            Console.WriteLine($"A area do retangulo é: {area:F2}");
        } 
    } 
}