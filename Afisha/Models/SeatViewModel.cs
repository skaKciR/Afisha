namespace Afisha.Models
{
    public class Seat
    {
        public int Row { get; set; }
        public int Column { get; set; }
    }

    public class SeatViewModel
    {
        public List<Seat> SelectedSeats { get; set; }
    }
}