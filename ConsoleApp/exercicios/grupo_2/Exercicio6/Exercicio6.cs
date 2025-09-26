/*
Objetivo do programa: Pergunte a idade de uma pessoa. Diga se essa pessoa é uma criança (até 12 anos), um adolescente (13 a 17 anos), uma adulta (18 a 59 anos) ou idosa (60 anos ou mais)
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/

namespace ConsoleApp.exercicios.grupo_2.Exercicio6 {
    internal class Exercicio6 {
        public static void Main(string[] args) {
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 12) {
                Console.WriteLine("Criança");
            }
            else if (idade <= 17) {
                Console.WriteLine("Adolescente");
            }
            else if (idade <= 59) {
                Console.WriteLine("Adulto");
            }
            else {
                Console.WriteLine("Idoso");
            }
        }
    }
}