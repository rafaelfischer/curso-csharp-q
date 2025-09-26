/*
Objetivo do programa: Dia da Semana: Peça um número de 1 a 7 e imprima o nome do dia da semana correspondente (1 para Domingo, 2 para Segunda, etc.). Se o número for inválido, informe.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio18;

public class Exercicio18 {
    public static void Main(string[] args) {
        Console.Write("Digite um número entre 1 e 7: ");
        int numero = int.Parse(Console.ReadLine());

        switch (numero) {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Número inválido! Digite um número entre 1 e 7.");
                break;
        }
    }
}