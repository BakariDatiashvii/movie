using Microsoft.AspNetCore.Mvc;
using movie.Services.FIlmebiServices;

namespace movie.ControlersDTO
{
    public class FilmControlerDto : ControllerBase
    {
        public readonly IFilmebiServices _filmebiServices;

        public FilmControlerDto (IFilmebiServices filmebiServices)
        {
            _filmebiServices = filmebiServices;
        }

        [HttpGet("get-film-msaxiob")]

        public async Task<ActionResult<ServiceResponse<GetFilmDTO>>> GetFilmMsaxiobebi1(int id )
        {
           return await _filmebiServices.GetFilmMsaxiobebi(id);
        }


    }
}
