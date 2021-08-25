using System;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            int co1;
            int co2;

		    Console.Write("\nEncontre qual é o quadrante do ponto no plano cartesiano:\n");
		    Console.Write("------------------------------------------------------\n");

            Console.WriteLine("Entre o valor da coordenada do eixo X:");
            co1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre o valor da coordenada do eixo Y:");
            co2 = Convert.ToInt32(Console.ReadLine());

            if (co1 > 0 && co2 > 0)
                Console.WriteLine("A coordenada do ponto {0}, {1} se encontra no primeiro quadrante", co1, co2);
            else if (co1 < 0 && co2 > 0)            
                Console.WriteLine("A coordenada do ponto {0}, {1} se encontra no segundo quadrante", co1, co2);
            else if (co1 < 0 && co2 < 0)
                Console.WriteLine("A coordenada do ponto {0}, {1} se encontra no terceiro quadrante", co1, co2);
            else if (co1 > 0 && co2 < 0)
                Console.WriteLine("A coordenada do ponto {0}, {1} se encontra no quarto quadrante", co1, co2);
            else if (co1 == 0 && co2 == 0)
                Console.WriteLine("A coordenada do ponto {0}, {1} se encontra no origem quadrante", co1, co2);
            Console.ReadLine();
        }
    }
}
