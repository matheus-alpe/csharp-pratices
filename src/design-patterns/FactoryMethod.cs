interface IButton
{
    public void Click();
}

abstract class Dialog
{
    public abstract IButton CreateButton();

    public void Action()
    {
        IButton btn = this.CreateButton();
        btn.Click();
    }
}

class WindowsButton : IButton
{
    public void Click()
    {
        Console.WriteLine("Clicked on Windows Button");
    }
}

class WindowsDialog : Dialog
{
    public override IButton CreateButton()
    {
        return new WindowsButton();
    }
}

class HTMLButton : IButton
{
    public void Click()
    {
        Console.WriteLine("Clicked on HTML Button");
    }
}

class WebDialog : Dialog
{
    public override IButton CreateButton()
    {
        return new HTMLButton();
    }
}

public class FactoryMethod : Runnable
{
    public override void Run<T>(params T[] args)
    {
        Console.WriteLine("FactoryMethod");

        if (args.Length <= 0 || (args[0] is not String))
        {
            Console.WriteLine("Missing arg: plat or web");
            return;
        }

        Dialog dialog = args[0] as string == "web" ? new WebDialog() : new WindowsDialog();
        dialog.Action();
    }
}

