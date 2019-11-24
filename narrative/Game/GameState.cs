using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Narrative.Game
{
    public class GameState
    {
        private IList<Actor> actors;
        private IList<Place> places;

        public GameState(string folder)
        {
            actors = new List<Actor>();
            places = new List<Place>();
            
            if (Directory.Exists(folder))
            {
                LoadFilesInDirectory(folder + "/Places", places);
                LoadFilesInDirectory(folder + "/Actors", actors);
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    nameof(folder), folder,
                    "Expected specified path to be an existing folder.");
            }
        }

        private void LoadFilesInDirectory<T>(string subdir, IList<T> list) where T : StoryNode
        {
            if (Directory.Exists(subdir))
            {
                var files = Directory.GetFiles(subdir, "*.xml");
                foreach (var filename in files)
                {
                    using (Stream stream = File.OpenRead(filename))
                    {
                        var reader = new XmlSerializer(typeof(T));
                        var obj = reader.Deserialize(stream) as T;
                        list.Add(obj);
                        Console.WriteLine($"Loaded {typeof(T)}: {obj.Name}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Could not find subdirectory '{subdir}'.");
            }
        }
    }
}