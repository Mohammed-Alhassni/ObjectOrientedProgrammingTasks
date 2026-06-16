using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Part1
{
    internal class Guest
    {
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckinDate { get; set; }
        public int TotalNights { get; set; }

        public Guest(string id, string name, int nights, int roomNumber = 0, DateTime date = new DateTime())
        {
            GuestId = id;
            GuestName = name;
            RoomNumber = roomNumber;
            CheckinDate = date;
            TotalNights = nights;
        }

        }

        public double CalculateTotalCost()
        {
            return 0;
        }
    }
}
