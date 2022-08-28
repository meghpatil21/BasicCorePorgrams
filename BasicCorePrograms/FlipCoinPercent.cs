using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoinPercent
    {
        public static void CoinFlip()
        {
            Console.WriteLine("How many times coin should be flip :");
            int n=Convert.ToInt32(Console.ReadLine());
            int i;
            int headCount = 0;
            int tailCount = 0;
            int headPercent;

            if(n<=0)
            {
                Console.WriteLine("Invalid Choice");
            }
            else
            {
                for(i=1; i<=n;i++)
                {
                    Random random = new Random();
                    double coin = random.NextDouble();

                    if (coin < 0.5)
                    {
                        Console.WriteLine("Tails");
                        tailCount++;
                    }
                    else
                    {
                        Console.WriteLine("Heads");
                        headCount++;
                    }
                }
                Console.WriteLine();
                headPercent = headCount * 100 / n;
                Console.WriteLine("Head Percent: "+headPercent);
                Console.WriteLine("Tail Percent: "+(100-headPercent));
                
            }

        }
    }
}
