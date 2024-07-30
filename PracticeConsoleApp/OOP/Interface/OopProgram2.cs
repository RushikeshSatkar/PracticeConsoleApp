namespace PracticeConsoleApp.OOP.Interface
{
    public interface PracticeInterface
    {
        void PrintOnConsole();
    }

    public class OopProgram2 : PracticeInterface
    {
        public void PrintOnConsole()
        {
            Console.WriteLine("Hello");
        }
    }
}