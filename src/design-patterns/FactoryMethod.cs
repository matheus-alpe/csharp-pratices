interface IButton
{
    public void Click();
}

interface Dialog
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
    public IButton CreateButton()
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
    public IButton CreateButton()
    {
        return new HTMLButton();
    }
}

public class FactoryMethod : IRunnable
{
    public void Run<T>(params T[] args)
    {
        Console.WriteLine("FactoryMethod");
        Dialog dialog = args.Length > 0 ? new WebDialog() : new WindowsDialog();
        dialog.Action();
    }
}


