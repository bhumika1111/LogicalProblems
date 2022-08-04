using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProblems
{
    /// <summary>
    /// Here We Check The Prime Number ,In That We Check The Number Is Divided By 1 And Itself .
    /// </summary>
    public static class PrimeNumber
    {
        /// <summary>
        /// Checking Prime Number.
        /// </summary>
        
        public static void CheckPrimeNumber()
        {
          
            for (int n = 1; n <= 100; n++)
            {
                int count = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)

                        count++;


                }

                if (count == 2)
                {
                    Console.WriteLine("****PrimeNumber: " + n +" ********");
                }
            }
        }
    }
}
