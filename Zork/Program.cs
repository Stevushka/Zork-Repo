using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Zork
{
    class Program
    {
        #region Constructor
            static Program()
            {
                RoomMap = new Dictionary<string, Room>();
                foreach(Room room in Rooms)
                {
                    RoomMap[room.Name] = room;
                }
            }
        #endregion

        #region Vars
            private static readonly Room[,] Rooms =
            {
                    { new Room("Dense Woods"),    new Room("North of House"),   new Room("Clearing") },
                    { new Room("Forest"),         new Room("West of House"),    new Room("Behind House") },
                    { new Room("Rocky Trail"),    new Room("South of House"),   new Room("Canyon View") }
            };

            private enum Fields
            {
                Name = 0,
                Description
            }

            private enum CommandLineArguments
            {
                RoomsFilename = 0
            }

            private static void InitRoomDescriptions(string roomsFilename)
            {
                const string fieldDelimiter = "##";
                const int expectedFieldCount = 2;

                var roomQuery = from line in File.ReadLines(roomsFilename)
                                let fields = line.Split(fieldDelimiter)
                                where fields.Length == expectedFieldCount
                                select (Name: fields[(int)Fields.Name],
                                        Description: fields[(int)Fields.Description]);


                foreach(var (Name, Description) in roomQuery)
                {
                    RoomMap[Name].Description = Description;
                }
            }

            private static Room CurrentRoom
            {
                get
                {
                    return Rooms[Location.Row, Location.Col];
                }
            }

            private static (int Row, int Col) Location = (1, 1);

            private static readonly Dictionary<string, Room> RoomMap;
        #endregion

        #region Main
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Zork!");

                const string defaultRoomsFilename = "Rooms.txt";
                string roomsFilename = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultRoomsFilename);
                InitRoomDescriptions(roomsFilename);

                Room previousRoom = null;
                Commands command = Commands.UNKNOWN;
                while(command != Commands.QUIT)
                {
                    Console.WriteLine(CurrentRoom.Name);

                    if(previousRoom != CurrentRoom)
                    {
                        Console.WriteLine(CurrentRoom.Description);
                        previousRoom = CurrentRoom;
                    }

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