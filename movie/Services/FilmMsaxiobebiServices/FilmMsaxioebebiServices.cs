using movie.DBcontex;
using movie.FilmMsaxiobiDTO;

namespace movie.Services.FilmMsaxiobebiServices
{
    public class FilmMsaxioebebiServices : IFilmMsaxioebebiServices
    {
        private readonly FilmMsaxiobiDBcontext _context;

        public FilmMsaxioebebiServices(FilmMsaxiobiDBcontext context)
        {
            _context = context;
        }
        public Task<ServiceResponse<AddFilmMsaxiobiDTO>> AddMsaxiobiAndFilmGadabma(AddFilmMsaxiobiDTO addFilmMsaxiobiDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetFilmMsaxiobiDTO>>> DeleteMsaxiobiFilmiAll(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetFilmMsaxiobiDTO>>> GetMsaxiobiFilmiAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetFilmMsaxiobiDTO>> GetMsaxiobiFilmOnly(int id)
        {
            throw new NotImplementedException();
        }
    }
}
