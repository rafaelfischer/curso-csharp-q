
namespace ConsoleApp.exercicios.grupo_2.Exercicio24;

public class Exercicio24 {
    public static void Main(string[] args) {
        Console.Write("Digite um ano: ");
        int ano = int.Parse(Console.ReadLine());

        bool ehBissexto = (ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0);
        if (ehBissexto) {
            Console.WriteLine($"{ano} é um ano bissexto.");
        }
        else {
            Console.WriteLine($"{ano} não é um ano bissexto.");
        }
    }
}