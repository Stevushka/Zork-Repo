using System;
using System.Collections.Generic;

namespace Zork
{
    class Program
    {
        #region Vars
            private static readonly Room[,] Rooms =
            {
                    { new Room("Rocky Trail"),    new Room("South of House"),   new Room("Canyon View") },
                    { new Room("Forest"),         new Room("West of House"),    new Room("Behind House") },
                    { new Room("Dense Woods"),    new Room("North of House"),   new Room("Clearing") }
            };

            private static void InitRoomDescriptions()
            {
                Rooms[0, 0].Description = "You are on a rock-strewn trail.";                                                                                // Rocky Trail
                Rooms[0, 1].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";         // South of House
                Rooms[0, 2].Description = "You are at the top of the great canyon on its south wall.";                                                      // Canyon View

                Rooms[1, 0].Description = "This is a forest, with trees in all directions around you.";                                                     // Forest
                Rooms[1, 1].Description = "This is an open field west of a white house, with a boarded front door.";                                        // West of House
                Rooms[1, 2].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";     // Behind House

                Rooms[2, 0].Description = "This is a dimly lit forest, with large trees all around. To the east, there appears to be sunlight.";            // Dense Woods
                Rooms[2, 1].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";         // North of House
                Rooms[2, 2].Description = "You are in a clearing, with a forest surrounding you on the west and south.";                                    // Clearing
            }

            private static Room CurrentRoom
            {
                get
                {
                    return Rooms[Location.Row, Location.Col];
                }
            }

            private static (int Row, int Col) Location = (1, 1);
        #endregion

        #region Main
            static void Main(string[] args)
            {
                InitRoomDescriptions();

                Console.WriteLine("Welcome to Zork!");

                Commands command = Commands.UNKNOWN;
                while(command != Commands.QUIT)
                {
                    Console.WriteLine(CurrentRoom.Name);
                    Console.Write("> ");
                    command = ToCommand(Console.ReadLine().Trim());
                
                    switch(command)
                    {
                        case Commands.LOOK: //If the command is look, tell the player what they see.
                            Console.WriteLine(CurrentRoom.Description);
                            break;

                        case Commands.NORTH: //If the command is any of the cardinal directions, move there if valid.
                        case Commands.SOUTH:
                        case Commands.EAST:
                        case Commands.WEST:
                            if(! Move(command))
                                Console.WriteLine("The way is shut!");
                            break;

                        case Commands.QUIT: //If the command is quit, thank the player before the while loop catches it and exits.
                            Console.WriteLine("Thank you for playing!");
                            break;

                        case Commands.UNKNOWN: //If the command if UNKNOWN or somehow any othe string not in Commands, inform the player.
                        default:
                            Console.WriteLine("Unknown Command.");
                        break;
                    }
                }
            }
        #endregion

        #region Methods
            private static bool Move(Commands command)
            {
                //Validate the direction
                Assert.IsTrue(IsDirection(command), "Invalid Direction");
                bool successfulMove = true;

                //Process the validated direction
                if(successfulMove)
                {
                    switch(command)
                    {
                        case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                            Location.Row++;
                            break;

                        case Commands.SOUTH when Location.Row > 0:
                            Location.Row--;
                            break;

                        case Commands.EAST when Location.Col < Rooms.GetLength(1) - 1:
                            Location.Col++;
                            break;

                        case Commands.WEST when Location.Col > 0:
                            Location.Col--;
                            break;

                        default:
                            successfulMove = false;
                            break;
                    }
                }

                return successfulMove; //return if the move was successful. True if nothing was wrong, false if something failed at any point
            }
        #endregion

        #region Utility
            private static Commands ToCommand(string commandString)
            {
                return Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
            }

            private static bool IsDirection(Commands command) => Directions.Contains(command);

            private static readonly List<Commands> Directions = new List<Commands>
            {
                Commands.NORTH,
                Commands.SOUTH,
                Commands.EAST,
                Commands.WEST
            };
        #endregion
    }
}

/* CODE JAIL
 *
 *
 * 
 */