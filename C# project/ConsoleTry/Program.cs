using System.Diagnostics;
using System.Transactions;

namespace ConsoleTry
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int numbers = 68;
            double doublenumber = 78.25;
            string stringval = "345";
            Console.WriteLine(numbers);
            Console.WriteLine(doublenumber);

            double temp1 = numbers;
            Console.WriteLine("****** type casting implicit ******" + temp1);

            int temp2 = (int)doublenumber;
            Console.WriteLine($"****** type casting explicit ******{temp2}");

            int temp3 = Convert.ToInt32(stringval);
            Console.WriteLine(temp3);

        }
    }
}
