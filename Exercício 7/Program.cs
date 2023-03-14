namespace Exercício_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo do salário total de um vendedor:");


            Console.WriteLine("Digite o valor do salário base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor total das vendas: ");
            double totalVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o percentual de comissão: ");
            double comissao = double.Parse(Console.ReadLine());

            double salarioTotal = salarioBase + (totalVendas * comissao / 100.0);


            Console.WriteLine($"O salário total do vendedor é: R${salarioTotal}");
        }
    }
}

//Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de
//vendas.A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.//