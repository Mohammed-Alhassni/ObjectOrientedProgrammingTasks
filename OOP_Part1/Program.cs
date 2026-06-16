namespace OOP_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>()
            {
                new Room(1, "Single", 20),
                new Room(2, "Double", 30),
                new Room(3, "Suite", 55),
                new Room(4, "Single", 40),
                new Room(5, "Double", 70),
                new Room(6, "Suite", 95),
            };

            List<Guest> guests = new List<Guest>();

            int option = -1;
            bool interacting = true;

            while (interacting)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("""
                                        ================================================
                                        GRAND VISTA HOTEL — MANAGEMENT SYSTEM
                                        ================================================
                    """);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("""
                                                1. Add New Room
                                                2. Register New Guest
                                                3. Book a Room for a Guest
                    """);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("""
                                                4. Search & Filter Rooms
                                                5. Guest & Booking Statistics
                    """);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("""
                                                6. Check Out a Guest
                                                7. Remove Unavailable Rooms
                    """);

                Console.ResetColor();
                Console.WriteLine("""
                                                0. Exit
                    """);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("""
                                        ================================================
                    """);

                Console.ResetColor();

                Console.Write("Enter your choice: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CreateRoom(ref rooms);
                        break;
                    case 2:
                        RegisterNewGuest(ref guests);
                        break;
                    case 0:
                        interacting = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        Thread.Sleep(2000);
                        break;
                }
            }
        }

        static void CreateRoom(ref List<Room> roomsList)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("\nEnter room number: ");
            int roomNumber;
            int roomNumberTemp = int.Parse(Console.ReadLine());

            if (roomsList.Any(r => r.RoomNumber == roomNumberTemp) == false && roomNumberTemp > 0)
            {
                roomNumber = roomNumberTemp;
            }
            else if (roomNumberTemp <= 0)
            {
                Console.WriteLine("Room number cannot be zero or negitive. ");
                Thread.Sleep(3000);
                return;
            }
            else
            {
                Console.WriteLine("This room number already exist. ");
                Thread.Sleep(3000);
                return;
            }

            Console.Write("Enter room type (Single / Double / Suite): ");
            string roomType;
            string roomTypeTemp = Console.ReadLine();
            string[] types = ["single", "double", "suite"];
            if (types.Contains(roomTypeTemp.ToLower()))
            {
                roomType = roomTypeTemp.Substring(0, 1) + roomTypeTemp.Substring(1).ToLower();
            }
            else
            {
                Console.WriteLine("Invalid input, it should be: Single / Double / Suite.");
                Thread.Sleep(3000);
                return;
            }

            Console.Write("Enter room price per night: ");
            double pricePerNight;
            double pricePerNightTemp = double.Parse(Console.ReadLine());
            if (pricePerNightTemp > 0)
            {
                pricePerNight = pricePerNightTemp;
            }
            else
            {
                Console.WriteLine("Room price cannot be zero or negitive. ");
                Thread.Sleep(3000);
                return;
            }

            roomsList.Add(new Room(roomNumber, roomType, pricePerNight));

            Console.WriteLine($"\nRoom Added:\n{roomsList[roomsList.Count-1].DisplayRoom(false)}\nRooms Count: {roomsList.Count}");
            Thread.Sleep(4000);

            Console.ResetColor();
        }
        static void RegisterNewGuest(ref List<Guest> guestsList)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string guestId = $"G{guestsList.Count:3}";

            Console.Write("\nEnter guest name: ");
            string guestName = Console.ReadLine();

            Console.Write("Enter number of nights planned to stay: ");
            int numberOfNights;
            int numberOfNightsTemp = int.Parse(Console.ReadLine());
            if (numberOfNightsTemp > 0)
            {
                numberOfNights = numberOfNightsTemp;
            }
            else
            {
                Console.WriteLine("Room price cannot be zero or negitive. ");
                Thread.Sleep(3000);
                return;
            }

            guestsList.Add(new Guest(guestId, guestName, numberOfNights));

            Console.WriteLine($"\nGuest Added:\n{guestsList[guestsList.Count - 1].DisplayGuest(false)}\nGuests Count: {guestsList.Count}");
            Thread.Sleep(40000);

            Console.ResetColor();
        }
    }
}