namespace ConsoleApp.exercicios.grupo_2.Exercicio33;

public class Exercicio33 {
    public static void Main(string[] args) {
        Console.Write("Digite o dia: ");
        int dia = int.Parse(Console.ReadLine());
        Console.Write("Digite o mês: ");
        int mes = int.Parse(Console.ReadLine());
        Console.Write("Digite o ano: ");
        int ano = int.Parse(Console.ReadLine());
        
        bool dataValida = ValidarData(dia, mes, ano);
        Console.WriteLine($"Data {(dataValida ? "válida" : "inválida")}");
        
    }
    
    private static bool ValidarData(int dia, int mes, int ano) {
        if (mes < 1 || mes > 12 || dia < 1) 
            return false;
        
        int[] diasPorMes = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};        
        if (mes == 2 && ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)) {
            diasPorMes[2] = 29;
        }
        
        return dia <= diasPorMes[mes];
    }
}