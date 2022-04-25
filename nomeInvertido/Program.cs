using System;
using System.Globalization;

namespace nomeInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] nome = new char[5];
            int vogal = 0;

            Console.WriteLine("Digite seu nome ", nome);
            Console.ReadLine();
            for (int conta = 0; nome [conta] != '\0'; conta++)
            {
                if (nome[conta] == 'a')
                {
                    vogal++;
                    Console.WriteLine("Total de ", vogal + "letras");
                    Console.Read();
                }
            }


        }
    }
}