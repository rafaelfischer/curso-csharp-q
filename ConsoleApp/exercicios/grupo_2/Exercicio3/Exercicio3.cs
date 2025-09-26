/*
	Objetivo do programa: Pergunte um número. Diga se este numero faz parte da tabuada do 3, escrevendo na tela.
    Data da criacao: 2025-09-23
    Criado por: @rafaelfischer
*/

namespace ConsoleApp.exercicios.grupo_2.Exercicio3 {
    internal class Exercicio3 {
        public static void Main(string[] args) {
            Console.WriteLine("Exercicio 3 - Tabuada do 3");
            Console.WriteLine("-----------------------");

            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 3 == 0) {
                Console.Write($"O numero {numero} faz parte da tabuada do 3");
            }
            else {
                Console.Write($"O numero {numero} nao faz parte da tabuada do 3");
            }
            Console.WriteLine(); // Adiciona uma nova linha para melhor formatação
        }
    }
}