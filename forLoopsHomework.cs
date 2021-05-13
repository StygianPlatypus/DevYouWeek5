using System;
using System.Threading;

namespace ForLoopsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Count backwards from user input
            //Console.WriteLine("Enter a number to count backwards from that number to zero.");
            //int n = Int32.Parse(Console.ReadLine());
            //n = (n - 1);
            //for (int x = n; x >= 0; x--)
            //{
            //    Console.WriteLine($"{n}");
            //    n--;
            //    Thread.Sleep(25);
            //}



            ////Count by two, starting at 0 going to 100
            //for (int i = 0; i <= 100; i = (i + 2))
            //{
            //    Console.WriteLine($"{i}");
            //    Thread.Sleep(25);
            //}



            ////Print a pattern
            //string stars = "******";
            //string numbers = "1234567";
            //int n = 6;
            //for (int i = 1; i <= 7; i++, n--)
            //{
            //    string someStars = stars.Substring(stars.Length - n, n);
            //    string someNumbers = numbers.Substring(numbers.Length - 7, i);
            //    Console.WriteLine($"{someNumbers}{someStars}");
            //}



            ////Print the Fibonacci sequence up to n terms
            //Console.WriteLine("Enter how many numbers you would like to see in the Fibonacci sequence.");
            //int n = Int32.Parse(Console.ReadLine());
            //int first = 1;
            //int second = 0;
            //int sum = 0;
            //for (int i = 1;i <= n; i++)
            //{
            //    Console.WriteLine($"{sum}");
            //    sum = (first + second);
            //    first = second;
            //    second = sum;
            //}



            //Creating a chessboard pattern
            string one = "XOXOXOXO";
            string two = "OXOXOXOX";
            int row = 0;
            for (int i = 0; i < 4; i++)
            {
                if (row == 0)
                {
                    Console.WriteLine($"{one}");
                    row = 1;                    
                }
                if (row == 1)
                {
                    Console.WriteLine($"{two}");
                    row = 0;                    
                }
            }

        }
    }
}
