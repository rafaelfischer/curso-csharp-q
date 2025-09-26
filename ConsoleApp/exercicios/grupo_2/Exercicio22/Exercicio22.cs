
namespace ConsoleApp.exercicios.grupo_2.Exercicio22;

public class Exercicio22 {
    public static void Main(string[] args) {
        string adminUsuario = "admin";
        string adminSenha = "1234";

        Console.Write("Digite o usuário: ");
        string usuario = Console.ReadLine();

        Console.Write("Digite a senha: ");
        string senha = Console.ReadLine();

        if (usuario == adminUsuario && senha == adminSenha) {
            Console.WriteLine("Acesso concedido!");
        }
        else {
            Console.WriteLine("Acesso negado!");
        }
    }
}