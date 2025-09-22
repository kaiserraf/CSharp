using System;

namespace aprenderCsharp
{
    class Program
    {

        // usando void
        static void somar5Mais5()
        {
            int numero1 = 5;
            int numero2 = 5;
            int somaTudo = numero1 + numero2;

            Console.WriteLine($"{numero1} + {numero2} = {somaTudo}");
        }

        static int retornarValorInteiro()
        {
            Console.WriteLine("Digite valor: ");
            string texto = Console.ReadLine();
            int result = 0;
            int.TryParse( texto, out result );
            return result;
        }

        static void SomarValores()
        {
            int v1 = retornarValorInteiro();
            int v2 = retornarValorInteiro();
            int somas = v1 + v2;
            Console.WriteLine($"{v1} + {v2} = {somas}" );
        }

        static void Main(string[] args)
        {

            int num1;
            int num2;
            int i = 0;
         
            // tenta converter o texto para número, se não conseguir, num1 recebe 0
            Console.WriteLine("Digite o primeiro número: ");
            
            string txt1 = Console.ReadLine();
            bool num1Valido = int.TryParse(txt1, out num1);
            
            if(num1Valido == false)
            {
                Console.WriteLine("Valor invalido");

                return;
            }

            // tenta converter o texto para número, se não conseguir, dá erro
            Console.WriteLine("Digite o segundo número: ");
            
            string txt2 = Console.ReadLine();
            num2 = int.Parse(txt2);

            int soma = num1 + num2;
            int sub = num1 - num2;
            int mult = num1 * num2;
            int div = num1 / num2;
            

            Console.WriteLine($"Primeiro número: {num1}");
            Console.WriteLine($"Segundo número: {num2}");

            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtração: {sub}");
            Console.WriteLine($"Multiplicação: {mult}");
            Console.WriteLine($"Divisão: {div}");

            // escrever texto com concatenação
            Console.WriteLine(string.Concat("A soma entre", num1, "e", num2, "é igual à:", soma));

            // escrever texto com format -> bom para laços de repetição
            string msg = "A soma entre {0} e {1} é igual à {2}";
            Console.WriteLine(string.Format(msg, num1, num2, soma));

            if(soma >= 0)
            {
                Console.WriteLine("O resultado final da soma é positivo");
            }
            else
            {
                Console.WriteLine("O resultado final da soma é negativo");
            }

            // inicio atividade de sala
            int num01, num02;

            Console.WriteLine("Digite o primeiro número (entre 1 e 10): ");
            string txt01 = Console.ReadLine();
            bool num01Valido = int.TryParse(txt01, out num01);

            if(num01Valido == false)
            {
                Console.WriteLine("valor invalido!");

                return;
            }

            if(num01 < 1 && num01 > 10)
            {
                Console.WriteLine("Valor invalido!");

                return;
            }

            Console.WriteLine("Digite o segundo número (entre 1 e 10, maior que o primeiro numero): ");
            string txt02 = Console.ReadLine();
            bool num02Valido = int.TryParse(txt02, out num02);

            if (num02Valido == false)
            {
                Console.WriteLine("valor invalido!");

                return;
            }

            if (num02 < 1 && num02 > 10 && num02 < num01)
            {
                Console.WriteLine("Valor invalido!");

                return;
            }

            // fim atividade de sala

            // tudo ta bonito hoje // laço de repetição
            while (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
            // fim laço de repetição

            //debugando no olho
            int numEscolhido;
            
            Console.WriteLine("Escolha uma tabuada: ");
            string txtNumEscolhido = Console.ReadLine();
            numEscolhido = int.Parse(txtNumEscolhido);

            while(i <= 10)
            {
                int resultado = numEscolhido * i;
                Console.WriteLine($"{numEscolhido} X {i} = {resultado}");
                i = i + 1;
            }

            
            // retornando alguma coisa

            somar5Mais5();

            retornarValorInteiro();
            SomarValores();

        } // fim main
    }
}


/*
 ESCOPO DE BLOCO - o funcionamento dela é dentro do bloco que ela faz parte
 
 */