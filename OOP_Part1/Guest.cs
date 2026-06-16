using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Part1
{
    internal class Guest
    {
        public int GuestId { get; set; }
        public string GuestName { get; set; }
        public int RoomNumber { get; set; }
        public DateTime CheckinDate { get; set; }
        public int TotalNights { get; set; }

        public void DisplayGuest()
        {

        }

        public double CalculateTotalCost()
        {
            return 0;
        }
    }
}
