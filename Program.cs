namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.Read();
            foreach (string key in args)
            {
                Console.WriteLine(key);
            }
        }
    }
}
