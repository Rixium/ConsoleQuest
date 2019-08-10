using System.Collections.Generic;
using ConsoleQuest.Console.Data;

namespace ConsoleQuest.Console.Consoles
{
    public class SystemConsole : IConsole
    {
        private readonly Queue<IConsoleData> _dataQueue;
        private IConsoleData _lastData;

        public SystemConsole()
        {
            _dataQueue = new Queue<IConsoleData>();
        }

        public void BufferData(IConsoleData data)
        {
            _dataQueue.Enqueue(data);
            _lastData = data;
        }

        public void Flush()
        {
            while (_dataQueue.Count > 0)
            {
                Output(_dataQueue.Dequeue());
            }
        }

        public void Output(IConsoleData data)
        {
            System.Console.WriteLine(data.Read());
        }

        public void ResetBuffer()
        {
            _dataQueue.Clear();
        }

        public IEnumerable<IConsoleData> GetBuffered()
        {
            return _dataQueue;
        }

        public IConsoleData GetLastBuffered()
        {
            return _lastData;
        }
    }
}