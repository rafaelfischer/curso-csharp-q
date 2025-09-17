/*
	Objetivo do programa: Calcule a área de um quadrado.
							Como calcular: Area = lado * lado
    Data da criacao: 2025-08-28
    Criado por: @programacaomentoria
    Alterado por: @rafaelfischer
*/
using System;

namespace ConsoleApp.exercicios.grupo_1.exercicio5 { 
    public class Exercicios5 { 
        public static void Main(string[] args) { 
            Console.WriteLine("Calculo da area de um quadrado");
            Console.WriteLine("-------------------------------");

            Console.Write("Digite o valor do lado do quadrado: ");
            float lado = float.Parse(Console.ReadLine());
            
            float area = lado * lado;
            Console.WriteLine($"A area do quadrado e: {area:F2}");
        } 
    } 
}