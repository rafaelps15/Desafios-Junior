using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAtual = 1;
            int numAnterior = 0;
            int fibonacci;

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                fibonacci = numAnterior + numAtual;
                Console.WriteLine(fibonacci);
                numAnterior = numAtual;
                numAtual = fibonacci;
            }
            Console.WriteLine();
        }
    }
}
