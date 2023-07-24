using Microsoft.AspNetCore.Mvc;

namespace movie.ControlersDTO
{
    public class FilmMsaxiobebiControllerDto : ControllerBase
    {
        private readonly IFilmMsaxioebebiServices _filmMsaxioebebiServices1; 
        public FilmMsaxiobebiControllerDto(IFilmMsaxioebebiServices filmMsaxioebebiServices)
        {
                _filmMsaxioebebiServices1 = filmMsaxioebebiServices;
        }

    }
}
