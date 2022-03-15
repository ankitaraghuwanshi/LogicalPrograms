using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public void Prime()
        {
            int num;
            Console.WriteLine("Enter the number : ");
            num = int.Parse(Console.ReadLine());
            if (num == 0 || num == 1)
            {
                Console.WriteLine(num + "is not a prime number");
            }
            else
            {
                for (int i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(num + " is not prime number");
                        return;
                    }
                }
                Console.WriteLine(num + " is a prime number");
            }
        }
    }
}
