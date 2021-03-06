﻿namespace _01.BinomialCoefficients
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());
            var firstRow = new long[n + 1];
            var secondRow = new long[n + 1];
            firstRow[0] = 1;
            secondRow[0] = 1;
            secondRow[1] = 1;

            if (k > n)
            {
                Console.WriteLine(0);
            }

            for (int i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 1; j < i; j++)
                    {
                        firstRow[j] = secondRow[j - 1] + secondRow[j];
                    }

                    firstRow[i] = 1;
                }
                else
                {
                    for (int j = 1; j < i; j++)
                    {
                        secondRow[j] = firstRow[j - 1] + firstRow[j];
                    }

                    secondRow[i] = 1;
                }
            }

            if (n % 2 == 0)
            {
                Console.WriteLine(firstRow[k]);
            }
            else
            {
                Console.WriteLine(secondRow[k]);
            }
        }
    }
}
