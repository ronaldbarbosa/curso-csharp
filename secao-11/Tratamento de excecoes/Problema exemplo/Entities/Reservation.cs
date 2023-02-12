using Problema_exemplo.Entities.Exceptions;

namespace Problema_exemplo.Entities
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date must be after check-in date.");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be future dates.");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-out date musb be after check-in date.");
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        } 

        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {CheckIn.ToString("MM/dd/yyyy")}, check-out: {CheckOut.ToString("MM/dd/yyyy")}, {Duration()} nights";
        }
    }
}