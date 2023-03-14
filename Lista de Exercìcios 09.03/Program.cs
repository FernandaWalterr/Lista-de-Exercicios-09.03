
using System.Reflection.Emit;

namespace Lista_de_Exercìcios_09._03

                                           ////////////// EXERCÍCIO 2 ///////////////

        //Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius

    internal class Program
    {
        static void Main(string[] args)

            Console.Title = "Conversor Fahrenheit para Celsius";

            início:
            try
        {
            Console.WriteLine("Informe a temperatura em Fahrenheit");
            decimal F = Convert.ToDecimal(Console.ReadLine());

            decimal C = (F - 32) - 5 / 9;
            C = Math.Round(C, 2);

            Console.WriteLine();

            Console.WriteLine(F );

            sair:
            Console.WriteLine();
            Console.WriteLine("Gostaria de realizar outra conversão? (S/N)");
            string Opc = Console.ReadLine();
            
            if (Opc == "S" || Opc == "s")
            {
               Console.Clear();
        }
    }
}
                                               ///////////// EXERCÍCIO 3 //////////////
       
        //Crie um programa para calcular o volume de um Cilindro                                        
                                              
     internal class Program
     {

         static void Main(string[] args)

             Console.WriteLine("Calculadora para calcular volume de um cilíndro");

        {
             
             Console.WriteLine("Digite o raio do seu cilíndro");

             double raio = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine();

             Console.WriteLine("Digite a altura do seu cilíndro");

             decimal altura = Convert.ToDecimal(Console.ReadLine());

             decimal calculo = (decimal)Math.PI = (decimal)Math.Pow(raio, 2) * altura;

             Console.WriteLine(calculo);

             Console.Readkey();
     }


                                             /////////// EXERCÍCIO 4 ///////////////

//Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem
//inicial e Final do Percurso do Veículo.Deverá ser informado o Consumo de Combustível

      internal class Program
      {

        static void Main(string[] args)


            Console.WriteLine("Digite o número de litros de combustível utilizado:");
            decimal litros = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o número de quilômetros percorridos: ");
            decimal quilometros = Convert.ToDecimal(Console.ReadLine());

            decimal calculo = quilometros / litros;

            Console.WriteLine("O consumo de combustível por quilômetro é: {0:0.00} km/l", consumo);

      }

                                              ////////////// EXERCÍCIO 5 ////////////////
                                              
//Crie um programa para calcular o volume de uma esfera                                 

