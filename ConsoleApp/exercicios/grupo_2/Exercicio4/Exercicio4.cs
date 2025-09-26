/*
	Objetivo do programa: Pergunte a data de nascimento e verifique se a data atual é a data de aniversário.
                            Se for, printe a mensagem de Feliz Aniversário, senão printe a mensagem hoje e dia X de Y
                            de ZZZZ.
    Data da criacao: 2025-09-23
    Criado por: @rafaelfischer
*/

namespace ConsoleApp.exercicios.grupo_2.Exercicio4 {
    internal class Exercicio4 {
        public static void Main(string[] args) {
            // Solicita a data de nascimentoimento
            Console.Write("Digite o dia do seu nascimento: ");
            int diaNascimento = int.Parse(Console.ReadLine());

            Console.Write("Digite o mes do seu nascimento: ");
            int mesNascimento = int.Parse(Console.ReadLine());

            // Obtém a data atual
            DateTime hoje = DateTime.Now;
            int diaAtual = hoje.Day;
            int mesAtual = hoje.Month;
            int anoAtual = hoje.Year;

            // Verifica se é aniversário
            if (diaNascimento == diaAtual && mesNascimento == mesAtual) {
                Console.WriteLine("Feliz Aniversário!");
            }
            else {
                Console.WriteLine($"Hoje eh dia {diaAtual} de {mesAtual} de {anoAtual}");
            }
        }
    }
}