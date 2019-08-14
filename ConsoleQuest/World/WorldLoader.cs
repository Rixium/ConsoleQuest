using System.IO;
using Newtonsoft.Json;

namespace ConsoleQuest.World
{
    public class WorldLoader : IWorldLoader
    {
        public TWorld Load<TWorld>(string path) where TWorld : IWorld
        {
            TWorld world;
            
            using (var reader = new StreamReader(path))
            {
                var data = reader.ReadToEnd();
                world = JsonConvert.DeserializeObject<TWorld>(data);
            }

            return world;
        }

    }
}