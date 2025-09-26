
/*
Objetivo do programa: Permissão para Dirigir: Uma pessoa pode dirigir se tiver 18 anos ou mais E possuir CNH. Peça a idade e se possui CNH (sim/não) e informe se a pessoa pode ou não dirigir.
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio21;

public class Exercicio21 {
    public static void Main(string[] args) {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        
        // Menor de 18 anos
        if (idade < 18) {
            Console.WriteLine("Você não pode dirigir");
            return;
        }

        // Tem 18 anos ou mais
        Console.Write("Possui CNH? (Sim/Não): ");
        string temCNH = Console.ReadLine().ToLower();
        
        // Validação da resposta
        if (temCNH != "sim" && temCNH != "s" && temCNH != "não" && temCNH != "nao" && temCNH != "n") {
            Console.WriteLine("Resposta inválida. Por favor, responda com 'Sim' ou 'Não'.");
            return;
        }
        // Verifica se possui CNH
        else if (temCNH == "não" || temCNH == "nao" || temCNH == "n") {
            Console.WriteLine("Você não pode dirigir");
            return;
        }
        
        // Tem 18 anos ou mais E possui CNH   
        Console.WriteLine("Você pode dirigir");
    }
}