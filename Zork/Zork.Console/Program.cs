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

            output.WriteLine(string.IsNullOrWhiteSpace(game.WelcomeMessage) ? "Welcome to Zork!" : game.WelcomeMessage);
            game.Start(input, output);

            Room previousRoom = null;
            while (game.IsRunning)
            {
                output.WriteLine(game.Player.Location);
                if(previousRoom != game.Player.Location)
                {
                    game.Look(game);
                    previousRoom = game.Player.Location;
                }

                output.Write("\n> ");
                input.ProcessInput();
            }

            output.WriteLine(string.IsNullOrWhiteSpace(game.ExitMessage) ? "Thank you for playing!" : game.ExitMessage);
        }

        private enum CommandLineArguments
        {
            GameFilename = 0
        }
    }
}