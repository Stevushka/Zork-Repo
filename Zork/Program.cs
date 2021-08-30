using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString = "";
                switch(command)
                {
                    case Commands.LOOK: //If the command is look, tell the player what they see.
                        Console.WriteLine("This is an open field west of a white house, with a boarded front door." +
                            "\nA rubber mat saying 'Welcome to Zork!' lies by the door.");
                        break;

                    case Commands.NORTH: //If the command is any of the cardinal directions, tell the player which direction they chose.
                    case Commands.SOUTH:
                    case Commands.WEST:
                    case Commands.EAST:
                        Console.WriteLine("You moved " + command.ToString() + ".");
                        break;

                    case Commands.QUIT: //If the command is quit, thank the player before the while loop catches it and exits.
                        Console.WriteLine("Thank you for playing!");
                        break;

                    case Commands.UNKNOWN: //If the command if UNKNOWN or somehow any othe string not in Commands, inform the player.
                    default:
                        Console.WriteLine("Unknown Command.");
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static Commands ToCommand(string commandString)
        {
            return Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
        }
    }
}

/* CODE JAIL
 *
 *
 * 
 */