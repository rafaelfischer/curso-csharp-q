/*
Objetivo do programa: Sinal do Número: Desenvolva um algoritmo que solicite um número e diga se ele é positivo, negativo ou zero.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio13;

public class Exercicio13 {
    public static void Main(string[] args) {
        Console.Write("Digite um número: ");
        double numero = double.Parse(Console.ReadLine());
        
        if (numero > 0) {
            Console.WriteLine("O número é positivo");
        }
        else if (numero < 0) {
            Console.WriteLine("O número é negativo");
        }
        else {
            Console.WriteLine("O número é zero");
        }
    }
}