using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation_MVVM.Models
{
    public class Reservation
    {
        public RoomID _roomID { get; }  
        public string _userName { get;}
        public DateTime _startTime { get; }
        public DateTime _endTime { get; }

        public TimeSpan length => _endTime.Subtract(_startTime); 

        public Reservation(RoomID roomID, string userName, DateTime startTime, DateTime endTime)
        {
            _roomID = roomID;
            _userName = userName;
            _startTime = startTime;
            _endTime = endTime;
        }

        public bool Conflicts(Reservation reservation)
        {
            if (reservation._roomID != _roomID)
            {
                return false;
            }

            return reservation._startTime < _endTime && reservation._endTime > _startTime;
        }

    }
}
