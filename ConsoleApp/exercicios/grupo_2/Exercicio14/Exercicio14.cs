/*
Objetivo do programa: Média de Aprovação: Um aluno é aprovado se sua média final for igual ou superior a 7. Peça a nota do aluno e informe se ele foi "Aprovado" ou "Reprovado".
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio14;

public class Exercicio14 {
    public static void Main(string[] args) {
        Console.Write("Digite a nota do aluno: ");
        double nota = double.Parse(Console.ReadLine());
        
        if (nota >= 7.0) {
            Console.WriteLine("Aprovado");
        }
        else {
            Console.WriteLine("Reprovado");
        }
    }
}