﻿namespace _2._Enter_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int start = 1;
            int end = 100;
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {

                try
                {
                    array[i] = ReadNumber(start, end);


                    if (array[i] <= start || array[i] > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number");
                    i--;
                    continue;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Number must be bigger than {0} and smaller than {1}!", start, end);
                    i--;
                    continue;
                }


                start = array[i];
            }

            Console.Write("Your numbers are: ");
            Console.WriteLine(string.Join(" ", array));
        }

        public static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int num;
            while (!int.TryParse(input, out num))
            {
                throw new FormatException();
            }


            return num;

        }
    }
}
