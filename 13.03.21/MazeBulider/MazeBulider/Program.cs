using System;
using MazeBulider.Interfaces;
using MazeBulider.Models;
using MazeBulider.Services;

namespace MazeBulider
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new MazeDirector();

            var builder = new MazeBilder();
            director.ConstructRandomMaze(builder, 100);
            var prod = new MazeModel();

            prod = builder.GetRusult;

            Console.WriteLine(prod.ToString());
            Console.ReadKey();
        }
    }
}
