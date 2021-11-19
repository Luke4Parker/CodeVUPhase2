using System;
using System.Collections.Generic;
using System.Text;

namespace HotelAssignment11_19
{
    class Hotel
    {
        public string HotelName { get; set; }
        public string City { get; set; }
        public List<Reservation> Reservations { get; set; }

        public Hotel(string name, string city)
        {
            HotelName = name;
            City = city;
            Reservations = new List<Reservation>();
        }

        public void AddReservation(Customer customer, Room.RoomType room, DateTime checkInDate, DateTime checkOutDate)
        {
            //create a list of available rooms of each type
            Room newRoom = new Room(1234, room);
            Reservations.Add(new Reservation(customer, newRoom, checkInDate, checkOutDate));
        }
        public void PrintReservationList()
        {
            foreach (Reservation res in Reservations)
            {
                Console.WriteLine(res);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
