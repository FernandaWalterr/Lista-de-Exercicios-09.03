namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a temperatura em fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            // (°F - 32) / 1.8
            double resultado = Math.Round((fahrenheit - 32) /1.8, 2);


            Console.WriteLine($"O valor convertido em Graus Celsius é {resultado}");
        }
    }
}

//Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius//