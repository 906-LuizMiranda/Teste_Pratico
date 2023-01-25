using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using TestePraticoDevPlenoUx.Domain.Entities;
using TestePraticoDevPlenoUx.Domain.Services.Facades.Interfaces;
using TestePraticoDevPlenoUx.Domain.Services.Interfaces;
using TestePraticoDevPlenoUx.DTO.Response;

namespace TestePraticoDevPlenoUx.Domain.Services
{
    public class AgendaService : IAgendaService
    {
        #region Fields
        private readonly IAgendaFacade _agendaFacade;
        //private readonly IAgendaService _agendaService;
        #endregion

        #region Ctor
        public AgendaService(IAgendaFacade agendaFacade)
        {
            _agendaFacade = agendaFacade;
        }
        #endregion

        #region Methods
        public async Task<GetAllNationalHolidaysResponseDTO> GetAllNationalHolidays()
        {
            try
            {
                var response = await _agendaFacade.ConsultNationalHoliday();
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
