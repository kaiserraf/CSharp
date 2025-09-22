//  mais um arquivo pra aula pq o outro tava virando varzea

using System;
using System.Net.NetworkInformation;
namespace AulaCSharpPt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;

            // Atividade 01:

            int[] vetor = { -59, 21, 48 };
            

            Console.WriteLine("Digite um Valor: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um Valor: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Valor(num1, num2));

            Console.ReadLine();


            Vetores(j);
            Atividade1(vetor, j);

            Atividade2Calculadora();

        }

        static void Espacamento(int num1)
        {
            Console.WriteLine("Olá mundo");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" -", i + num1);
            }

        }

        // metodo com argumentos

        public static int Valor(int v1, int v2)
        {
            int mostrarValor = v1 + v2;

            return mostrarValor;
        }

        public static void Atividade1(int[] vetor, int j)
        {

            int menor = vetor[0];

            while (j < vetor.Length)
            {
                Console.WriteLine(vetor[j]);
                j++;
            }

            int somaArray = vetor[0] + vetor[1] + vetor[2];
            Console.WriteLine(somaArray);

            Console.WriteLine(somaArray / vetor.Length);

            for(j = 0; j < vetor.Length; j++)
            {
                if (vetor[j] < menor)
                {
                    menor = vetor[j];
                }
            }

            Console.WriteLine(menor);
        }

        public static void Vetores(int j)
        {
            int[] vet = new int[3];
            int[] vet2 = { 1, 2, 3 };

            while (j < vet.Length)
            {
                Console.WriteLine(vet[j]);
                j++;
            }

            while (j < vet2.Length)
            {
                Console.WriteLine(vet2[j]);
                j++;
            }

            foreach (int i in vet)
            {
                Console.WriteLine(vet[0]);
            }
        }


        public static void Atividade2Calculadora()
        {

            float valor1, valor2;
            char operador;

            Console.WriteLine("=====================");
            Console.WriteLine("     CALCULADORA     ");
            Console.WriteLine("=====================");


            Console.WriteLine("Digite um primeiro valor: ");
            valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite um operador valor (+ / - *): ");
            operador = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite um segundo valor: ");
            valor2 = float.Parse(Console.ReadLine());

            if(operador == '+')
            {
                Console.WriteLine(valor1 + valor2);
            }
            else if(operador == '-')
            {
                Console.WriteLine(valor1 - valor2);
            }
            else if(operador == '/')
            {
                if(valor2 == 0)
                {
                    Console.WriteLine("Não é possivel dividir por 0!");
                    return;
                }
                else
                {
                    Console.WriteLine(valor1 / valor2);
                }
                    
            }
            else if(operador == '*')
            {
                Console.WriteLine(valor1 * valor2);
            }
            else
            {
                Console.WriteLine("Digite um operador válido!");
            }


        }
    }
}


/*
    === ATIVIDADE DE SALA ===
    Atividade 1: -> arrays
        - mostrar todos os itens
        - mostrar a soma dos itens
        - mostrar a media
        - maior numero

    atividade 2:
        - fazer calculadora
    atividade 3:
 
 */