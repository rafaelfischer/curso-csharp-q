/*
Objetivo do programa: Maior de Dois Números: Dados dois números inteiros, determine qual deles é o maior ou se são iguais.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio15;

public class Exercicio15 {
    public static void Main(string[] args) {
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());
        
        if (num1 > num2) {
            Console.WriteLine($"{num1} é maior que {num2}");
        }
        else if (num2 > num1) {
            Console.WriteLine($"{num2} é maior que {num1}");
        }
        else {
            Console.WriteLine("Os números são iguais");
        }
    }
}