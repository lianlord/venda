using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda.reservation
{
    class Reservation
    {
       

        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; private set; }
        public DateTime CheckOut { get; private set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            UpdateDates(checkIn, checkOut);
        }

        public int Duration()
        {
            return (int) CheckOut.Subtract(CheckIn).TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DoCheckIn(checkIn);
            DoCheckOut(checkOut);
        }
        
        public void DoCheckIn(DateTime checkIn)
        {
            DateTime now = DateTime.Now.AddSeconds(-2);
            if (checkIn < now)
            {
                throw new DomainException("CheckIn date can't be before now");
            }
            CheckIn = checkIn;
        }

        public void DoCheckOut(DateTime checkOut)
        {
            if (CheckIn >= checkOut)
            {
                throw new DomainException("Checkout should be after checkIn");
            }
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Reservation room: {RoomNumber} duration: {Duration()}";
        }


    }
}
