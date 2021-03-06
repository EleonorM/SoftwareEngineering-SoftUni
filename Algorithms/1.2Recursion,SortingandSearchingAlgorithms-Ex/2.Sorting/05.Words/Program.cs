﻿namespace _05.Words
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static int count;
        static char[] symbols;

        public static void Main(string[] args)
        {
            symbols = Console.ReadLine().ToCharArray();
            if (Optimization())
            {
                return;
            }
            GeneratePermutations(0);
            Console.WriteLine(count);
        }

        private static bool Optimization()
        {
            var uniqueElements = new HashSet<char>();
            foreach (var c in symbols)
            {
                uniqueElements.Add(c);
            }

            if (uniqueElements.Count == symbols.Length)
            {
                Console.WriteLine(Fact(uniqueElements.Count));
                return true;
            }

            return false;
        }

        private static int Fact(int n)
        {
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        private static void GeneratePermutations(int index)
        {
            if (index == symbols.Length)
            {
                var isValid = true;
                for (int i = 0; i < symbols.Length - 1; i++)
                {
                    if (symbols[i] == symbols[i + 1])
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    count++;
                }

                return;
            }

            var swaped = new HashSet<char>();
            for (int i = index; i < symbols.Length; i++)
            {
                if (!swaped.Contains(symbols[i]))
                {
                    char currentSymbol = symbols[index];
                    symbols[index] = symbols[i];
                    symbols[i] = currentSymbol;

                    GeneratePermutations(index + 1);

                    swaped.Add(symbols[index]);
                    symbols[i] = symbols[index];
                    symbols[index] = currentSymbol;
                }
            }
        }
    }
}
