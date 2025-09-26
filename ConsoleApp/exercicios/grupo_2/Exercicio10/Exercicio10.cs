/*
Objetivo do programa: Pergunte três números. Diga qual é o maior entre eles. Atenção, utilize a estrutura IF.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/

namespace ConsoleApp.exercicios.grupo_2.Exercicio10 {
    internal class Exercicio10 {
        public static void Main(string[] args) {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());
            
            int maior;
            
            if (num1 >= num2 && num1 >= num3) {
                maior = num1;
            }
            else if (num2 >= num1 && num2 >= num3) {
                maior = num2;
            }
            else {
                maior = num3;
            }
            
            Console.WriteLine($"O maior número é: {maior}");
        }
    }
}