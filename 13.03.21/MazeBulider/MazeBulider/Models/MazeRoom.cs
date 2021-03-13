using System;
using System.Collections.Generic;
using System.Text;

namespace MazeBulider.Models
{
    public enum Side { North, West, Sounth, East }

    public class MazeRoom
    {
        public Side DoorSide { get; set; }
        public MazeRoom Next { get; set; }

        public override string ToString()
        {
            switch (DoorSide)
            {
                case Side.North:
                    return "↑";
                case Side.West:
                    return "→";
                case Side.Sounth:
                    return "↓";
                case Side.East:
                    return "←";
                default:
                    return "º";
            }
        }
    }
}

/* Список с комнатами. Одна комнанта связвнна с другой через дверь.  */