using Microsoft.AspNetCore.Mvc;
using movie.Services.MsaxiobebiServices;

namespace movie.ControlersDTO
{
    public class MsaxiobiControllerDto : ControllerBase
    {
        private readonly IMsaxiobebiServices _msaxiobebiServices;
        public MsaxiobiControllerDto(IMsaxiobebiServices msaxiobebiServices)
        {
                _msaxiobebiServices = msaxiobebiServices;
        }
    }
}
