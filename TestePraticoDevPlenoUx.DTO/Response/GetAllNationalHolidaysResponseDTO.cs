using System.Collections.Generic;

namespace TestePraticoDevPlenoUx.DTO.Response
{
    public class GetAllNationalHolidaysResponseDTO : BaseResponseDTO
    {
        public List<NationalHolidayDTO> Data { get; set; }
    }
}
