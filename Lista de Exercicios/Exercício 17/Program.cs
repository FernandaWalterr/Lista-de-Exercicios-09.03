namespace Exercício_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o valor de A: ");
            decimal a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de B: ");
            decimal b = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o valor de C: ");
            decimal c = Convert.ToDecimal(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A soma de A e B é menor que C.");
            }
            else
            {
                Console.WriteLine("A soma de A e B não é menor que C.");
            }

            Console.ReadLine();
        }
    }
}

//Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.