using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    /// <summary>
    /// Here We Check The Reverse Number ,In That We Check The Output Of Code Is A Number Obtained By Writing Original Number From Right To Left.
    /// </summary>
     public static   class ReverseNumber
    {
        public static void CheckingreverseNumber()
        {

            int n, reverse = 0, rem;
            Console.WriteLine("** Enter the number :  **");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n = n / 10;

            }
            Console.WriteLine("**Reversed Number:" + reverse + "**");

        }
    }
}
