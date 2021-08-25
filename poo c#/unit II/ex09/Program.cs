using System;

namespace ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num;
            int[] a = new int[100];

            // recebe o tamanho do array
            Console.Write("\n Digite o número de elementos para armazenar no array: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write(" --------------------------------------------------------\n");
            Console.WriteLine(" Digite {0} números de elementos no array\n", num);

            // percorre o array e adc o número informado
            for (i = 0; i < num; i++)
            {
                Console.Write(" elemento-{0}: ", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());                
            }

            // exibe os valores no array, na ordem de entrada do teclado
            Console.WriteLine("\n Os valores armazenados no array são: ");
            for (i = 0; i < num; i++)
            {
                Console.Write(" {0} ", a[i]);
            }

            // exibe os valores no array, na ordem contrária da entrada do teclado
            Console.WriteLine("\n Os valores armazenados no array em ordem contrária são:");
            for (i = num - 1; i >= 0; i--) 
            {
                Console.Write(" {0} ", a[i]);
            }

            Console.ReadLine();
        }
    }
}