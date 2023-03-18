namespace Exercício_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo da média de duas provas realizadas pelo aluno:");

            Console.WriteLine("Digite a nota da primeira prova:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota da segunda prova:");
            double nota2 = double.Parse(Console.ReadLine());

            double mediaPonderada = (nota1 * 2 + nota2 * 3) / 5;

            Console.WriteLine($"A média ponderada das provas é: {mediaPonderada}");
        }
    }
}

//Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno//