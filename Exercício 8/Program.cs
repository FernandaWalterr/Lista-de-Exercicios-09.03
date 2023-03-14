namespace Exercício_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do volume de uma lata de óleo:");


            Console.WriteLine("Digite o raio da lata de óleo:");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata de óleo");
            double  altura = double.Parse(Console.ReadLine());  

            double volume = raio * raio * altura;


            Console.WriteLine($"O volume da lata de óleo é: {volume} L");
        }
    }
}

//Crie um programa para calcular o volume de uma lata de óleo//