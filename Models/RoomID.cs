using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation_MVVM.Models
{
    public class RoomID
    {
        public int _floorNumber { get; }
        public int _roomNumber { get; }

        public RoomID(int floorNumber, int roomNumber) 
        { 
            _floorNumber = floorNumber;
            _roomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{_floorNumber}{_roomNumber}";
        }

        public override bool Equals(object? obj)
        {
            return obj is RoomID _roomID && _floorNumber == _roomID._floorNumber && _roomNumber == _roomID._roomNumber;
        }

        public static bool operator ==(RoomID roomID1, RoomID roomID2) 
        {
            if (roomID1 is null && roomID2 is null) 
            {
                return true;
            }
            return !(roomID1 is null) && roomID1.Equals(roomID2);
        }

        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
            return !(roomID1 == roomID2);
        }

        public override int GetHashCode() 
        {
            return HashCode.Combine(_floorNumber, _roomNumber);
        }




    }
}
