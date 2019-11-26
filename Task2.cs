using System;
using System.Text;


namespace ConsoleApp1
{
    class Task2
    {
        static void Main(string[] args)
        {
            string buf;
            int summ = 0, summ_2 = 0, pr = 0;
                           // преобразование строки в целое число


            while (true)
            {
                int k = 4;
                while (true)
                {
                    Console.Write("Задайте N: ");
                    k = int.Parse(Console.ReadLine());
                    if (k % 2 == 1)
                      if  (k <= 3)
                    {
                        Console.WriteLine(" 'ЭТО число нечетное, нужно четное");
                            

                        }
                    if (k <= 3) 
                    {
                        Console.WriteLine("A должно быть больше 4! Попробуйте еще раз...");

                    }
                 
                    else
                        break;
                }

                int s = 0;
                while (true)
                {
                    Console.Write("Задайте M: ");
                    s = int.Parse(Console.ReadLine());
                    if ( s >= 20)
                        Console.WriteLine("B должно быть меньше 20! Попробуйте еще раз...");
                    else
                        break;
                }

                int[] mass = new int[k + 1];
                for (int i = 1; i < k + 1; i++)
                {
                    Console.Write(i + " - шина - ");   //Вывод  строки
                    buf = Console.ReadLine();
                    mass[i] = Convert.ToInt32(buf);                 // преобразование строки в целое число
                    if (i <= k / 2)
                    {
                        summ = summ + mass[i];
                    }
                    else
                    {
                        summ_2 = summ_2 + mass[i];
                    }

                }
                int r = summ / summ_2;
                if (s == k)
                {
                    pr = summ_2 / 2 / k * r;
                    pr = pr + ((summ_2 / 2) - pr) * r;
                }
                if (s > k)
                {
                    pr = summ_2 / 2 * (s - k);
                }
                Console.WriteLine("Proedet - " + pr);
                Console.ReadKey();

            }
        }

    }
}
