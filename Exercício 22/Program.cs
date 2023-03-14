namespace Exercício_22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;

            Console.WriteLine("O resultado da soma de A e B é {0}.", c);

            Console.ReadKey();
        }
    }
}

//Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo
//na tela