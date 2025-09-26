/*
Objetivo do programa: Verificar Idade para Votar: Crie um algoritmo que receba a idade de uma pessoa e informe se ela já pode votar (idade igual ou superior a 16 anos).
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio12;

public class Exercicio12 {
    public static void Main(string[] args) {
        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());
        
        if (idade >= 16) {
            Console.WriteLine("Você já pode votar!");
        }
        else {
            Console.WriteLine("Você ainda não pode votar.");
        }
    }
}