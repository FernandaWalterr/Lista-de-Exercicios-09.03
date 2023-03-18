namespace Exercício_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do volume de uma esfera:");


            Console.WriteLine("Digite o raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());

            double volume = (4.0 / 3.0) * 3.14159 * Math.Pow(raio, 3);


            Console.WriteLine($"O volume da esfera é: {volume} ");
        }
    }
}

//Crie um programa para calcular o volume de uma esfera//