using movie.FilmebiDTO;

namespace movie.Services.FIlmebiServices
{
    public interface IFilmebiServices
    {
        Task<ServiceResponse<AddFilmDTO>> AddFilm(AddFilmDTO addFilmDTO);
        Task<ServiceResponse<AddFilmDTO>> GetFilmOnly(int id);
        Task<ServiceResponse<GetFilmDTO>> GetFilmMsaxiobebi(int id);
       
        Task<ServiceResponse<List<GetFilmDTO>>> GetAllFilmsbyMsaxiobi();

        Task<ServiceResponse<GetFilmDTO>> UPdaiteFilmMsaxioebebit (UpdateFilmDTO updateFilmDTO);

        Task<ServiceResponse<List<DeleteFilmDTO>>> DeleteFilmMsaxiobebi(int id);



    }
}
