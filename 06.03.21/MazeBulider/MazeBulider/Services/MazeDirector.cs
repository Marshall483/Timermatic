using MazeBulider.Interfaces;
using MazeBulider.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MazeBulider.Services
{
    class MazeDirector 
    {
        public void ConstructRandomMaze(IBuilder builder, int rooms) =>
            builder.Generate(rooms);
    }
}
