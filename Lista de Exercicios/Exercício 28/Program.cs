namespace Exercício_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else
                {
                    Console.Write(Convert.ToString(i) + " ");
                }
            }
        }
    }
}

//Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números
//múltiplos de 3 pela palavra &quot; Fizz & quot; e os múltiplos de 5 pela palavra &quot; Buzz & quot;. Para números que são múltiplos de
//ambos, use &quot; FizzBuzz & quot;