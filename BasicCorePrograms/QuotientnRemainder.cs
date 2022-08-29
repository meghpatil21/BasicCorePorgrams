using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientnRemainder
    {
        public static void QuotientRemain()
        {
            int quotient, remainder;

            Console.WriteLine("Enter a number to be divided ");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor :");
            int d=Convert.ToInt32(Console.ReadLine());

            quotient=num/d;
            remainder=num%d;

            Console.WriteLine($"The quotient is {quotient} and remainder is {remainder}");
        }
    }
}
