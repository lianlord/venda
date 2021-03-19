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
<<<<<<< HEAD
                throw new DomainException("CheckIn date can't be before now");
=======
                throw new ReservationException("CheckIn date can't be before now");
>>>>>>> 041ee45c792e7eb966c015c230bd4a41345f5758
            }
            CheckIn = checkIn;
        }

        public void DoCheckOut(DateTime checkOut)
        {
            if (CheckIn >= checkOut)
            {
<<<<<<< HEAD
                throw new DomainException("Checkout should be after checkIn");
=======
                throw new ReservationException("Checkout should be after checkIn");
>>>>>>> 041ee45c792e7eb966c015c230bd4a41345f5758
            }
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Reservation room: {RoomNumber} duration: {Duration()}";
        }


    }
}
