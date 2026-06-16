using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Part1
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }

        public Room(int number, string type, double price)
        {
            RoomNumber = number;
            RoomType = type;
            PricePerNight = price;
        }

        public string DisplayRoom(bool show= true)
        {
            string newRoom= $"""

                Room Number: {RoomNumber}
                Room Type: {RoomType}
                Price Per Night: {PricePerNight}

                """;

            if (show) { Console.WriteLine(newRoom);  }
            return newRoom;
        }
    }
}
