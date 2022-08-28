using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public static void LeapYr()
        {

            Console.WriteLine("Enter Year :");
            string str = Console.ReadLine();
            int length = str.Length;

            if(length != 4)
            {
                Console.WriteLine("You must enter 4 digit number. Try Again.");
            }
            else
            {
                int Year =Convert.ToInt32(str);

                if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0)) 
                {
                    Console.WriteLine("{0} is leap year.",Year);
                }
                else
                {
                    Console.WriteLine("{0} is not leap year.",Year);
                }


            }




        }
    }
}
