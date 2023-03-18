namespace Exercício_18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = int.Parse(Console.ReadLine());

            // Verifica qual é o maior valor
            int maior = valor1;
            if (valor2 > maior)
            {
                maior = valor2;
            }
            if (valor3 > maior)
            {
                maior = valor3;
            }

            // Verifica qual é o menor valor
            int menor = valor1;
            if (valor2 < menor)
            {
                menor = valor2;
            }
            if (valor3 < menor)
            {
                menor = valor3;
            }

            // Calcula o valor do meio
            int meio = valor1 + valor2 + valor3 - maior - menor;

            // Mostra os valores em ordem decrescente
            Console.WriteLine("{0} {1} {2}", maior, meio, menor);

            Console.ReadKey();
        }
    }
}

//Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.