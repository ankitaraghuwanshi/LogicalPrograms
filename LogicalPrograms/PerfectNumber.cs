using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void perfect()
        {
            Console.WriteLine("enter the number for checking perfect or not");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum==num)
            {
                Console.WriteLine("it is perfect number");
            }
            else
            {
                Console.WriteLine("is not a perfect number");
            }       
        }
    }
}
