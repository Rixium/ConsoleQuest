using ConsoleQuest.World;

namespace ConsoleQuest.Examples.Town
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var worldLoader = new WorldLoader();
            var world = worldLoader.Load<World.World>("resources/world.json");
            System.Console.WriteLine(world);
        }
    }
}