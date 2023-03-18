using System.Runtime.Intrinsics.X86;

namespace Exercício_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;


            Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit}");
        }
    }
}

//Alguns países medem temperaturas em graus Celsius, e outros em graus Fahrenheit. Faça um algoritmo para ler
//uma temperatura Celsius e imprima em Fahrenheit (pesquise como fazer este tipo de conversão).