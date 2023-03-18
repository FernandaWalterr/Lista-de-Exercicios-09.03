namespace Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo para converter Celsius para Fahrenheit:"); 


            Console.WriteLine("Digite a escala em Celsius: ");
            double escalaCelsius = double.Parse(Console.ReadLine());

            double resultado = Math.Round((escalaCelsius * 9.0 / 5.0) + 32, 2);


            Console.WriteLine($"A temperatura em Fahrenheit é: {resultado} ");
        }
    }
}
//Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit//