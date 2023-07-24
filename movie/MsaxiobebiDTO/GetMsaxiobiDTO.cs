using movie.EntityModelVM;

namespace movie.MsaxiobebiDTO
{
    public class GetMsaxiobiDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string gvari { get; set; }
        public int asaki { get; set; }

       public List<AddFilmDTO>  Fiilmebidto { get; set; }
    }
}
