/*
 * DESENVOLVEDORES:
 * RAFAEL DE OLIVEIRA MACHADO - 2025105563
 * RAFAEL SALES - 2025105454s
 * LUCAS VINICIUS BARROS DIAS - 2025105450
 * MATHEUS SIZANOSKI FIGUEIREDO - 2025105007
 */

using System;
namespace jogoForca
{
    class Program
    {
        public static void Main(string[] args)
        {

            int opcao;
            int vitoria = 0;
            int derrota = 0;

            while (true)
            {
                Console.WriteLine("=================");
                Console.WriteLine("  JOGO DA VELHA  ");
                Console.WriteLine("=================");

                Console.WriteLine("Bem-Vindo ao menu do jogo!");
                Console.WriteLine("1 - Jogo");
                Console.WriteLine("2 - Vitorias/Derrotas");
                Console.WriteLine("3 - Desenvolvedores");

                Console.WriteLine("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Jogo(vitoria, derrota);
                        break;
                    case 2:
                        Console.Clear();
                        VitoriasDerrotas(vitoria, derrota);
                        break;
                    case 3:
                        Console.Clear();
                        Programadores();
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;

                }
            }


        }

        public static void Jogo(int vitoria, int derrota)
        {
            int i;
            int jogadas = 0;
            int jogadasPerdidas = 0;

            string[] palavrasForca = {
                "GIRAFA", "ELEFANTE", "TARTARUGA", "ZEBRA", "MACACO",
                "LEAO", "TIGRE", "COELHO", "CACHORRO", "GATO",
                "BANANA", "MELANCIA", "MORANGO", "ABACAXI", "LARANJA",
                "UVA", "MANGA", "KIWI", "MELAO", "FRAMBOESA",
                "BRASIL", "CANADA", "JAPAO", "AUSTRALIA", "ITALIA",
                "ESPANHA", "MEXICO", "INDIA", "EGITO", "ARGENTINA",
                "MEDICO", "PROFESSOR", "BOMBEIRO", "ENGENHEIRO", "COZINHEIRO",
                "ARTISTA", "MUSICO", "JORNALISTA", "POLICIAL", "PROGRAMADOR",
                "TELEVISAO", "CADEIRA", "COMPUTADOR", "LIVRO", "RELOGIO",
                "OCULOS", "GUARDACHUVA", "MOCHILA", "CELULAR", "LAMPADA",
                "FUTEBOL", "BASQUETE", "NATACAO", "CICLISMO", "TENIS",
                "VOLEI", "SURFE", "CORRIDA", "SKATE", "JUDO"
};

            Random random = new Random();
            int indSorteio = random.Next(palavrasForca.Length);

            String palavraEscolhida = palavrasForca[indSorteio];
            char[] letrasDescobrir = new char[palavraEscolhida.Length];
            char[] mostraTela = new char[palavraEscolhida.Length];

            letrasDescobrir = palavraEscolhida.ToCharArray();

            char letraDigitada;

            for (i = 0; i < palavraEscolhida.Length; i++)
            {
                mostraTela[i] = '_';
            }

            while (true)
            {
                Console.WriteLine(mostraTela);
                Console.WriteLine("Digite uma letra: ");
                letraDigitada = char.Parse(Console.ReadLine().ToUpper());

                // checando letra
                for (i = 0; i < palavraEscolhida.Length; i++)
                {
                    if (letraDigitada == letrasDescobrir[i])
                    {
                        mostraTela[i] = letraDigitada;
                        jogadas++;
                    }
                }

                // vitória
                if (!mostraTela.Contains('_'))
                {
                    Console.WriteLine("Parabéns, você ganhou!");
                    break;
                    vitoria++;
                }

                // derrota
                if (jogadas >= 10)
                {
                    Console.WriteLine("Você perdeu! A palavra era: " + palavraEscolhida);
                    break;
                    derrota++;
                }

                continue;


            }
        }

        public static void Programadores()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("               DESENVOLVEDORES:               ");
            Console.WriteLine("RAFAEL DE OLIVEIRA MACHADO - 2025105563");
            Console.WriteLine("RAFAEL SALES - 2025105454");
            Console.WriteLine("MATHEUS SIZANOSKI FIGUEIREDO - 2025105007");
            Console.WriteLine("LUCAS VINICIUS BARROS DIAS - 2025105450");
            Console.WriteLine("==============================================");
        }

        public static void VitoriasDerrotas(int vitoria, int derrota)
        {
            Console.WriteLine("=======================");
            Console.WriteLine("  DERROTAS E VITORIAS  ");
            Console.WriteLine("=======================");
            Console.WriteLine("Vitorias: " + vitoria);
            Console.WriteLine("Derrotas: " + derrota);
        }
    }
}

/*
 lógica jogo da forca:
1. criar um array de palavras
2. sortear uma palavra
3. criar um array de char para armazenar as letras descobertas
4. criar um loop para o jogo
5. mostrar o array de char com as letras descobertas
6. pedir uma letra ao jogador
7. verificar se a letra está na palavra
8. se estiver, atualizar o array de char com a letra descoberta
9. se não estiver, incrementar o número de tentativas erradas
10. verificar se o jogador ganhou (todas as letras descobertas) ou perdeu (número máximo de tentativas erradas)
=================================================================================================================
 */