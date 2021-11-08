using System.IO;
using System;
using Newtonsoft.Json;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            ConsoleOutputService output = new ConsoleOutputService();

            Game game = JsonConvert.DeserializeObject<Game>(File.ReadAllText(gameFilename));
            game.Run();
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}