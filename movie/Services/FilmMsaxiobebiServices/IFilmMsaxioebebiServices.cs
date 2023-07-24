using movie.FilmMsaxiobiDTO;
using movie.MsaxiobebiDTO;

namespace movie.Services.FilmMsaxiobebiServices
{
    public interface IFilmMsaxioebebiServices
    {
        Task<ServiceResponse<AddFilmMsaxiobiDTO>> AddMsaxiobiAndFilmGadabma(AddFilmMsaxiobiDTO addFilmMsaxiobiDTO);
        Task<ServiceResponse<GetFilmMsaxiobiDTO>> GetMsaxiobiFilmOnly(int id);
        Task<ServiceResponse<List <GetFilmMsaxiobiDTO>>> GetMsaxiobiFilmiAll();

        Task<ServiceResponse<List<GetFilmMsaxiobiDTO>>> DeleteMsaxiobiFilmiAll(int id );





    }
}
