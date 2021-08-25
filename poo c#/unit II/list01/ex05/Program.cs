using System;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int j;
            
            Console.WriteLine("\nDigite o numero que deseja calcular a tabuada:");
            num = Convert.ToInt32(Console.ReadLine());

            for (j = 1; j <=10; j++)
            {
                System.Console.WriteLine("{0} x {1} = {2}", num, j, num * j );
            }
            Console.ReadLine();
        }
    }
}
