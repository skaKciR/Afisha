using Afisha.Domain.Entities;

namespace Afisha.Models
{
    public class HomeIndexViewModel
    {
        public IQueryable<Event> Slider { get; set; }
        public IQueryable<Event> Cinemas { get; set; }
        public IQueryable<Event> Plays { get; set; }
        public IQueryable<Event> StandUps { get; set; }
        public IQueryable<Event> Concerts { get; set; }

    }
}
