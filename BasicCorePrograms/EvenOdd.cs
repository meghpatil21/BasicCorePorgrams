using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenOdd
    {
        public static void OddEven()
        {
            Console.WriteLine("Enter a Number to check odd or even: ");
            int num=Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine($"{num} is even.");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
            }
        }
    }
}
