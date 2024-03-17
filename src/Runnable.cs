public interface IRunnable
{
    public abstract void Run<T>(params T[] args);

    public static IRunnable SelectChapter(string chapter)
    {
        switch (chapter)
        {
            case "literals":
                return new Literals();
            case "operators":
                return new Operators();
            default:
                return new FactoryMethod();
        }
    }
}
