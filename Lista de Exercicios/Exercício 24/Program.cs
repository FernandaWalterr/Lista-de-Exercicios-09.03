namespace Exercício_24
{
    internal class Program
    {
        static void Main()
        {

            int soma = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 != 0 && i % 3 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("A soma dos números é: " + soma);
        }
    }
}

//Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
//encontram no conjunto dos números de 1 até 500