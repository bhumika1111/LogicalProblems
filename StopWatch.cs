using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LogicalProblems
{
    /// <summary>
    /// Here We Check The Output For StopWatch In That We Check The Elapsed Time .
    /// </summary>
    public static  class StopWatch
    { 
      /// <summary>
     /// Checking Stopwatch .
    /// </summary>
        public static void CheckingStopWatch()
        {
            Console.WriteLine("**Welcome To Stop Watch Program ! Please Enter**");
            Console.ReadLine();
            //First I'm Creating Object Here For Class Stopwatch.
            Stopwatch stopwatch = new Stopwatch();
            
            //I Want To Start The Watch Thats Why I'm Using  Start Method Here.
            stopwatch.Start();


            Console.WriteLine("**Wait! Until You Want To Check The Elapsed Time On StopWatch");
            Console.ReadLine();

            //I want To Stop The Watch Thats Why I'm Using Stop Method Here.
            stopwatch.Stop();

            //I Want To Check TimeSpan Here,Timespan Is Class And Giving The Name As ts Here. 
            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Wow! You Got The Elapsed Time");
            Console.WriteLine(ts);

        }
    }
}
