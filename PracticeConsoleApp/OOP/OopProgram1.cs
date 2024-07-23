namespace PracticeConsoleApp.OOP
{
    public abstract class AbstractClass
    {
        public abstract void AbstractPrintMethod();
    }

    public class Print : AbstractClass
    {
        public override void AbstractPrintMethod()
        {
            Console.WriteLine("Printing from Print class");
        }
    }
}