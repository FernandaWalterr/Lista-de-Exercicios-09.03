namespace Exercício_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do volume de um cilindro: ");


            Console.WriteLine("Digite a altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o raio do cilindro: ");
            double raio = double.Parse(Console.ReadLine());

            double volume = raio * raio * altura;


            Console.WriteLine($"O volume deste cilindro é {volume}");
        }
    }
}

//Crie um programa para calcular o volume de um Cilindro//