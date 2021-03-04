using MazeBulider.Interfaces;
using MazeBulider.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MazeBulider.Services
{
    class MazeBilder : IBuilder
    {
        private MazeModel _product { get; set; }
        public MazeRoom GetNextRoom {
            get {
                Thread.Sleep(1);
                return new MazeRoom { 
                    DoorSide = (Side) new Random(DateTime.Now.Millisecond).Next(0, 4) 
                };
            }
        } 

        public void Generate(int countRooms)
        {
            MazeRoomsList rooms = new MazeRoomsList();

            for (int i = 0; i < countRooms; i++)
                rooms.Add(GetNextRoom);

            _product = new MazeModel { Maze = rooms.GetHead };
        }

        public MazeModel GetRusult { 
            get {
                return _product;
            } 
        }
    }
}
