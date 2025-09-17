/*
  	Objetivo do programa: Calcule a área de um círculo com base no raio informado.
							Como calcular: A = PI . R ao quadrado
    Data da criacao: 2025-08-28
    Criado por: @programacaomentoria
    Alterado por: @rafaelfischer
*/
using System;

namespace ConsoleApp.exercicios.grupo_1.exercicio6 { 
    public class Exercicios6 { 
        public static void Main(string[] args) { 
            const float pi = 3.14159f;
            Console.WriteLine("Exercicio 6 - Calculo da area de um circulo");
            Console.WriteLine("------------------------------------------");

            Console.Write("Informe o valor do raio: ");
            float raio = float.Parse(Console.ReadLine());
            
            float area = pi * (raio * raio);
            Console.WriteLine($"A area do circulo de raio {raio:F2} é: {area:F2}");
        } 
    } 
}