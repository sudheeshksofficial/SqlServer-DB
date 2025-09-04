namespace ThreadsAndTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Thread th1 = new Thread(Function1);
            Thread th2 = new Thread(Function2);
            th1.Start();
            th2.Start();
            //Function1();
            //Function2();
            Function3();
            Console.WriteLine("Hello, Thread process!");
        }

        public static void Function1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("function 1 : - " + i);
                Thread.Sleep(1000);
            }
        }

        public static void Function2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("function 2 : - " + i);
                Thread.Sleep(1000);
            }
        }

        public async static void Function3()
        {
            for(int i = 0;  i < 100; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine("function 3 "+i);
            }
        }
    }
}
