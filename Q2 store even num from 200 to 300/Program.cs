using System;

namespace Q2_store_even_num_from_200_to_300
{
    // Write a program that stores even numbers from 200 to 300 in  an array
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayEven = new int[50];
            for (int i = 1; i <= 50; i++)
            {
                arrayEven[i - 1] = (200 + i) + 1 * i;
            }

            for (int i = 0; i < 50; i++)
            {
                Console.Write(arrayEven[i] + "  ");
            }
        }
    }
}
