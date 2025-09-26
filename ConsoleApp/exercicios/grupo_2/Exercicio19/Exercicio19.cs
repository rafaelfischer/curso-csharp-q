/*
Objetivo do programa: Conceito por Nota: Com base na nota de um aluno (0 a 100), atribua um conceito: 
        90-100: A
        80-89: B
        70-79: C
        60-69: D
        Abaixo de 60: F
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio19;

public class Exercicio19 {
    public static string AtribuirConceito(int nota) {
        if (nota >= 90 && nota <= 100) {
            return "A";
        }
        else if (nota >= 80 && nota <= 89) {
            return "B";
        }
        else if (nota >= 70 && nota <= 79) {
            return "C";
        }
        else if (nota >= 60 && nota <= 69) {
            return "D";
        }
        else if (nota >= 0 && nota < 60) {
            return "F";
        }
        else {
            return "Nota inválida";
        }
    }

    public static void Main(string[] args) {
        Console.Write("Escolha um valor entre 0 e 100: ");
        int nota = int.Parse(Console.ReadLine());
        Console.WriteLine($"Conceito para nota {nota}: {AtribuirConceito(nota)}");
    }
}