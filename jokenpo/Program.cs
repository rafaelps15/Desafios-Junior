using System;

namespace jokenpo
{
    class Program
    {
        /*Exercício Jo Ken Po:
        solicite ao usuário escolher entre pedra papel ou tesoura, depois faça com que
        o computador escolha de forma aleatória uma das opções, e retorne ao usuário se 
        o resultado foi Vitoria  empate ou derrota, após isso pergunte se ele deseja
        continuar a jogar, se sim repita o processo;

        O usuário deve digitar 0 para pedra, 1 para papel e 2 para tesoura
        Pedra ganha da tesoura (amassando-a ou quebrando-a).
        Tesoura ganha do papel(cortando-o).
        Papel ganha da pedra(embrulhando-a).
        */
        static void Main(string[] args)
        {
            Console.WriteLine("JoKenPo contra a maquina \n");
            Console.WriteLine("Digite [1] Pedra: \n");
            Console.WriteLine("Digite [2] Papel: \n");
            Console.WriteLine("Digite [3] Tesoura: \n");

            int joken = int.Parse(Console.ReadLine());
            while ((joken <= 0) || (joken >= 4))
            {
                Console.WriteLine("Opção invalida \n");
                Console.WriteLine("Digite novamente: ");
                joken = int.Parse(Console.ReadLine());
            }

            switch (joken)
            {
                case 1:
                    Console.WriteLine("Você é pedra");
                    break;
                case 2:
                    Console.WriteLine("Você é papel");
                    break;
                case 3:
                    Console.WriteLine("Você é tesoura");
                    break;
            }
            //Aleatório
            var randon = new Random();
            int jokenMaquina = randon.Next(1, 3);
            switch (jokenMaquina)
            {
                case 1:
                    Console.WriteLine("O computador é pedra\n");
                    break;
                case 2:
                    Console.WriteLine("O computador é papel\n");
                    break;
                case 3:
                    Console.WriteLine("O computador é tesoura");
                    break;
            }

            while (joken == jokenMaquina)
            {
                Console.WriteLine("O jogo empatou\n");
                Console.WriteLine("Para jogar novamente aperte [1] pedra , [2] Papel ou [3] Tesoura");
                joken = int.Parse(Console.ReadLine());
                while ((joken <= 0) || (joken >= 4))
                {
                    Console.WriteLine("Opção inválida\n");
                    Console.WriteLine("Digite novamente: ");
                    joken = int.Parse(Console.ReadLine());
                }

                switch (joken)
                {
                    case 1:
                        Console.WriteLine("Você é pedra");
                        break;
                    case 2:
                        Console.WriteLine("Você é papel");
                        break;
                    case 3:
                        Console.WriteLine("Você é tesoura");
                        break;
                }
  
            }
            if (((joken == 1) && (jokenMaquina == 3)) || ((joken == 2) && (jokenMaquina == 1)) || ((joken == 3) && (jokenMaquina == 2)))
                Console.WriteLine("Você é o vitorioso");
            else
                Console.WriteLine("Você é o perdedor");
        }
    }
}
