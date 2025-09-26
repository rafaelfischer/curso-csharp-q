/*
Objetivo do programa: Pergunte o número do mês (1 a 12). Diga quantos dias ele tem (ano não bissexto). Atenção, utilize a estrutura CASE.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/

namespace ConsoleApp.exercicios.grupo_2.Exercicio9 {
    internal class Exercicio9 {
        public static void Main(string[] args) {
            Console.Write("Digite o número do mês (1-12): ");
            int mes = int.Parse(Console.ReadLine());
            int dias;
            
            switch (mes) {
                case 2:
                    dias = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    dias = 30;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    dias = 31;
                    break;
                default:
                    Console.WriteLine("Mês inválido!");
                    return;
            }
            Console.WriteLine($"O mês {mes} tem {dias} dias.");
        }
    }
}