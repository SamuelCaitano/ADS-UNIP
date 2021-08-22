using System;

namespace ex02
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1;

            System.Console.WriteLine("Digite um número inteiro");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
                System.Console.WriteLine("{0} é um número par.", num1);
            else
                System.Console.WriteLine("{0} é um número impar.", num1);
            
            Console.Read();
        }
    }
}