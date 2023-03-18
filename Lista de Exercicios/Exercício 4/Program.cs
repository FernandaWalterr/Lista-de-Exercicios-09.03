namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo do consumo de combustível por Km:");


            Console.WriteLine("Digite a quilometragem inicial do percurso: ");
            double kmInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final do percurso: ");
            double kmFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o consumo de combustível do veículo (em litros): ");
            double consumoCombustivel = double.Parse(Console.ReadLine());

            double distanciaPercurso = kmFinal - kmInicial;
            double consumoPorKm = consumoCombustivel / distanciaPercurso;


            Console.WriteLine($"O consumo de combustível por Km foi de: {consumoPorKm} litros por Km");
        }
    }
}

//Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
//inicial e Final do Percurso do Veículo. Deverá ser informado o Consumo de Combustível//