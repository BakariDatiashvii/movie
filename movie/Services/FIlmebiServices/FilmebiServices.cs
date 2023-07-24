using Microsoft.EntityFrameworkCore;
using movie.DBcontex;
using movie.MsaxiobebiDTO;

namespace movie.Services.FIlmebiServices
{
    public class FilmebiServices : IFilmebiServices
    {
        private readonly FilmMsaxiobiDBcontext _context;

        public FilmebiServices(FilmMsaxiobiDBcontext context)
        {
            _context = context;
        }
        public Task<ServiceResponse<AddFilmDTO>> AddFilm(AddFilmDTO addFilmDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<DeleteFilmDTO>>> DeleteFilmMsaxiobebi(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetFilmDTO>>> GetAllFilmsbyMsaxiobi()
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetFilmDTO>> GetFilmMsaxiobebi(int id)
        {
            var service = new ServiceResponse<GetFilmDTO>();
            var napovnifilm = await  _context.film.FirstOrDefaultAsync(x => x.Id == id);
            if (napovnifilm == null)
            {
                service.Massage = "sworad chawere bicho";
                return service;
            }
            var getfilmdto = new GetFilmDTO()
            {
                Id = napovnifilm.Id,
                Name = napovnifilm.Name,
                Description = napovnifilm.Description,
                janri = napovnifilm.janri,
                Msaxiobebidto = new List<AddMsaxiobiDTO>()

            };

            getfilmdto.Msaxiobebidto = await _context.filmmsaxiobi
                .Where(x => x.filmID == getfilmdto.Id)
                .Select(z => new AddMsaxiobiDTO()
                {
                    Id = z.Msaxiebebi.Id,
                    Name = z.Msaxiebebi.Name,
                    gvari = z.Msaxiebebi.gvari,
                    asaki = z.Msaxiebebi.asaki


                }).ToListAsync();

          
            service.Data = getfilmdto;
            service.Massage = "kargia bijoooooo";
            return service;
        }

        public Task<ServiceResponse<AddFilmDTO>> GetFilmOnly(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<GetFilmDTO>> UPdaiteFilmMsaxioebebit(UpdateFilmDTO updateFilmDTO)
        {
            var napovnifilm = await _context.film.FirstOrDefaultAsync(x => x.Id == updateFilmDTO.Id);

            var getfilmdto = new GetFilmDTO()
            {
                Id = napovnifilm.Id,
                Name = napovnifilm.Name,
                Description = napovnifilm.Description,
                janri = napovnifilm.janri,
                Msaxiobebidto = new List<AddMsaxiobiDTO>()

            };




            var x = _context.filmmsaxiobi.Where(x => x.Id == getfilmdto.Id);

            foreach (var t  in x)
            {
                
            }


            //ერორიააააააააააააააააა


            var service = new ServiceResponse<GetFilmDTO>();
            service.Data = getfilmdto;
            return service;










        }
    }
}
