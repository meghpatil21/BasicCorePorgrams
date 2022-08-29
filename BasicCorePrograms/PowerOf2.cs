using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOf2
    {
        public static void PowerOfTwo()
        {
            int num = 2;
            int power = 1;
            int i = 1;
            Console.WriteLine("Enter the Power: ");
            int p=Convert.ToInt32(Console.ReadLine());

            if(p>=0 && p<31)
            {
                for(i=1; i<=p; i++)
                {
                    power = power * num;
                    Console.WriteLine(power);
                }
            }
            else
            {
                Console.WriteLine("Please enter power between 0-31");
            }

        }
    }
}
