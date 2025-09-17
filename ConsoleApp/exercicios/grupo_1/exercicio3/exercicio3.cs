/*
    Objetivo do programa: Perguntar o nome de um aluno, pergunte as 4 notas e calcule a média aritmética, exibindo no final.
    Data da criacao: 2025-08-28
    Criado por: @programacaomentoria
    Alterado por: @rafaelfischer
*/
using System;

namespace ConsoleApp.exercicios.grupo_1.exercicio3 { 
    public class Exercicios3 { 
        public static void Main(string[] args) { 
            Console.WriteLine("Exercicio 3 - Calculo de media aritmetica");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            float nota3 = float.Parse(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            float nota4 = float.Parse(Console.ReadLine());
            
            float media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine($"A media do aluno {nome} e: {media:F2}");
        } 
    } 
}