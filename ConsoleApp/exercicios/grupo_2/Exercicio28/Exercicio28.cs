/*
Objetivo do programa: Exclusão de Desconto: Um desconto de 15% é aplicado, EXCETO se o produto for da categoria "Eletrônicos" E o valor for inferior a R$500. Peça a categoria e o valor, e diga se o desconto se aplica. (Use NÃO ou negue a condição do E)
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio28;

public class Exercicio28 {
    public static void Main(string[] args) {
        Console.Write("Digite a categoria do produto: ");
        string categoria = Console.ReadLine();
        
        Console.Write("Digite o valor do produto: ");
        double valor = double.Parse(Console.ReadLine());
        
        bool aplicaDesconto = !(categoria.Equals("Eletronicos", StringComparison.OrdinalIgnoreCase) && valor < 500);
        
        if (aplicaDesconto) {
            Console.WriteLine("O desconto de 15% será aplicado.");
        }
        else {
            Console.WriteLine("O desconto não será aplicado.");
        }
    }
}