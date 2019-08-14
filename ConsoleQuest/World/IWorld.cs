using System.Collections.Generic;

namespace ConsoleQuest.World
{
    public interface IWorld
    {
        string Name { get; set; }
        IEnumerable<Room> Rooms { get; set; }
    }
}