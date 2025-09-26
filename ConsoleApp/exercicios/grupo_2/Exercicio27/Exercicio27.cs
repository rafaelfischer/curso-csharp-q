namespace ConsoleApp.exercicios.grupo_2.Exercicio27;

public class Exercicio27 {
    public static void Main(string[] args) {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());
        
        if (numero > 1 && numero < 10) {
            Console.WriteLine("O número está entre 1 e 10.");
        }
        else {
            Console.WriteLine("O número não está entre 1 e 10.");
        }   
    }
}