using System;

namespace ex01
{
    class Program
    {
        public static void main(string[] args)
        {
            string username;
            string password;
            int cont = 0;
            int dd = 0;

            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("usuário: admin \nsenha: admin");
            System.Console.WriteLine("-------------------------");

            /*  executa enquanto os dados inseridos forem incorretos ou ate atingir o limite de tentativas */
            do
            {
                System.Console.WriteLine("Insira o nome do usuário: ");
                username = Console.ReadLine();

                System.Console.WriteLine("Insira a senha: ");
                password = Console.ReadLine();
                System.Console.WriteLine("-------------------------");

                // verificar se os dados inseridos estão corretos
                if (username == "admin" && password == "admin")
                {
                    dd = 1;
                    cont = 3;
                }
                else
                {
                    dd = 0;
                    cont++;
                }
            } while ((username != "username" || password != "password") && (cont != 3));

            if (dd == 1)
                System.Console.WriteLine("Senha correta!");
            else if (dd == 0)
                System.Console.WriteLine("Você excedeu as três tentativas de login!");
            
            Console.ReadLine();
        }        
    }
}
