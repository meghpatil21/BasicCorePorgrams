using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestNo
    {
        public static void LargetNumber()
        {
            Console.WriteLine("Welcome to Three Number Comparator");
            Console.WriteLine();
            Console.WriteLine("Enter 1st no: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd no: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd no: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Largest number is " + n1);
            }

            else if (n2 > n3)
            {
                Console.WriteLine("Largest number is " + n2);
            }
            else
            {
                Console.WriteLine("Largest number is " + n3);
            }
        }
    }
}
