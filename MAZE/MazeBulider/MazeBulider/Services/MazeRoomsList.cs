using MazeBulider.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MazeBulider.Services
{
    class MazeRoomsList
    {
        private MazeRoom head; // головной/первый элемент
        private MazeRoom tail; // последний/хвостовой элемент
        private int count;  // количество элементов в списке
        public MazeRoom GetHead { 
            get {
                if (count != 0)
                    return head;
                throw new MissingMemberException("No rooms yet");
            } 
        }
        // добавление элемента
        public void Add(MazeRoom data)
        {
            MazeRoom node = data;

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }   
    }
}
