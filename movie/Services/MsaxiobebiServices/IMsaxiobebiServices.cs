using movie.MsaxiobebiDTO;

namespace movie.Services.MsaxiobebiServices
{
    public interface IMsaxiobebiServices
    {

        Task<ServiceResponse<AddMsaxiobiDTO>> AddMsaxiobi(AddMsaxiobiDTO addMsaxiobiDTO);
        Task<ServiceResponse<AddMsaxiobiDTO>> GetMsaxiobiOnly(int id);
        Task<ServiceResponse<AddMsaxiobiDTO>> GetMsaxiobiAll();

        Task<ServiceResponse<GetMsaxiobiDTO>> GetMsaxiobiFilm(int id);

        Task<ServiceResponse<List<GetMsaxiobiDTO>>> GetAllMsaxiobebibyfilm();

        Task<ServiceResponse<GetMsaxiobiDTO>> UPdaiteMsaxiobi(UpdateMsaxiobiDTO UpdateMsaxiobiDTO);

        Task<ServiceResponse<List<DeleteMsaxiobiDTO>>> DeleteMsaxiobiDTO(int id);

    }
}
