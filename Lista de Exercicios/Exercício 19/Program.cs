using System;

namespace Exercício_19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite a altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.Write("IMC: {0:F2} - Condição: ", imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Acima do peso");
            }
            else
            {
                Console.WriteLine("Obeso");
            }

            Console.ReadKey();
        }
    }
}

//O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre
//a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o
//peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo: IMC em adultos Condição, Abaixo de 18,5;  Abaixo do peso;  Entre 18,5 e 25 Peso normal;  Entre 25 e 30;  Acima do peso;  Acima de 30 obeso