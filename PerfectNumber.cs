﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    /// <summary>
    /// Here We Check The Perfect Number In That We Check The Sum Of Its Divisor Is Equal To The Number Excluding The Number Itself.
    /// </summary>
    public static class PerfectNumber
    {
        /// <summary>
        /// Checking The Perfect Number.
        /// </summary>
        public static void Checknumber()
        {
            int n, i, sum, mn, mx;
            Console.WriteLine("**Input the starting Range of number**");
            mn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**Input the Ending Range of number**");
            mx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**The Perfect numbers within the given range**");

            for (n = mn; n < mx; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)

                        sum = sum + i;
                    i++;

                }
                if (sum == n)
                 Console.WriteLine("***Perfect Number  {0}    " ,   n  + "  ***");
            }
        }
    }
}
