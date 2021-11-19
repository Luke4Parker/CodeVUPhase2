using System;

namespace HotelAssignment11_19
{

    class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer("Charles", "Jewnkins", new DateTime(1993, 12, 15), "1234123456785678", "1234567890");
            Console.WriteLine(cust);
            //Room room = new Room(1, Room.RoomType.SingleBed);
            //Reservation reservation = new Reservation(cust, room, new DateTime(2021, 11, 12), new DateTime(2021, 11, 15));
            //Console.WriteLine(reservation);

            Hotel hotel = new Hotel("Berbs", "Chicago");
            hotel.AddReservation(cust, Room.RoomType.KingBed, new DateTime(2021, 11, 12), new DateTime(2021, 11, 15));
            foreach (Reservation res in hotel.Reservations)
            {
                Console.WriteLine(res);
            }


            //End of testing shtuff
            /////////////////////////

            //Creating a reservation
            //*******************************************************************

            //Get guest info
            //Console.WriteLine("Add a Reservation\nWho will be staying with us?");
            //Console.WriteLine("First Name: ");
            //string custFirstName = Console.ReadLine();
            //Console.WriteLine("Last Name: ");
            //string custLastName = Console.ReadLine();

            //Console.WriteLine("Guest Phone Number: ");
            //string phone = Console.ReadLine();//could add validation later
            //DateTime bday;
            //string creditCard;

            ////datetime validation
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Guest Birthday: ");
            //        bday = DateTime.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Enter Guest Birthday in Format mm/dd/yyyy");
            //    }
            //}
            ////credit card validation
            //while (true)
            //{
            //    Console.WriteLine("Guest Credit Card: ");
            //    creditCard = Console.ReadLine();
            //    if (creditCard.Length != 16)
            //    {
            //        Console.WriteLine("Enter a Valid Credit Card Number");
            //    }
            //    else
            //    { break; }
            //}

            ////Choosing room
            //Console.WriteLine("What room size would you like to reserve?\nSelect from the following options" +
            //    "1. Single Bed" +
            //    "2. Double Bed" +
            //    "3. Queen Bed" +
            //    "4. King Bed");

            //string input = Console.ReadLine();
            //switch (input)
            //{
            //    case "1":
            //        break;
            //    case "2":
            //        break;
            //    case "3":
            //        break;
            //    case "4":
            //        break;
            //    default:
            //        Console.WriteLine("Your selection is invalid");
            //        break;
            //}
            //End creating Reservation********************************************
        }
    }
}
