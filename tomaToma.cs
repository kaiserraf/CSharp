using System;
namespace calendario
{
    class Program
    {
        public static void Main(string[] args)
        {

            int ano = 0, mes = 0, dia = 0, i = 0;

            string[] mesesAparecer = 
        {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"
        };

            Console.WriteLine("Digite o ano:"); // solicita o ano ao usuario
            ano = int.Parse(Console.ReadLine()); // lê o ano digitado pelo usuario

            Console.WriteLine("Digite o mês"); // msm coisa que antes
            mes = int.Parse(Console.ReadLine()); // msm coisa que antes

            DateTime primeiroDia = new DateTime(ano, mes, 1); // pega o primeiro dia do mês -> nescessario para saber o primeiro dia da semana
            int diaMes = DateTime.DaysInMonth(ano, mes); // descobre quantos dias tem no mês -> nescessario para saber os dias da semana

            // gera o cabeçalho do calendario (aqui nada será alterado (a não ser o mes que aparece))
            Console.WriteLine("====================");
            Console.WriteLine("     Calendário     ");
            Console.WriteLine("====================");
            Console.WriteLine(mesesAparecer[mes - 1]);

            Console.WriteLine("DOM SEG TER QUA QUI SEX SAB");

            int diaSemana = (int)primeiroDia.DayOfWeek; // forçando variavel int e descobre o primeiro dia da semana

            for (i = 0; i < diaSemana; i++ )
            {
                Console.Write("    "); // da o espaçamento até o primeiro dia do mes (espaços em branco no calendario)
            }

            for (dia = 1; dia <= diaMes; dia++)
            {
                Console.Write($"{dia,3} "); // escreve os dias no calendario

                if ((diaSemana + dia) % 7 == 0) //pula linha quando chega no sábado
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine();


        }

    }
}


/*
DateTime.DaysInMonth() -> recebe a quantidade de dias no mes
DateTime.DayOfWeek() -> recebe o dia da semana
*/