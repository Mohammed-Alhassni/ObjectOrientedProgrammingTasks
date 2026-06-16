namespace OOP_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms= new List<Room>();
            List<Guest> guest= new List<Guest>();

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
            int roomNumbertemp = int.Parse(Console.ReadLine());

            if (roomsList.Any(r => r.RoomNumber == roomNumbertemp) == false)
            {
                roomNumber = roomNumbertemp;
            } else
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
            double pricePerNight = double.Parse(Console.ReadLine());

        }
    }
}
