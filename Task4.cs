using System;

namespace Задача_4
{
    class Task4
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int n = 0;
                while (true)
                {
                    Console.Write("Введите N  - ");   //Вывод  строки
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                        Console.WriteLine("A должно быть больше 1! Попробуйте еще раз...");
                    else
                        break;
                }
                int r = 0;
                int m = 0;
                while (true)
                {
                    Console.Write("Задайте B: ");
                    m = int.Parse(Console.ReadLine());
                    if (m >= 1000)
                        Console.WriteLine("B должно быть меньше 1000! Попробуйте еще раз...");
                    else
                        break;
                }            // преобразование строки в целое число

                if (n == m)
                {
                    r = (n + m) * 2;
                }
                if (n > m)
                {
                    r = (n + m) - m;
                }
                if (n < m)
                {
                    r = (n + m) * 2 - n;
                }
                Console.WriteLine("Result - " + r);
                Console.ReadKey();
            }
        }
    }
}
