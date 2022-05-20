using HouseRentalManagementApp.Models;

namespace HRMS6.Data
{
    public class bookingrepo
    {
        public class BookingRepo
        {
            public static List<Booking> GetBookings()
            {



                List<Booking> bookings = new List<Booking>()
{
new Booking(){BookingId = 1, Address="Bhopal", Amount=3000, Duration=5},
new Booking(){BookingId = 2, Address="Bhopal", Amount=3000, Duration=5},
new Booking(){BookingId = 3, Address="Bhopal", Amount=3000, Duration=5},
new Booking(){BookingId = 4, Address="Bhopal", Amount=3000, Duration=5},
new Booking(){BookingId = 5, Address="Bhopal", Amount=3000, Duration=5},
new Booking(){BookingId = 6, Address="Bhopal", Amount=3000, Duration=5},
};
                return bookings;
            }
        }
    }
}
