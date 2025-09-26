/*
Objetivo do programa: Decisão de Compra Online: Um usuário decide comprar um item online se o preço for menor que R$100 OU se o frete for grátis E o estoque for maior que zero. Peça o preço, se o frete é grátis ("sim"/"não") e a quantidade em estoque, e informe se o usuário irá "Comprar" ou "Não comprar".
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio35;

public class Exercicio35 {
    public static void Main(string[] args) {
        Console.Write("Digite o preço do item: R$ ");
        double preco = double.Parse(Console.ReadLine());
        
        Console.Write("O frete é grátis? (sim/não): ");
        string freteGratis = Console.ReadLine().ToLower();
        
        Console.Write("Digite a quantidade em estoque: ");
        int estoque = int.Parse(Console.ReadLine());
        
        bool deveComprar = preco < 100 || (freteGratis == "sim" && estoque > 0);
        Console.WriteLine(deveComprar ? "Comprar" : "Não comprar");
    }
}