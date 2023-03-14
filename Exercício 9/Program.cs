namespace Exercício_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNotas;
            double[] notas;
            double mediaHarmonica;

            Console.WriteLine("Cálculo da média de notas do Aluno:");


            Console.WriteLine("Digite a quantidade de notas do aluno:");
            quantidadeNotas = int.Parse(Console.ReadLine());

            notas = new double[quantidadeNotas];

            for (int i = 0; i < quantidadeNotas; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1}:");
                notas[i] = double.Parse(Console.ReadLine());
            }

            mediaHarmonica = quantidadeNotas / (1.0 / notas.Sum(x => 1.0 / x));


            Console.WriteLine($"A média harmônica das notas é: {mediaHarmonica:F2}");
        }
    }
}

//Crie um programa para calcular a média harmônica das notas de um Aluno//