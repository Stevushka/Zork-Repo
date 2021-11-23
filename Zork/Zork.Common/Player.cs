using Newtonsoft.Json;
using System;

namespace Zork
{
    public class Player
    {
        public event EventHandler<Room> LocationChanged;

        public World World { get; }

        [JsonIgnore]
        public Room Location
        { 
            get
            {
                return _location;
            }
            private set
            {
                if(_location != value)
                {
                    _location = value;
                    LocationChanged?.Invoke(this, _location);
                }
            }
        }

        [JsonIgnore]
        public string LocationName
        {
            get
            {
                return Location?.Name;
            }
            set
            {
                Location = World?.RoomsByName.GetValueOrDefault(value);
            }
        }

        public Player(World world, string startingLocation)
        {
            World = world;
            LocationName = startingLocation;
            Moves = 0;
            Score = 0;
        }

        public bool Move(Directions direction)
        {
            bool isValidMove = Location.Neighbors.TryGetValue(direction, out Room destination);
            if(isValidMove)
            {
                Location = destination;
            }

            return isValidMove;
        }

        private Room _location;
        public int Moves;
        public int Score;
    }
}
