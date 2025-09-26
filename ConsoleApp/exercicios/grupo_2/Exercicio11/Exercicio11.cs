/*
Objetivo do programa: Pergunte uma letra (V, A, B). Diga a cor correspondente (Vermelho, Azul, Branco). Atenção, utilize a estrutura CASE.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio11;

public class Exercicio11 {
    public static void Main(string[] args) {
        Console.Write("Digite uma letra (V, A ou B): ");
        string letra = Console.ReadLine().ToUpper();

        switch (letra) {
            case "V":
                Console.WriteLine("Vermelho");
                break;
            case "A":
                Console.WriteLine("Azul");
                break;
            case "B":
                Console.WriteLine("Branco");
                break;
            default:
                Console.WriteLine("Letra inválida");
                break;
        }
    }
}