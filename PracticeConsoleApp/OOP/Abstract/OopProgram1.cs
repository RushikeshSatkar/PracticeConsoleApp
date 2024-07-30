namespace PracticeConsoleApp.OOP.Abstract
{
    public abstract class AbstractClass
    {
        public abstract void AbstractPrintMethod();
        public string hello = "";
    }

    public class Print : AbstractClass
    {
        public override void AbstractPrintMethod()
        {
            Console.WriteLine("Printing from Print class");
        }
    }
}