using System.Collections.Generic;

namespace ConsoleQuest.World
{
    public class World : IWorld
    {
        public string Name { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
    }
}