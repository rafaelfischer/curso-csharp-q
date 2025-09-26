
namespace ConsoleApp.exercicios.grupo_2.Exercicio23;

public class Exercicio23 {
    public static void Main(string[] args) {
        Console.Write("Digite sua renda mensal: R$ ");
        double renda = double.Parse(Console.ReadLine());
        
        Console.Write("Digite seu histórico de crédito (Bom / Ruim): ");
        string historico = Console.ReadLine().ToLower();
        
        bool creditoAprovado = renda > 2000 || historico == "bom";
        Console.WriteLine($"Crédito {(creditoAprovado ? "Aprovado" : "Negado")}");
    }
}