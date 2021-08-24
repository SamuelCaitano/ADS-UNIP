using System;

namespace ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num;
            int soma = 0;

            Console.WriteLine("\nDigite um número natural:");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Os primeiros {0} números naturais são:", num);
            for (i = 1; i <= num; i++)
            {
                Console.Write("{0}", i);
                if (i < num)
                    Console.Write("x");

                soma += i;
            }
            Console.WriteLine("\nA soma dos números naturais até o {0}, temos: {1}", num, soma);
            Console.ReadLine();
        }
    }
}