namespace ConsoleApp.exercicios.grupo_2.Exercicio36 {
    using System;

    public class Exercicio36 {
        public static void Main(string[] args) {
            Console.Write("Digite o valor da compra: R$ ");
            double totalDesconto = 10;
            double valor = double.Parse(Console.ReadLine());
            
            if (valor > 100) {
                double desconto = valor * (totalDesconto / 100);
                Console.WriteLine($"Valor com desconto de {totalDesconto:F0}%: R$ {(valor - desconto):F2} - Valor do desconto: R$ {desconto:F2}");
            } 
            else {
                Console.WriteLine($"Valor sem desconto: R$ {valor:F2}");
            }
        }
    }
}