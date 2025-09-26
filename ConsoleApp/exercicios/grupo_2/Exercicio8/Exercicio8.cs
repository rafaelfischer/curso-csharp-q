/*
Objetivo do programa: Pergunte a nota de um aluno (de 0 a 10). Diga se o aluno está reprovado (nota < 5), em recuperação (nota entre 5 e 6.9) ou aprovado (nota ≥ 7)
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/

namespace ConsoleApp.exercicios.grupo_2.Exercicio8 {
    internal class Exercicio8 {
        public static void Main(string[] args) {
            Console.Write("Digite a nota do aluno (0 a 10): ");
            double nota = double.Parse(Console.ReadLine());

            if (nota < 5) {
                Console.WriteLine("Aluno reprovado");
            }
            else if (nota < 7) {
                Console.WriteLine("Aluno em recuperação");
            }
            else {
                Console.WriteLine("Aluno aprovado");
            }
        }
    }
}