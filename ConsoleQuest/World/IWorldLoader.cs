namespace ConsoleQuest.World
{
    public interface IWorldLoader
    {
        TWorld Load<TWorld>(string path) where TWorld : IWorld;
    }
}