using ConsoleQuest.Console.Consoles;
using ConsoleQuest.Console.Data;

namespace ConsoleQuest
{
    public static class Program
    {
        private static IConsole _console;

        static void Main(string[] args)
        {
            _console = new SystemConsole();
            _console.BufferData(new ConsoleData("Hello World!"));
            _console.Flush();
            System.Console.WriteLine(_console.GetLast().Read());
        }
    }
}