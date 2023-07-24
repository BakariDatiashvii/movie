using movie.MsaxiobebiDTO;

namespace movie.FilmMsaxiobiDTO
{
    public class GetFilmMsaxiobiDTO
    {
        public int Id { get; set; }
        public int filmID { get; set; }
        public int msaxiobiID { get; set; }

        public AddFilmDTO AddFilm { get; set; }
        public AddMsaxiobiDTO AddMsaxiobi { get; set;}
    }
}
