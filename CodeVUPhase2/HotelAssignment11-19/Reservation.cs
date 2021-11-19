using System;
using System.Collections.Generic;
using System.Text;

namespace HotelAssignment11_19
{
    class Reservation
    {
        public Customer Customer { get; set; }
        public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Reservation(Customer customer, Room room, DateTime checkInDate, DateTime checkOutDate)
        {
            Customer = customer;
            Room = room;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

        public decimal CalculateReservationCost()
        {
            int numberOfDays = (CheckOutDate - CheckInDate).Days;
            decimal reservationCost = numberOfDays * Room.GetRoomPrice();
            return reservationCost;
        }

        public override string ToString()
        {
            return string.Format($"\nRoom Number: {Room.RoomNumber}\nCheck-in Date: {CheckInDate}\nCheck-out Date: {CheckOutDate}\nCustomer Name: {Customer.FirstName} {Customer.LastName}\nTotal Cost: {CalculateReservationCost()}");
        }

    }
}
