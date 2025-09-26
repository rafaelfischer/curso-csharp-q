/*
Objetivo do programa: Temperatura Ideal para Atividade: Para praticar um esporte ao ar livre, a temperatura deve estar entre 10°C E 30°C (inclusive). Peça a temperatura e informe se é "Ideal para o esporte" ou "Não ideal".
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio25;

public class Exercicio25 {
    public static void Main(string[] args) {
        Console.Write("Digite a temperatura em °C: ");
        double temperatura = double.Parse(Console.ReadLine());
        
        if (temperatura >= 10 && temperatura <= 30) {
            Console.WriteLine("Ideal para o esporte");
        }
        else {
            Console.WriteLine("Não ideal");
        }
    }
}