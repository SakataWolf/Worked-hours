using System;

namespace Horas_Trabalhada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSalário Total e excedente");
            int s, n, e, sal, hex;
            do
            {
                Console.Write("\n\nDigite o número de horas trabalhadas: ");
                n = int.Parse(Console.ReadLine());
                if (n > 50)
                {
                    e = n - 50;
                    hex = e * 20;
                    sal = 50 * 10;
                    Console.WriteLine("Salário total {0}\n\nSalário Excedente {1}", sal, hex);
                }
                else
                {
                    e = 0;
                    sal = n * 10;
                    Console.WriteLine("Salário total {0}\n\nSalário Excedente {1}", sal, e);
                }
                Console.WriteLine("\n\nDeseja continuar ? (1)Sim (2)Não");
                s = int.Parse(Console.ReadLine());
            } while(s != 2);
        }
    }
}
