namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length <= 0) return; 
            IRunnable chapter = SelectChapter(args[0]);
            chapter.Run();
        }

        public static IRunnable SelectChapter(string chapter)
        {
            switch(chapter)
            {
                case "1":
                    return new Literals();
                default:
                    return new Operators();
            }
        }
    }
}
