/*
Objetivo do programa: Verificar Vogal: Peça um caractere e verifique se ele é uma vogal (a, e, i, o, u), considerando letras maiúsculas e minúsculas. Use o operador OU.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio26;

public class Exercicio26 {
    public static void Main(string[] args) {
        Console.Write("Digite um caractere: ");
        char letra = char.Parse(Console.ReadLine());
        
        bool ehVogal = letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' ||
                         letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U';
        
        if (ehVogal) {
            Console.WriteLine("O caractere é uma vogal");
        }
        else {
            Console.WriteLine("O caractere não é uma vogal");
        }
    }
}