using System;
namespace LogicalPrograms
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("1 for FINDING fibonacii series");
            Console.WriteLine("Enter the according to  above condition : \n");

            int answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    FibonacciSeries fibonacciSeries = new FibonacciSeries();
                    fibonacciSeries.Fb();
                    break;

               

                default:
                    Console.WriteLine("Please enter a valid number.");
                    break;
            }

        }
    }
}
        
    

