using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            const string defaultRoomsFilename = "Zork.Json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultRoomsFilename);

            Game game = Game.Load(gameFilename);

            ConsoleInputService input = new ConsoleInputService();
            ConsoleOutputService output = new ConsoleOutputService();

            game.Player.LocationChanged += Player_LocationChanged;

            game.Start(input, output);

            Room previousRoom = null;
            while (game.IsRunning)
            {
                output.WriteLine(game.Player.Location);
                if(previousRoom != game.Player.Location)
                {
                    Game.Look(game);
                    previousRoom = game.Player.Location;
                }

                output.Write("\n> ");
                input.ProcessInput();
            }

            output.WriteLine(string.IsNullOrWhiteSpace(game.ExitMessage) ? "Thank you for playing!" : game.ExitMessage);
        }

        private static void Player_LocationChanged(object sender, Room e)
        {
            Console.WriteLine("You moved somewhere else!");
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}