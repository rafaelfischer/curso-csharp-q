namespace ConsoleApp.exercicios.grupo_2.Exercicio32;

public class Exercicio32 {
    public static void Main(string[] args) {
        Console.WriteLine("Digite a classe (economica/executiva):");
        string classe = Console.ReadLine().ToLower();
        
        Console.WriteLine("Há promoção? (sim/nao):");
        string promocao = Console.ReadLine().ToLower();
        
        double preco = 0;
        
        if (classe == "economica") {
            preco = promocao == "sim" ? 300 : 500;
        }
        else if (classe == "executiva") {
            preco = promocao == "sim" ? 1000 : 1500;
        }
        
        Console.WriteLine($"O preço da passagem é R$ {preco:F2}");
    }
}