using System;

namespace LogicalProblems
{
    class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine("****Output For FibonacciSeries****");
             FibonacciSeries.CalculateFibonacieSeries();

             Console.WriteLine(":::::::::::::::::::::::::::::::::::::::");
             Console.WriteLine("****Output For Perfect Number*****");
             PerfectNumber.Checknumber();
             

             Console.WriteLine("::::::::::::::::::::::::::::::::::::::");
             Console.WriteLine("*****Output For Prime Number*****");
             PrimeNumber.CheckPrimeNumber();

             Console.WriteLine(":::::::::::::::::::::::::::::::::::::");
             Console.WriteLine("*****Output For Reverse Number******");
             ReverseNumber.CheckingreverseNumber();

              Console.WriteLine(":::::::::::::::::::::::::::::::::::::");
              Console.WriteLine("*****Output For StopWatch******");
              StopWatch.CheckingStopWatch();
           
            


        }
    }
}
