using movie.MsaxiobebiDTO;

namespace movie.FilmebiDTO
{
    public class UpdateFilmDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string janri { get; set; }

       public List<UpdateMsaxiobiDTO> msaxiobiDTOs { get; set; }
    }
}
