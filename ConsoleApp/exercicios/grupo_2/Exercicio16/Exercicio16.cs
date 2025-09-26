/*
Objetivo do programa: Faixa Etária Simples: Peça a idade de uma pessoa e classifique-a como "Criança" (até 12 anos), "Adolescente" (13 a 17 anos) ou "Adulto" (18 anos ou mais).
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio16;

public class Exercicio16 {
    public static void Main(string[] args) {
        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());
        
        if (idade <= 12) {
            Console.WriteLine("Criança");
        }
        else if (idade <= 17) {
            Console.WriteLine("Adolescente");
        }
        else {
            Console.WriteLine("Adulto");
        }
    }
}