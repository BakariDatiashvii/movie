namespace movie.EntityModel
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string janri { get; set; }
        public List<FilmMsaxiobi> Msaxiobebi { get; set; }
        public Filmpiradi filmpiradi { get; set; }
    }
}
