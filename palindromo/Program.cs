using System;

namespace palindromo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a Palavra: ");
            string palavra = Console.ReadLine();

            int letra = palavra.Length - 1;
            while (letra != -1)
            {
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == palavra[letra])
                    {
                        if (letra == 0)
                        {
                            Console.WriteLine("É Palindromo");
                            Console.WriteLine();
                        }
                        letra--;
                    }
                    else
                    {
                        Console.WriteLine("Não é Palindromo");
                        i = palavra.Length;
                        letra = -1;
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

