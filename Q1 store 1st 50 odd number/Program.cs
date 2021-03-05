using System;

namespace store_1st_50_odd_number
{
    //Write a program that stores first 50 odd numbers to an array?
    class Program
    {
        static void Main(string[] args)
        {
           
			int[] arrayOdd = new int[25];   //declaring an array of size 25
			for (int i = 1; i <= 25; i++)   //to count from 1 to 25
			{
				arrayOdd[i - 1] = 2*i-1;    //to save the odd number to the array
			}

			for (int i = 0; i < 25; i++)    //to print the array from index 0 to 25
			{
				Console.Write(arrayOdd[i] + ",");   //print each index value
			}
        }
    }
}
