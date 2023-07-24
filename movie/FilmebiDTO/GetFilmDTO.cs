using movie.EntityModelVM;
using movie.MsaxiobebiDTO;

namespace movie.FilmebiDTO
{
    public class GetFilmDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string janri { get; set; }
        public List<AddMsaxiobiDTO> Msaxiobebidto { get; set; }

       
    }
}
