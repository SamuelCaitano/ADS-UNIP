using System;

namespace ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            // atributos
            int i;
            int cont;            
            int num;
            bool verif = true;
            double fat = 1; 

            Console.WriteLine("Calcular o fatorial de um número dado:");
            Console.Write("-------------------------------------------------\n");

            // verifica se o número digitado e um número natural
            do
            {
                Console.Write("Digite um número inteiro positivo:");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Por favor, insira um número natural entre 0 e 10000!");
                    verif = false;
                } else
                    verif = true;
            } while (verif == false);

            i = num; // (i) recebe o valor de (num)
            Console.Write("{0}!= ", i);
            while(i>0)
            {
                if (i>1)
                    Console.Write("{0}x", i);// exibe até o penúltimo número da repetição
                else
                    Console.Write("{0}", i);// exibe o último número sem o caractere (x)
                i--;
            }

            // calcula o fatorial
            for (cont = 1; cont <= num; cont++)
            {
                fat *= cont;                
            }

            Console.WriteLine("\nO fatorial de {0} é: {1}\n", num, fat);
            Console.ReadLine();
        }
    }
}
