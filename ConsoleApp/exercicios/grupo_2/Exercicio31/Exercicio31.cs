/*
Objetivo do programa: Classificação de Triângulos: Dados três valores que representam os lados de um triângulo, determine:
                    - Se eles formam um triângulo (a soma de dois lados deve ser sempre maior que o terceiro lado).
                    - Se for um triângulo, classifique-o como "Equilátero" (todos os lados iguais), "Isósceles" (dois lados iguais) ou "Escaleno" (todos os lados diferentes).
Data da criacao: 2025-09-25
Criado por: @rafaelfischer
*/
namespace ConsoleApp.exercicios.grupo_2.Exercicio31;

public class Exercicio31 {
    public static void Main(string[] args) {
        Console.WriteLine("Digite o primeiro lado do triângulo:");
        double lado1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o segundo lado do triângulo:");
        double lado2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o terceiro lado do triângulo:");
        double lado3 = double.Parse(Console.ReadLine());
        
        if (IsTriangulo(lado1, lado2, lado3)) {
            string tipo = ClassificarTriangulo(lado1, lado2, lado3);
            Console.WriteLine("É um triângulo " + tipo);
        }
        else {
            Console.WriteLine("Não forma um triângulo");
        }
    }
    
    private static bool IsTriangulo(double lado1, double lado2, double lado3) {
        return (lado1 + lado2 > lado3) && (lado2 + lado3 > lado1) && (lado1 + lado3 > lado2);
    }
    
    private static string ClassificarTriangulo(double lado1, double lado2, double lado3) {
        if (lado1 == lado2 && lado2 == lado3) {
            return "Equilátero";
        }
        else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3) {
            return "Isósceles";
        }
        else {
            return "Escaleno";
        }
    }
}
