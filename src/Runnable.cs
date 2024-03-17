public abstract class Runnable
{
    public abstract void Run<T>(params T[] args);

    public static Runnable SelectChapter(string chapter)
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
