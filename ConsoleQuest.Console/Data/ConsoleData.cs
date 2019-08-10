namespace ConsoleQuest.Console.Data
{
    public class ConsoleData : IConsoleData
    {
        private object _data;

        public ConsoleData(object data)
        {
            _data = data;
        }

        public void Write(object data)
        {
            _data = data;
        }

        public object Read()
        {
            return _data;
        }
    }
}