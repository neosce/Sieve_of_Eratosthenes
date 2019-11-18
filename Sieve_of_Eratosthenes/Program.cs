using System;

namespace Sieve_of_Eratosthenes
{
    /// <summary>
    /// Решето Эратосфена – это алгоритм для поиска всех простых чисел от первого простого числа 2 до заданного. Этот алгоритм был разработан древнегреческим философом и математиком Эратосфеном.
    /// Описание алгоритма: Для нахождения всех простых чисел до заданного N, выписываем все числа от 2 до N.
    /// 1. Поскольку первым простым числом является 2, то удаляем из списка все кратные двойке числа.
    /// 2. Следующее число, которое осталось - 3, оно также простое. На этом шаге удаляем числа, которые делятся на три.
    /// 3. Берем следующее число и удаляем все кратные ему.
    /// 4. Повторяем цикл для всех чисел меньше N.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Sieve of Eratosthenes");
            Console.WriteLine("this algorithm for finding all primes from the first prime number 2 to a given\n");
            
            Break:
            Console.Write("Write your number N:");
            n = Convert.ToInt32(Console.ReadLine());
            
            if (n == 1 || n == 2 || n < 1 )
            {
                Console.WriteLine("Please write N > 2");
                goto Break;
            }
            else
            {
                Algorithm_Eratosthenes.SieveEratosthenes(n);
            }

            Console.ReadLine();
        }
    }
}
