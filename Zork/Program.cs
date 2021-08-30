using System;

namespace Zork
{
    class Program
    {
        private static string[] Rooms = { "Forest", "West of House", "Behind House", "Clearing", "Canyon View" };
        private static int currentRoom = 1;

        static void Main(string[] args)
        {
            

            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {
                Console.WriteLine(Rooms[currentRoom]);
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                string outputString = "";
                switch(command)
                {
                    case Commands.LOOK: //If the command is look, tell the player what they see.
                        outputString = "This is an open field west of a white house, with a boarded front door." +
                            "\nA rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH: //If the command is any of the cardinal directions, tell the player which direction they chose.
                    case Commands.SOUTH:
                        outputString = "The way is shut!";
                        break;

                    case Commands.WEST:
                    case Commands.EAST:
                        bool successfulMove = Move(command);
                        if(successfulMove)
                            outputString = $"You moved {command}.";
                        else
                            outputString = "The way is shut!";
                        break;

                    case Commands.QUIT: //If the command is quit, thank the player before the while loop catches it and exits.
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.UNKNOWN: //If the command if UNKNOWN or somehow any othe string not in Commands, inform the player.
                    default:
                        outputString = "Unknown Command.";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static bool Move(Commands direction)
        {
            bool successfulMove = true;

            //Validate the direction
            successfulMove = (direction == Commands.NORTH || direction == Commands.SOUTH
                            || direction == Commands.EAST || direction == Commands.WEST) ? true : false;

            //Process the validated direction
            if(successfulMove)
            {
                switch(direction)
                {
                    case Commands.EAST:
                        if(currentRoom < Rooms.Length - 1) //We haven't reached the right-most room
                            currentRoom++;
                        else
                            successfulMove = false;
                        break;

                    case Commands.WEST:
                        if(currentRoom > 0) //We haven't reached the first left-most room
                            currentRoom--;
                        else
                            successfulMove = false;
                        break;
                }
            }

            return successfulMove; //return if the move was successful. True if nothing was wrong, false if something failed at any point
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