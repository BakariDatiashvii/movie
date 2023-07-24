using Microsoft.AspNetCore.Mvc;
using movie.DBcontex;
using movie.EntityModel;
using movie.EntityModelVM;

namespace movie.Controllers
{
    public class FilmMsaxiobiController : ControllerBase
    {
        private readonly FilmMsaxiobiDBcontext _conetxt;

        public FilmMsaxiobiController(FilmMsaxiobiDBcontext context)
        {
            _conetxt = context;
        }
        [HttpPost("insert-filmebi")]
        public ActionResult<bool> insertfilmebi (FilmVM sheqmna)
        {
            var shetana = new Film()
            {
                Id = sheqmna.Id,
                Name = sheqmna.Name,
                Description = sheqmna.Description,
                janri = sheqmna.janri
                
            };
            _conetxt.film.Add(shetana);
            _conetxt.SaveChanges();
            return true;
        }

        [HttpPost("msaxiobebi-sheqmna")]
        public ActionResult<bool> msaxiobebisheqmnda(msaxiobiVM sheqmnamsaxiobi)
        {
            var msaxsheqmna = new msaxiobi()
            {
                Id = sheqmnamsaxiobi.Id,
                Name = sheqmnamsaxiobi.Name,
                gvari = sheqmnamsaxiobi.gvari,
                asaki = sheqmnamsaxiobi.asaki

            };
            _conetxt.msaxiobi.Add(msaxsheqmna);
            _conetxt.SaveChanges();
            return true;

        }
        [HttpDelete("delete-film-gadabmebi")]
        public ActionResult<bool> deleteyvela(int deleteID)
        {

            var gadabmuli = _conetxt.filmmsaxiobi.Where(x => x.filmID == deleteID).ToList();

            foreach (var item in gadabmuli)
            {
                _conetxt.filmmsaxiobi.Remove(item);
                _conetxt.SaveChanges();
            }

            return true;
        }

        [HttpDelete("delete-film")]
        public ActionResult<bool> deletefilm(int deleteID)
        {
            var delete = _conetxt.film.FirstOrDefault(x => x.Id == deleteID);
            {
                if (delete == null)
                {
                    return false;
                }
                _conetxt.film.Remove(delete);
                _conetxt.SaveChanges();
                return true;
            }
        }

        [HttpDelete("delete-yvelafrit")]
        public ActionResult<bool> deleteyvelafrit (int deleteID)
        {
            var gadabmuli = _conetxt.filmmsaxiobi.Where(x => x.filmID == deleteID).ToList();

            foreach (var item in gadabmuli)
            {
                _conetxt.filmmsaxiobi.Remove(item);
                _conetxt.SaveChanges();
            }
            var filmdelete = _conetxt.film.FirstOrDefault(x=> x.Id == deleteID);
            _conetxt.film.Remove(filmdelete);
            _conetxt.SaveChanges();
            return true;
        }


        [HttpPost("create-film-msaxiobebi")]
        public ActionResult<bool> createfilmmsaxiobi (FilmMsaxiobiVM Idebi)
        {
            var shetanaFm = new FilmMsaxiobi()
            {
                Id = Idebi.ID,
                filmID = Idebi.filmID,
                msaxiobiID = Idebi.msaxiobiID

            };
           
            _conetxt.filmmsaxiobi.Add(shetanaFm);
            _conetxt.SaveChanges();
            return true;

        }
        

        

    }
}
