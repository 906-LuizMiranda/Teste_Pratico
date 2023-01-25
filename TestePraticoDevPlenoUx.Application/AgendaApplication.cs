using System;
using System.Net;
using System.Threading.Tasks;
using TestePraticoDevPlenoUx.Domain.Services.Interfaces;
using TestePraticoDevPlenoUx.DTO.Response;

namespace TestePraticoDevPlenoUx.Application
{
    public class AgendaApplication
    {
        #region Fields
        private readonly IAgendaService _agendaService;
        #endregion

        #region Ctor
        public AgendaApplication(IAgendaService agendaService)
        {
            _agendaService = agendaService;
        }
        #endregion

        #region Methods
        public async Task<GetAllNationalHolidaysResponseDTO> GetAllNationalHolidays()
        {
            try
            {
                var response = await _agendaService.GetAllNationalHolidays();
                return response;
            }
            catch(Exception ex)
            {
                return new GetAllNationalHolidaysResponseDTO()
                {
                    StatusCode = HttpStatusCode.InternalServerError,
                    ErrorMessage = ex.Message
                };
            }
        }
        #endregion
    }
}
