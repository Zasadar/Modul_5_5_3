using System.Runtime.CompilerServices;

namespace Modul_5_5_3
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Напишите чонибудь");
            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            int number = 20;
            decimal result = Factorial(number);
            Console.WriteLine("Факториал {0}", result);

            Console.WriteLine(PowerUp(2,3));

            Console.ReadKey();
        }

        static void Echo(string saidword, int deep)
        {
            var modif = saidword;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }

        }

        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            return x * Factorial(x - 1);
        }

        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
        }

    }
}
