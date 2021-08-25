using System;

namespace ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int i;
            int num;
            int soma = 0;

            Console.WriteLine("Digite o número de elementos que devem ser adcionados no array: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Inserie {0} elementos no array:\n", num);

            // percorre o vetor e adciona a entrada do teclado
            for (i = 0; i < num; i++)
            {
                Console.WriteLine("elemento-{0}", i);
                a[i] = Convert.ToInt32(Console.ReadLine());            
            }

            // faz a soma dos valores
            for (i = 0; i < num; i++)
                soma+= a[i];
            
            Console.WriteLine("A soma de todos os elementos do array é: {0}", soma);
            Console.ReadLine();
        }
    }
}
