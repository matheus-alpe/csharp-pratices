namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length <= 0) return;

            IRunnable chapter = IRunnable.SelectChapter(args[0]);

            if (args.Length > 1)
            {
                chapter.Run(args[1]);
                return;
            }
            chapter.Run<string>();
        }
    }
}
