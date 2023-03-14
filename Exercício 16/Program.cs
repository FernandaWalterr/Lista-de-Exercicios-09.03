namespace Exercício_16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o salário do funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            double aumento = salario * 0.15;
            double salarioComAumento = salario + aumento;
            double descontoImpostos = salarioComAumento * 0.08;
            double salarioFinal = salarioComAumento - descontoImpostos;

            Console.WriteLine($"Salário inicial: R${salario:N2}");
            Console.WriteLine($"Salário com aumento: R${salarioComAumento:N2}");
            Console.WriteLine($"Salário final: R${salarioFinal:N2}");
        }
    }
}

//Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de
//impostos.Imprima o salário inicial, o salário com o aumento e o salário final.