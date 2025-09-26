/*
	Objetivo do programa: Pergunte um número. Diga se este numero é par ou ímpar, escrevendo na tela.
    Data da criacao: 2025-09-23
    Criado por: @rafaelfischer
*/

namespace ConsoleApp.exercicios.grupo_2.Exercicio1  {
    internal class Exercicio1 {
        public static void Main(string[] args) {
            int numero;

            Console.WriteLine("Par ou Impar");
            Console.WriteLine("-----------------------");

            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) {
                Console.WriteLine($"O numero {numero} eh par.");
            }
            else {
                Console.WriteLine($"O numero {numero} eh impar.");
            }
        }
    }
}