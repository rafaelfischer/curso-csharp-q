namespace ConsoleApp.exercicios.grupo_2.Exercicio34;

public class Exercicio34 {
    public static void Main(string[] args) {
        double bonus = 500.0;
        
        Console.Write("Digite o valor das vendas: ");
        double vendas = double.Parse(Console.ReadLine());
        
        Console.Write("Digite os anos de empresa: ");
        int anosEmpresa = int.Parse(Console.ReadLine());
        
        bool metaVendas = vendas >= 10000;
        bool tempoEmpresa = anosEmpresa > 5;
        
        if (metaVendas && tempoEmpresa) {
            bonus *= 2;
        }
        else if (!metaVendas && !tempoEmpresa) {
            bonus = 0;
        }
        
        Console.WriteLine($"O bônus do funcionário é R$ {bonus:F2}");
    }
}