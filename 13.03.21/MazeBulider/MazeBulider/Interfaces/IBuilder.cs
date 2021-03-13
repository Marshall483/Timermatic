using MazeBulider.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MazeBulider.Interfaces
{
    public interface IBuilder
    {
        public MazeRoom GetNextRoom {
            get;
        }
        public void Generate(int rooms);

    }
}
