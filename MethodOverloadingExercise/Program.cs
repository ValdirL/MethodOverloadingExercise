using System;

namespace MethodOverloadingExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool z)
        {
            var sum = x + y;

            if (z && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (z && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (z && sum == -1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return $"{sum} dollars";
            }

        }
        

    }
}
