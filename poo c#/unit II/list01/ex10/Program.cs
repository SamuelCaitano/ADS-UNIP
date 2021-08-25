using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int num;
            int pos;
            int[] a = new int[100];

            Console.WriteLine("\n Deletar um elemento em um ponto desejado de um array");
            Console.WriteLine(" -----------------------------------------------------\n");
            Console.Write(" Digite o tamanho array: ");
            num = Convert.ToInt32(Console.ReadLine());

            // armazena os valores no array
            Console.WriteLine(" Digite {0} números de elementos no array \n", num);
            for (i = 0; i < num; i++)
            {
                Console.Write(" elemento-{0}:", i+1);
                a[i] = Convert.ToInt32(Console.ReadLine());                
            }

            // exibe os valores no array
            Console.WriteLine("\n Os valores armazenados no array são: ");
            for (i = 0; i < num; i++)
            {
                Console.Write(" {0}", a[i]);
            }

            // recebe a posição que será substituida no array
            Console.Write("\n Digite a posição que deseja deletar: ");
            pos = Convert.ToInt32(Console.ReadLine());

            // localiza a posição de (i) no array
            i = 0;
            while (i != pos -1)
            {
                i++;
            }

            // a posição de (i) no array será substituiida pelo valor que está a sua direita
            while(i < num)
            {
                a[i] = a[i+1];
                i++;
            }
            num--; // remove o último índice do array

            // exibe a nova lista do array
            Console.Write("\n A nova lista é: ");
            for (i = 0; i < num; i++)
            {
                Console.Write(" {0}", a[i]);
            }
            Console.ReadLine();
        }
    }
}