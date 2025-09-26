/*
Objetivo do programa: Pergunte um número de 1 a 7. Diga a qual dia da semana esse número é correspondente (1 = Domingo, 2 = Segunda, ..., 7 = Sábado). Atenção, utilize a estrutura CASE.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/

namespace ConsoleApp.exercicios.grupo_2.Exercicio7 {
    internal class Exercicio7 {
        public static void Main(string[] args) {
            Console.Write("Digite um número (1-7): ");
            int numero = int.Parse(Console.ReadLine());
            
            switch (numero) {
                case 1:
                    Console.WriteLine("Domingo");
                    break;
                case 2:
                    Console.WriteLine("Segunda");
                    break;
                case 3:
                    Console.WriteLine("Terça");
                    break;
                case 4:
                    Console.WriteLine("Quarta");
                    break;
                case 5:
                    Console.WriteLine("Quinta");
                    break;
                case 6:
                    Console.WriteLine("Sexta");
                    break;
                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Número inválido");
                    break;
            }
        }
    }
}