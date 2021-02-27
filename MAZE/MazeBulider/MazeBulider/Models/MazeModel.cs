using System;
using System.Collections.Generic;
using System.Text;

namespace MazeBulider.Models
{
    class MazeModel
    {
        public MazeRoom Maze { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();
            var current = Maze;

            while (current.Next != null)
            {
                sb.Append(current.ToString());
                current = current.Next;
            }
            sb.Append(current);
            return sb.ToString();
        }
    }
}
