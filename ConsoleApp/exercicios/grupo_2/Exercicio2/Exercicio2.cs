/*
	Objetivo do programa: Pergunte um número. Diga se este numero é primo ou não, escrevendo na tela.
    Data da criacao: 2025-09-23
    Criado por: @rafaelfischer
*/

namespace ConsoleApp.exercicios.grupo_2.Exercicio2 {
    internal class Exercicio2 {
        public static void Main(string[] args) {
            int numero;
            bool primo = true;

            Console.WriteLine("Eh um numero primo?");
            Console.WriteLine("-----------------------");

            Console.Write("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());

            // Por 2: Se o número for par (termina em 0, 2, 4, 6 ou 8), ele não é primo.
            // Por 3: Se a soma dos algarismos do número for divisível por 3, o número também é divisível por 3 e não é primo.
            // Por 5: Se o número terminar em 0 ou 5, ele não é primo.
            if (numero == 0) {
                primo = false;
            }
            else if (numero == 2) {
                primo = true; // 2 é primo
            }
            else if (numero % 2 == 0) {
                primo = false;
            }
            else if (numero % 3 == 0 && numero != 3) {
                primo = false;
            }
            else if (numero % 5 == 0 && numero != 5) {
                primo = false;
            }

            Console.Write($"O numero {numero} eh primo?: ");
            if (primo) {
                Console.Write("Sim");
            }
            else {
                Console.Write("Nao");
            }
            Console.WriteLine(); // Adiciona uma nova linha para melhor formatação
        }
    }
}
