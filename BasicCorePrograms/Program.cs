    namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Program\n 1.Flip coin and print percentage\n 2.Leap Year\n 3.Power of 2\n 4.Harmonic No.\n 5.Factors\n 6.Quotient & Remainder\n 7.Swap Numbers\n 8.Even Odd check\n 9.Vowel Check");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoinPercent.CoinFlip();
                    break;
                case 2:
                    LeapYear.LeapYr();
                    break;
                case 3:
                    PowerOf2.PowerOfTwo(); 
                    break;
                case 4:
                    HarmonicNumber.HarmonicNo();
                    break;
                case 5:
                    PrimeFactors.PrimeFact();
                    break;
                case 6:
                    QuotientnRemainder.QuotientRemain();
                    break;
                case 7:
                    swapnumbers.SwapNo();
                    break;
                case 8:
                    EvenOdd.OddEven();
                    break;
                case 9:
                    VowelCons.VowelCon();
                    break;
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;
            }
        }
    }
}