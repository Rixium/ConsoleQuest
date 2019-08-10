namespace ConsoleQuest.Console.Data
{
    public interface IConsoleData
    {
        void Write(object data);
        object Read();
    }
}