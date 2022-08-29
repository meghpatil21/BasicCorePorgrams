using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class swapnumbers
    {
        public static void SwapNo()
        {
            Console.WriteLine("Enter 1st number: ");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            int num2=Convert.ToInt32(Console.ReadLine());

            int temp=num1;

            num1= num2;
            num2=temp;

            Console.WriteLine("Your 1st number is: "+num1);
            Console.WriteLine("Your 2nd number is: " + num2);
        }
    }
}
