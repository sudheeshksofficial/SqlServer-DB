namespace EnumConstDynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PiValue = 22.3; //reassign not allowed

            //When list of constants required to be used use enums

            int number = int.Parse(Console.ReadLine());

            BankIFSC inputValue = (BankIFSC)number;

            switch (inputValue)
            {
                case BankIFSC.OtteriBranch:
                    Console.WriteLine("welcome to otteri branch");
                    break;
                case BankIFSC.Purasaiwalkam:
                    Console.WriteLine("welcome to Purasawalkam branch");
                    break;
                case BankIFSC.Perambur:
                    Console.WriteLine("welcome to Perambur branch");
                    break;
                case BankIFSC.Central:
                    Console.WriteLine("welcome to central branch");
                    break;
                default:
                    Console.WriteLine("not welcome to  branch");
                    break;
            }






        }

        enum BankIFSC
        {
            OtteriBranch = 0000927,
            Purasaiwalkam = 000982,
            Perambur = 2353252,
            Central = 3454354
        }
    }
}
