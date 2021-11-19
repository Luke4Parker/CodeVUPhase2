using System;
using System.Collections.Generic;
using System.Text;

namespace HotelAssignment11_19
{
    class Room
    {
        //Constants
        const int SINGLEPRICE = 50;
        const int DOUBLEPRICE = 50;
        const int QUEENPRICE = 85;
        const int KINGPRICE = 100;

        //props
        public int RoomNumber { get; set; }
        public RoomType RoomSize { get; set; }
        public enum RoomType
        {
            SingleBed, DoubleBed, QueenBed, KingBed
        }
        
        public Room(int roomNumber, RoomType room)
        {
            this.RoomNumber = roomNumber;
            this.RoomSize = room;
        }

        
        public int GetRoomPrice()
        {
            switch (this.RoomSize)
            {
                case RoomType.SingleBed:
                    return SINGLEPRICE;
                case RoomType.DoubleBed:
                    return DOUBLEPRICE;
                case RoomType.QueenBed:
                    return QUEENPRICE;
                case RoomType.KingBed:
                    return KINGPRICE;
                default:
                    throw new Exception ("What did you do");
            }
        }
        public override string ToString()
        {
            return string.Format($"Room Number: {RoomNumber}\nRoom Size: {RoomSize}\n Room Price: {GetRoomPrice()}");
        }
    }
}
