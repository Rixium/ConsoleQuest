using System.Collections.Generic;
using ConsoleQuest.Console.Data;

namespace ConsoleQuest.Console.Consoles
{
    public interface IConsole
    {
        void BufferData(IConsoleData data);
        void Flush();
        void ResetBuffer();
        IEnumerable<IConsoleData> GetBuffered();
        IConsoleData GetLast();
    }
}