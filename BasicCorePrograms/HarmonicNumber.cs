using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public static void HarmonicNo()
        {
            Console.WriteLine("Which Harmonic Number you want: ");
            int n=Convert.ToInt32(Console.ReadLine());

            int i = 1;
            decimal harNo = 0;

            for(i=1; i<=n; i++)
            {
                harNo = harNo + (1 /(decimal) i);
            }

            Console.WriteLine( "Harmonic Number is "+harNo);
        }
    }
}
