using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PrimeFactors
    {
        public static void PrimeFact()
        {
            Console.WriteLine("Enter non-prime Number: ");
            int n=Convert.ToInt32(Console.ReadLine());

            int i;
            

            for(i=2; i*i<=n; i++)
            {
                if (n % i == 0)
                {
                    
                    while (n % i == 0)
                    {
                        n= n/i;
                        
                    }
                    Console.WriteLine("{0} is a prime factor. ",i);
                }
                

            }

            //else
            //{
                //Console.WriteLine("No Prime Factors");
           // }
        }
    }
}
