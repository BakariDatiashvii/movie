using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie.DBcontex;
using movie.EntityModel;
using movie.EntityModelVM;

namespace movie.Controllers
{
    public class PersonalInfoController : ControllerBase
    {
        private readonly FilmMsaxiobiDBcontext _conetxt;

        public PersonalInfoController(FilmMsaxiobiDBcontext context)
        {
            _conetxt = context;
        }
        [HttpPost("create-film-personal")]
        public ActionResult<bool> createfilmpersonal (FilmpiradiVM sheyvana)
        {
            var insert = new Filmpiradi()
            {
                Id = sheyvana.Id,
                rejisori = sheyvana.rejisori,
                shemosavali = sheyvana.shemosavali,
                filmebisid = sheyvana.filmebisid
            };
            _conetxt.filmpiradis.Add(insert);
            _conetxt.SaveChanges();
            return true;
        }

        [HttpPost("create-msaxiobi-personal")]
        public ActionResult<bool> createmsaxiobipersonal (msaxiobispiradiVM sheyvana)
        {
            var insert = new msaxiobispiradi()
            {
                Id = sheyvana.Id,
                piradinomeri = sheyvana.piradinomeri,
                kanisferi = sheyvana.kanisferi,
                shemosavali = sheyvana.shemosavali,
                msaxiobiId = sheyvana.msaxiobiId
            };
            _conetxt.msaxiobispiradis.Add(insert);
            _conetxt.SaveChanges();
            return true;
        }
        [HttpGet("Filmpiradi-Film")]
        public ActionResult<FilmpiradiVM> filmpiradifilm (int ID)
        {
            var dabruneba = _conetxt.filmpiradis.FirstOrDefault(x=> x.Id == ID);
            var napovni = new FilmpiradiVM()
            {
                Id = dabruneba.Id,
                rejisori = dabruneba.rejisori,
                shemosavali = dabruneba.shemosavali,
                filmebisid = dabruneba.filmebisid,
                filmzogadi = new FilmVM()
  

            };

            var filmfind = _conetxt.film.FirstOrDefault(x=> x.Id == napovni.filmebisid);
            napovni.filmzogadi.Id = filmfind.Id;
            napovni.filmzogadi.Name = filmfind.Name;
            napovni.filmzogadi.Description = filmfind.Description;
            napovni.filmzogadi.janri = filmfind.janri;
            return napovni;

        }

        [HttpGet("film-filmpiradi")]
        public ActionResult<List<FilmVM>> filmfilmpiradi()
        {
            var wamogeba = _conetxt.film.Include(x=> x.filmpiradi).Select(z=> new FilmVM()
            {
                Id = z.Id,
                Name = z.Name,
                Description = z.Description,
                janri = z.janri,
                filmpiradi = new FilmpiradiVM()
                {
                    Id = z.filmpiradi.Id,
                    rejisori = z.filmpiradi.rejisori,
                    shemosavali = z.filmpiradi.shemosavali,
                    filmebisid = z.filmpiradi.filmebisid
                }
            }).ToList();
            return wamogeba;
        }
        
    }
}
