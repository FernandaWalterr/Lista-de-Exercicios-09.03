using System.Drawing;

namespace Exercício_21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                int resultado = a + b;
                Console.WriteLine("A soma de A e B é {0}.", resultado);
            }
            else
            {
                int resultado = a * b;
                Console.WriteLine("A multiplicação de A por B é {0}.", resultado);
            }

            Console.ReadKey();
        }
    }
}

//Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
//contrário multiplique A por B