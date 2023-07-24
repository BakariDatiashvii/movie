using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie.DBcontex;
using movie.EntityModelVM;

namespace movie.Controllers
{
    public class GetAllTableController : ControllerBase
    {
        private readonly FilmMsaxiobiDBcontext _conetxt;

        public GetAllTableController(FilmMsaxiobiDBcontext context)
        {
            _conetxt = context;
        }

        [HttpGet("get-all")]
        public ActionResult<List<FilmpiradiVM>> GetAllTable()
        {
            var yvela = _conetxt.filmpiradis
                .Include(x => x.filmzogadi)
                .ThenInclude(z => z.Msaxiobebi)
                .ThenInclude(p => p.Msaxiebebi)
                .ThenInclude(c => c.msaxiobispiradi)
                .Select(m => new FilmpiradiVM()
                {
                    Id = m.Id,
                    rejisori = m.rejisori,
                    shemosavali = m.shemosavali,
                    filmebisid = m.filmebisid,
                    filmzogadi = new FilmVM()
                    {
                        Id = m.filmzogadi.Id,
                        Name = m.filmzogadi.Name,
                        Description = m.filmzogadi.Description,
                        janri = m.filmzogadi.janri,
                        Msaxiobebi = m.filmzogadi.Msaxiobebi.Select(v => new msaxiobiVM()
                        {
                            Id = v.Msaxiebebi.Id,
                            Name = v.Msaxiebebi.Name,
                            gvari = v.Msaxiebebi.gvari,
                            asaki = v.Msaxiebebi.asaki,
                            msaxiobispiradi = new msaxiobispiradiVM()
                            {
                                Id = v.Msaxiebebi.msaxiobispiradi.Id,
                                piradinomeri = v.Msaxiebebi.msaxiobispiradi.piradinomeri,
                                kanisferi = v.Msaxiebebi.msaxiobispiradi.kanisferi,
                                shemosavali = v.Msaxiebebi.msaxiobispiradi.shemosavali,
                                msaxiobiId = v.Msaxiebebi.msaxiobispiradi.msaxiobiId,
                            }
                        }).ToList(),
                    }
                }).ToList();
            return yvela;
        }
        [HttpGet("get-all-uninclude")]
        public ActionResult<List<FilmpiradiVM>> getall()
        {
            var all = _conetxt.filmpiradis.Select(m => new FilmpiradiVM()
            {
                Id = m.Id,
                rejisori = m.rejisori,
                shemosavali = m.shemosavali,
                filmebisid = m.filmebisid,
                filmzogadi = new FilmVM()

            }).ToList();
            foreach (var item in all)
            {

                var filmebi = _conetxt.film.FirstOrDefault(x => x.Id == item.filmebisid);
                if (filmebi == null)
                {
                    return all;
                }
                item.filmzogadi.Id = filmebi.Id;
                item.filmzogadi.Name = filmebi.Name;
                item.filmzogadi.Description = filmebi.Description;
                item.filmzogadi.janri = filmebi.janri;
                item.filmzogadi.Msaxiobebi = _conetxt.filmmsaxiobi.Where(x => x.filmID == item.Id)
                    .Select(v => new msaxiobiVM()
                    {
                        Id = v.Msaxiebebi.Id,
                        Name = v.Msaxiebebi.Name,
                        gvari = v.Msaxiebebi.gvari,
                        asaki = v.Msaxiebebi.asaki,
                        msaxiobispiradi = new msaxiobispiradiVM()
                        {
                            Id = v.Msaxiebebi.msaxiobispiradi.Id,
                            piradinomeri = v.Msaxiebebi.msaxiobispiradi.piradinomeri,
                            kanisferi = v.Msaxiebebi.msaxiobispiradi.kanisferi,
                            shemosavali = v.Msaxiebebi.msaxiobispiradi.shemosavali,
                            msaxiobiId = v.Msaxiebebi.msaxiobispiradi.msaxiobiId,
                        }
                    }).ToList();

            }
            return all;
        }

        [HttpGet("msaxiobi-personal-info-one-msaxiobi")]
        public ActionResult<msaxiobispiradiVM> dasabrunebeli(int Id)
        {
            var one = _conetxt.msaxiobispiradis
                .Include(x => x.msaxiobizogadi)
                .ThenInclude(z => z.Filmebinatamashebi)
                .ThenInclude(c => c.Filmebi)
                .ThenInclude(m => m.filmpiradi)
                .FirstOrDefault(n => n.Id == Id);

           

            var onenapovni = new msaxiobispiradiVM()
            {
                Id = one.Id,
                piradinomeri = one.piradinomeri,
                kanisferi = one.kanisferi,
                shemosavali = one.shemosavali,
                msaxiobiId = one.msaxiobiId,
                msaxiobizogadi = new msaxiobiVM()
                {
                    Id = one.msaxiobizogadi.Id,
                    Name = one.msaxiobizogadi.Name,
                    gvari = one.msaxiobizogadi.gvari,
                    asaki = one.msaxiobizogadi.asaki,
                    Filmebinatamashebi = _conetxt.filmmsaxiobi.Select(c => new FilmVM()
                    {
                        Id = c.Filmebi.Id,
                        Name = c.Filmebi.Name,
                        Description = c.Filmebi.Description,
                        janri = c.Filmebi.janri,
                        filmpiradi = new FilmpiradiVM()
                        {
                            Id = c.Filmebi.filmpiradi.Id,
                            rejisori = c.Filmebi.filmpiradi.rejisori,
                            shemosavali = c.Filmebi.filmpiradi.shemosavali,
                            filmebisid = c.Filmebi.filmpiradi.filmebisid
                        }

                    }).ToList(),
                }

            };
            return onenapovni;

        }


    }
}
