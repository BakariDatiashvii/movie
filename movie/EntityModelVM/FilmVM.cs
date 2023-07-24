using movie.EntityModel;

namespace movie.EntityModelVM
{
    public class FilmVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string janri { get; set; }
        public List<msaxiobiVM> Msaxiobebi { get; set; }
        public FilmpiradiVM filmpiradi { get; set; }
    }
}
