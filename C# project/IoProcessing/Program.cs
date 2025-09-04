namespace IoProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"G:\sample.txt";
            File.WriteAllText(path,"sudeesh");
            string filecontent = File.ReadAllText(path);
            Console.WriteLine(filecontent);

            Console.WriteLine("--------------");
            string path2 = @"G:\";
            
            Console.WriteLine($"the path is {path2} and folder cound is"+Directory.GetDirectories(path2).Length);
            Console.WriteLine("and the file count is  : "+Directory.GetFiles(path2).Length);
        }
    }
}
