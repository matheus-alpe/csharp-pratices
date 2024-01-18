public class Literals : IRunnable
{
    public void Run()
    {
        uint ui = 5u;
        printWithType(ui);

        int i = 5;
        printWithType(i);

        sbyte sb = 127;
        printWithType(sb);

        decimal m = 30.5m;
        printWithType(m);

        double d = 30.5d;
        printWithType(d);

        float f = 30.5f;
        printWithType(f);

        long l = 5L;
        printWithType(l);

        ulong ul = 5UL;
        printWithType(ul);

        string s = "Hello, this is a string literal";
        printWithType(s);

        string s1 = @"The path is:
            C:\Windows\System32";
        //The backslashes and newline are included in the string
        printWithType(s1);

        char c = 'h';
        printWithType(c);

        byte b = 127;
        printWithType(b);

        short st = 127;
        printWithType(st);

        ushort ust = 127;
        printWithType(ust);

        bool bl = true;
        printWithType(bl);
    }

    private static void printWithType<T>(T data)
    {
        if (data is null)
        {
            return;
        }

        Console.WriteLine($"{data.GetType()} {data}");
    }
}
