using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public void Reverse()
        {
            Console.WriteLine("enter the number for Reverse");
            int num = int.Parse(Console.ReadLine());
            int result = 0;
            int rem;
            while (num != 0)
            {
                rem = num % 10;
                result = result * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(result);
        }

    }
}
