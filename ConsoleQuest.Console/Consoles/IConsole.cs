using ConsoleQuest.Console.Data;

namespace ConsoleQuest.Console.Consoles
{
    public interface IConsole
    {
        void QueueData(IConsoleData data);
        void Flush();
        void ResetQueue();
        IConsoleData GetLast();
    }
}