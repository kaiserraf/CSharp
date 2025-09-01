using System;

namespace anoBissexto
{
     class Program
    {
        static void Main()
        {

            int ano;

            Console.WriteLine("Descobrir se o ano é bissexto");
            Console.WriteLine("Digite um ano: ");
            string entrada = Console.ReadLine();
            ano = int.Parse(entrada);

            if((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine($"o ano {ano} é bissexto");
            }
            else
            {
                Console.WriteLine($"o ano {ano} não é bissexto");
            }

            Console.WriteLine("========================================");
            Console.WriteLine("Rafael de Oliveira Machado - 2025105563");
            Console.WriteLine("Matheus Sizanoski Figueiredo - 2025105007");
            Console.WriteLine("Lucas Vinicius Barros Dias - 2025105450");
            Console.WriteLine("Rafael Martins Schreurs de Sales - 2025105454");
            Console.WriteLine("========================================");
        }
    }
}