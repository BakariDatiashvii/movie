using movie.EntityModel;

namespace movie.EntityModelVM
{
    public class FilmpiradiVM
    {
        public int Id { get; set; }
        public string rejisori { get; set; }
        public int shemosavali { get; set; }
        public int filmebisid { get; set; }
        public FilmVM filmzogadi { get; set; }
    }
}
