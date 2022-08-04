using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    /// <summary>
    /// Here We Check The FibonaciSeries ,In That  The Next Term Is The Sum Of Previous Two Terms. 
    /// </summary>
    public static class FibonacciSeries
    {
        /// <summary>
        /// Checking FibonacieSeries.
        /// </summary>
        public static void CalculateFibonacieSeries()
        {
            int number, n1 = 0, n2 = 1, n3;
            Console.WriteLine("**Enter the number of elements**");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");

            for (int i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
