using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
namespace desafiosGPT
{
    class Program
    {
        static void Main(string[] args)
        {

            int option;

            Console.WriteLine("-----COLEÇÃO DE PROGRAMAS-----");

            Console.WriteLine("===========================");
            Console.WriteLine("1 - Calculadora Simples");
            Console.WriteLine("2 - Verifica se o número é par");
            Console.WriteLine("3 - Tabuada");
            Console.WriteLine("4 - Maior de 3");
            Console.WriteLine("5 - Conversor de temperatura");
            Console.WriteLine("6 - Contador Regressivo");
            Console.WriteLine("7 - Advinhe o número");
            Console.WriteLine("===========================");


            Console.WriteLine("Escolha uma opção: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CalculadoraSimples();
                    break;

                case 2:
                    ParImpar();
                    break;

                case 3:
                    Tabuada();
                    break;

                case 4:
                    MaiorDeTres();
                    break;

                case 5:
                    ConversorTemp();
                    break;

                case 6:
                    ContadorRegressivo();
                    break;

                case 7:
                    AdvinharNumero();
                    break;
            }

        }

        // Calculadora Simples
        static void CalculadoraSimples()
        {
            double valor1, valor2;
            double resultado;
            char operador;

            Console.WriteLine("-----CALCULADORA-----");

            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador: ");
            operador  = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = double.Parse(Console.ReadLine());

            switch (operador)
            {
                case '+':
                    resultado = valor1 + valor2;
                    Console.WriteLine($"{valor1} {operador} {valor2} = {resultado} ");
                    break;
                    
                case '-':
                    resultado = valor1 - valor2;
                    Console.WriteLine($"{valor1} {operador} {valor2} = {resultado} ");
                    break;

                case '*':
                    resultado = valor1 * valor2;
                    Console.WriteLine($"{valor1} {operador} {valor2} = {resultado} ");
                    break;

                case '/':
                    if(valor2 == 0)
                    {
                        Console.WriteLine("Erro! Divisão por 0");
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                        Console.WriteLine($"{valor1} {operador} {valor2} = {resultado} ");
                    }
                    break;

                default:
                    Console.WriteLine("Operador invalido");
                    break;
            }

        }

        // Verifica se o número é par ou impar

        static void ParImpar()
        {
            Console.WriteLine("-----VERIFICA PAR-----");

            double num;

            Console.WriteLine("Digite um valor: ");
            num = double.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }else if (num % 2 != 0)
            {
                Console.WriteLine("O número é impar");
            }

        }

        // Tabuada do número pedido

        static void Tabuada()
        {
            Console.WriteLine("------TABUADA------");

            int i;
            int vlr;

            Console.WriteLine("Digite uma tabuada: ");
            vlr = int.Parse(Console.ReadLine());

            for(i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{vlr} X {i} = {vlr * i}");
            }
        }

        // maior de tres numeros

        static void MaiorDeTres()
        {
            Console.WriteLine("-----MAIOR DE TRES-----");

            int i;
            int[] vet = new int[3];

            for(i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Digite um valor: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            int maior = vet[0];

            for (i = 0; i < vet.Length ; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];
                }
            }

            Console.WriteLine(maior);
        }

        // Conversor de temperatura - NÃO ESTA FUNCIONANDO

        static void ConversorTemp()
        {
            Console.WriteLine("-----CONVERSOR DE TEMP-----");

            double temp;
            int escolha;
            

            Console.WriteLine("===========================");
            Console.WriteLine("1 - Celsius -> Fahrenheit");
            Console.WriteLine("2 - Fahrenheit -> Celsius");
            Console.WriteLine("3 - Celsius -> Kelvin");
            Console.WriteLine("4 - Kelvin -> Celsius");
            Console.WriteLine("5 - Fahrenheit -> Kelvin");
            Console.WriteLine("6 - Kelvin -> Fahrenheit");
            Console.WriteLine("===========================");

            Console.WriteLine("Escolha uma opção (1 - 6): ");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura em Celcius: ");
                    temp = double.Parse(Console.ReadLine());

                    double celFah = temp * 1.8 + 32; // funcionando

                    Console.WriteLine($"{celFah} ºF");
                    break;

                case 2:
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    temp = double.Parse(Console.ReadLine());

                    double fahCel = (temp - 32) * 1.8; // funcionando

                    Console.WriteLine($"{fahCel} ºC");

                    break;

                case 3:
                    Console.WriteLine("Digite a temperatura em Celcius: ");
                    temp = double.Parse(Console.ReadLine());

                    double celKel = temp + 273.15; // funcionando 

                    Console.WriteLine($"{celKel} ºK");

                    break;

                case 4:
                    Console.WriteLine("Digite a temperatura em Kelvin: ");
                    temp = double.Parse(Console.ReadLine());

                    double kelCel = temp - 273.15; // funcionando

                    Console.WriteLine($"{kelCel} ºC");

                    break;

                case 5:
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    temp = double.Parse(Console.ReadLine());

                    double fahKel = (temp - 32) * 1.8 + 273.15; // funcionando

                    Console.WriteLine($"{fahKel} ºK");

                    break;

                case 6:
                    Console.WriteLine("Digite a temperatura em Kelvin: ");
                    temp = double.Parse(Console.ReadLine());

                    double kelFah = (temp - 273.15) * 1.8 + 32; // funcionando

                    Console.WriteLine($"{kelFah} ºF");

                    break;

                default:
                    Console.WriteLine("Digite um valor valido: ");
                    break;
            }
        }

        // Contador regressivo

        static void ContadorRegressivo()
        {

            Console.WriteLine("-----CONTADOR REGRESSIVO-----");

            int i, numEscolhido;

            Console.WriteLine("Escolha um número para começar a contagem regressiva: ");
            numEscolhido = int.Parse(Console.ReadLine());

            for(i = numEscolhido; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Advinhar número secreto

        static void AdvinharNumero()
        {

            Console.WriteLine("-----ADVINHE O NÚMERO ENTRE 1 E 100-----");

            int advinha;

            Random random = new Random();
            int numAleatorio = random.Next(1, 101);

            while (true)
            {
                Console.WriteLine("O número foi gerado, tente advinhar: ");
                advinha = int.Parse(Console.ReadLine());

                if (advinha == numAleatorio)
                {
                    Console.WriteLine("Parabens, você acertou o número!");
                    break;
                }
                else if (advinha != numAleatorio && advinha > numAleatorio)
                {
                    Console.WriteLine("Você errou! o número é menor do que o você escolheu...");
                    continue;
                }
                else if (advinha != numAleatorio && advinha < numAleatorio)
                {
                    Console.WriteLine("Você errou! o número é maior do que o você escolheu...");
                    continue;
                }
            }
        }
    }
}