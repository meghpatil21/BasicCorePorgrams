    namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Program\n 1.Flip coin and print percentage\n 2.Leap Year");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoinPercent.CoinFlip();
                    break;
                case 2:
                    LeapYear.LeapYr();
                    break;
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;
            }
        }
    }
}