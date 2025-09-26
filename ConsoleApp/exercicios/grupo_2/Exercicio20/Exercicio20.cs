/*
Objetivo do programa: Acesso ao Sistema: Um sistema requer que a senha tenha no mínimo 6 caracteres. Peça uma senha e informe se ela é "Válida" ou "Inválida".
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio20;

public class Exercicio20 {
    public static void Main(string[] args) {
        Console.WriteLine("Digite uma senha: ");
        string senha = Console.ReadLine();
        
        if (senha.Length >= 6) {
            Console.WriteLine("Válida");
        }
        else {
            Console.WriteLine("Inválida");
        }
    }
}