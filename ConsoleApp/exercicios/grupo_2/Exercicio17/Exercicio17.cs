/*
Objetivo do programa: Desconto por Compra: Uma loja oferece 10% de desconto se o valor da compra for superior a R$100,00. Leia o valor da compra e mostre o valor final com ou sem desconto.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio17;

public class Exercicio17 {
    public static void Main(string[] args) {
        Console.Write("Digite o valor da compra: R$ ");
        double valorCompra = double.Parse(Console.ReadLine());
        double desconto = 10; // porcentagem de desconto
        
        if (valorCompra > 100.0) {
            double valorDesconto = valorCompra * (desconto / 100);   // calcula 10% de desconto
            Console.WriteLine($"Valor com desconto de {desconto}%: R$ {(valorCompra - valorDesconto):F2} - Valor do desconto: R$ {valorDesconto:F2}");
        }
        else {
            Console.WriteLine($"Valor sem desconto: R$ {valorCompra:F2}");
        }
    }
}