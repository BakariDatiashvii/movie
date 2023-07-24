using movie.DBcontex;
using movie.MsaxiobebiDTO;

namespace movie.Services.MsaxiobebiServices
{
    public class MsaxiobebiServices : IMsaxiobebiServices
    {

        private readonly FilmMsaxiobiDBcontext _context;

        public MsaxiobebiServices(FilmMsaxiobiDBcontext context)
        {
            _context = context;
        }

        public Task<ServiceResponse<AddMsaxiobiDTO>> AddMsaxiobi(AddMsaxiobiDTO addMsaxiobiDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<DeleteMsaxiobiDTO>>> DeleteMsaxiobiDTO(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetMsaxiobiDTO>>> GetAllMsaxiobebibyfilm()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AddMsaxiobiDTO>> GetMsaxiobiAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetMsaxiobiDTO>> GetMsaxiobiFilm(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AddMsaxiobiDTO>> GetMsaxiobiOnly(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetMsaxiobiDTO>> UPdaiteMsaxiobi(UpdateMsaxiobiDTO UpdateMsaxiobiDTO)
        {
            throw new NotImplementedException();
        }
    }
}
