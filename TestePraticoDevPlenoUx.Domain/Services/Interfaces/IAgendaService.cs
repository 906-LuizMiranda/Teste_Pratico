using System.Collections.Generic;
using System.Threading.Tasks;
using TestePraticoDevPlenoUx.Domain.Entities;
using TestePraticoDevPlenoUx.DTO.Response;

namespace TestePraticoDevPlenoUx.Domain.Services.Interfaces
{
    public interface IAgendaService
    {
        Task<GetAllNationalHolidaysResponseDTO> GetAllNationalHolidays();
    }
}
