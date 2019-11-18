using System;
using System.Collections.Generic;

namespace Sieve_of_Eratosthenes
{
    public class Algorithm_Eratosthenes
    {

        public static void SieveEratosthenes(int n)
        {
            Algorithm_Eratosthenes algorithm_Eratosthenes = new Algorithm_Eratosthenes();

            Console.WriteLine("SieveEratosthenes to {0}:", n);

            Console.WriteLine(string.Join(",", algorithm_Eratosthenes.Algorithm(n)));

        }

        private List<int> Algorithm(int n)
        {

            var numbers = new List<int>();

            for (int i = 2; i < n; i++)
            {
                numbers.Add(i);
            }

            for (int i = 0; i < numbers.Count; i++)
            {

                for (int j = 2; j < n; j++)
                {

                    numbers.Remove(numbers[i] * j);

                }

            }

            return numbers;

        }

    }
}
