﻿namespace Exercício_20
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", num);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", num);
            }

            Console.ReadKey();
        }
    }
}

//Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar