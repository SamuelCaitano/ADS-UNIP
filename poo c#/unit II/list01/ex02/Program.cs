using System;

namespace ex02
{
    class Program
    {
        public static void Main()
        {        
            int ch = 0;
            int word = 1;
            string str;

            Console.Write("\n Contar o número total de palavras em uma string:\n");
            Console.Write("-------------------------------------------------\n");
            Console.Write(" Digite a string: ");
            str = Console.ReadLine();

            /* repetindo até o fim da string */
            while (ch <= str.Length - 1)
            {
                /* verifica se o caracter atual é um espaço em branco, uma nova linha ou um tab character*/
                if (str[ch] == ' ' || str[ch] == '\n' || str[ch] == '\t')
                {
                    word++;
                }

                ch++;
            }            
            Console.Write("-------------------------------------------------\n");
            Console.Write(" Total de palavras na string: {0}\n", word);
            Console.ReadLine();
        }
    }
}
