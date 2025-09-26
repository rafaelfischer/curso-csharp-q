/*
Objetivo do programa: Aceitar Convite: Um convite será aceito se a pessoa for "amigo" OU for "familia" E estiver disponível. Peça o tipo de relação e a disponibilidade ("sim"/"não").
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio30;

public class Exercicio30 {
    public static void Main(string[] args) {
        Console.WriteLine("Qual o tipo de relação? (amigo/familia)");
        string relacao = Console.ReadLine().ToLower();
        
        Console.WriteLine("Está disponível? (sim/não)");
        string disponivel = Console.ReadLine().ToLower();
        
        bool aceito = relacao.Equals("amigo") || 
                       (relacao.Equals("familia") && disponivel.Equals("sim"));
        
        Console.WriteLine(aceito ? "Convite aceito" : "Convite não aceito");
    }
}