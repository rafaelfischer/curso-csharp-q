/*
Objetivo do programa: Critério de Doação de Sangue: Uma pessoa pode doar sangue se tiver entre 18 E 69 anos E pesar no mínimo 50 kg. Peça idade e peso e informe se a pessoa pode doar.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio29;

public class Exercicio29 {
    public static void Main(string[] args) {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Digite seu peso (em kg): ");
        double peso = double.Parse(Console.ReadLine());

        if (idade >= 18 && idade <= 69 && peso >= 50) {
            Console.WriteLine("Você pode doar sangue.");
        }
        else {
            Console.WriteLine("Você não pode doar sangue.");
        }
    }
}