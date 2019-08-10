using System;
using System.Collections.Generic;
using ConsoleQuest.Console.Data;

namespace ConsoleQuest.Console.Consoles
{
    public class SystemConsole : IConsole
    {
        private Queue<IConsoleData> _dataQueue;
        private IConsoleData _lastData;

        public SystemConsole()
        {
            _dataQueue = new Queue<IConsoleData>();
        }

        public void QueueData(IConsoleData data)
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

            ResetQueue();
        }

        public void Output(IConsoleData data)
        {
            System.Console.WriteLine(data.Read());
        }

        public void ResetQueue()
        {
            _dataQueue.Clear();
        }

        public IConsoleData GetLast()
        {
            return _lastData ?? throw new NullReferenceException();
        }
    }
}