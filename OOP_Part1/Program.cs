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

        }
    }
}
