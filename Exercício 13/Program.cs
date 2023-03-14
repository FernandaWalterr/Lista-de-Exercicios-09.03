namespace Exercício_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            Console.Write("Quantidade de pães vendidos: ");
            int qtdPao = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de broas vendidas: ");
            int qtdBroa = int.Parse(Console.ReadLine());

            double valorPao = qtdPao * 0.12;
            double valorBroa = qtdBroa * 1.5;
            double totalVendas = valorPao + valorBroa;
            double poupanca = totalVendas * 0.1;


            Console.WriteLine("Valor arrecadado com as vendas: R$ " + totalVendas.ToString("F2"));
            Console.WriteLine("Valor a ser guardado na poupança: R$ " + poupanca.ToString("F2"));
        }
    }
}

//A padaria Hotpão vende uma certa quantidade de pães franceses e uma quantidade de broas a cada dia. Cada
//pãozinho custa R$ 0,12 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a
//venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado).
//Você foi contratado para fazer os cálculos para o dono. Com base nestes fatos, faça um algoritmo para ler as
//quantidades de pães e de broas, e depois calcular os dados solicitados.//