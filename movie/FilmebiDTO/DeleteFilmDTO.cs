using movie.MsaxiobebiDTO;

namespace movie.FilmebiDTO
{
    public class DeleteFilmDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string janri { get; set; }

        public List <DeleteMsaxiobiDTO> deleteMsaxiobiDTOs { get; set; }
    }
}
