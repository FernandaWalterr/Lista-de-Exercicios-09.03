namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // V= l x w x h

            Console.WriteLine("Cálculo de volume de um retangulo: ");


            Console.WriteLine("Digite a largura do retangulo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite altura do retangulo: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do retangulo: ");
            double comprimento = double.Parse(Console.ReadLine());

            double volume = largura * comprimento * altura;
        

            Console.WriteLine($"O volume deste retangulo é {volume} metros cúbicos");
        }
    }
}

//Crie um programa para calcular o volume de uma caixa retangular//