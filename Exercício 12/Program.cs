namespace Exercício_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo das dimensões de um terreno:");


            Console.Write("Digite a largura do terreno em metros: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento do terreno em metros: ");
            double comprimento = double.Parse(Console.ReadLine());

            double area = largura * comprimento;


            Console.WriteLine("A área do terreno é {0} metros quadrados.", area);
        }
    }
}

//A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um
//terreno e depois exibir a área do terreno.//