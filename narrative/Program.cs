using System;
using System.IO;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Narrative.Game;

namespace Narrative
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Expected the game data folder to be passed as a command line argument.");
                Environment.Exit(1);
                return;
            }
            Console.WriteLine($"Loading game data from '{args[0]}'");
            
//            var actor = new Actor
//            {
//                Name = "Sarah",
//                Gender = Gender.FEMALE
//            };
//
//            using (Stream stream = File.Create(args[0] + "/Actors/Sarah.xml"))
//            {
//                var writer = new System.Xml.Serialization.XmlSerializer(typeof(Actor));
//                writer.Serialize(stream, actor);
//            }
//            
//            var place = new Place
//            {
//                Name = "corridor"
//            };
//
//            using (Stream stream = File.Create(args[0] + "/Places/Place.xml"))
//            {
//                var writer = new System.Xml.Serialization.XmlSerializer(typeof(Place));
//                writer.Serialize(stream, place);
//            }
            
            var game = new GameState(args[0]);
            
            var card = new Card
            {
                Name = "Crying in the corridor",
                Body = "As you walk down `Place.TheName`, you see `Other.Name` " +
                       "sitting in a corner with `Other.HisHer` face in " +
                       "`Other.HisHer` hands, the tears are streaming. " +
                       "Today `Other.HeShe` is wearing a `" +
                       "    string color = null;" +
                       "    Other.Gender = Narrative.Game.Gender.FEMALE;" + 
                       "    if (RandInt % 2 == 0) {" +
                       "        color = \"blue\";" +
                       "    } else {" +
                       "        color = \"red\";" +
                       "    } color` " +
                       "shirt. Suddenly, `Other.HeShe` felt more like a `Other.BoyGirl`."
            };

            var context = new CardContext
            {
                Self = new Actor
                {
                    Gender = Gender.MALE,
                    Name = "Steve"
                },
                Other = new Actor
                {
                    Gender = Gender.MALE,
                    Name = "Dave"
                },
                Place = new Place
                {
                    Name = "Corridor"
                }
            };
            
            card.BodyText(context);
            
            Console.WriteLine($"Other is now a {context.Other.Gender}");



//            using (Stream stream = File.OpenRead(@"Sarah.xml"))
//            {
//                var reader = new System.Xml.Serialization.XmlSerializer(typeof(Actor));
//                var actor2 = (Actor) reader.Deserialize(stream);
//                Console.WriteLine(actor2.Name + " is a " + actor2.Gender);
//            }
//            
//            BinaryFormatter serializer = new BinaryFormatter();
//            serializer.Serialize(SaveFileStream, TestLoan);
//            SaveFileStream.Close();
//
//            Console.WriteLine("Hello world!");
//            Run();
//            Console.WriteLine("Done.");
//            Run();
        }

        private static async void Run()
        {
            try
            {
                var result = await CSharpScript.EvaluateAsync<int>("1 + 3");
                Console.WriteLine("Result: " + result);
            }
            catch (CompilationErrorException e)
            {
                Console.WriteLine(string.Join(Environment.NewLine, e.Diagnostics));
            }
        }
    }
}