using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie.DBcontex;
using movie.EntityModel;
using movie.EntityModelVM;

namespace movie.Controllers
{
    public class GetFilmMsaxiobiController : ControllerBase
    {
        private readonly FilmMsaxiobiDBcontext _conetxt;

        public GetFilmMsaxiobiController(FilmMsaxiobiDBcontext context)
        {
            _conetxt = context;
        }
        [HttpGet("msaxiobebibi-film")]
        public ActionResult<List<msaxiobiVM>> filmmsaxiobebi()
        {
            var ms = _conetxt.msaxiobi.Include(x=> x.Filmebinatamashebi).ThenInclude(z => z.Filmebi).Select(m=> new msaxiobiVM()
            {
                Id = m.Id,
                Name = m.Name,
                gvari = m.gvari,
                asaki = m.asaki,
                Filmebinatamashebi = m.Filmebinatamashebi.Select(x=> new FilmVM() 
                {
                    Id = x.Filmebi.Id,
                    Name = x.Filmebi.Name,
                    Description = x.Filmebi.Description,
                    janri = x.Filmebi.janri,
                    


                }).ToList(),

            }).ToList();
            return ms;
            
        }
        [HttpGet("film-msaxiobebit")]
        public ActionResult<List<FilmVM>> filmmsaxiobi()
        {
            var film = _conetxt.film.Select(x=> new FilmVM()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                janri = x.janri,
                Msaxiobebi = new List<msaxiobiVM>()   
            }).ToList();
            foreach (var item in film)
            {
                item.Msaxiobebi = _conetxt.filmmsaxiobi.Where(x => x.filmID == item.Id).Select(x => new msaxiobiVM()
                {
                    Id = x.Msaxiebebi.Id,
                    Name = x.Msaxiebebi.Name,
                    gvari = x.Msaxiebebi.gvari,
                    asaki = x.Msaxiebebi.asaki


                }).ToList();  
                
            };

            return film;
        }



    }
}
