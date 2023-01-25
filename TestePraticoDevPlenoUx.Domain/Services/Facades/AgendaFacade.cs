using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TestePraticoDevPlenoUx.Domain.Services.Facades.Interfaces;
using TestePraticoDevPlenoUx.DTO;
using TestePraticoDevPlenoUx.DTO.Response;

namespace TestePraticoDevPlenoUx.Domain.Services.Facades
{
    public class AgendaFacade : BaseFacade, IAgendaFacade
    {
        #region Fields
        protected readonly IConfiguration _configuration;
        private readonly string tes = Environment.GetEnvironmentVariable("DADOS_BR_API_URL");
        private string consultNationalHolidayPath = "feriados/nacionais.json";
        #endregion

        #region Ctor
        public AgendaFacade(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #endregion

        #region Methods
        public async Task<GetAllNationalHolidaysResponseDTO> ConsultNationalHoliday()
        {
            var dadosBrUrl = _configuration.GetSection("Endpoints").GetSection("DADOS_BR_API_URL").Value;

            var result = await Get(dadosBrUrl + consultNationalHolidayPath, null);

            return await HandleConsultNationalHolidayReturn(result);
        }
        #endregion

        #region Private Methods
        public async Task<GetAllNationalHolidaysResponseDTO> HandleConsultNationalHolidayReturn(HttpResponseMessage httpResponseMessage)
        {
            var jsonObject = await httpResponseMessage.Content.ReadAsStringAsync();
            var jsonDeserialized = JsonConvert.DeserializeObject<List<NationalHolidayDTO>>(jsonObject);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return new GetAllNationalHolidaysResponseDTO()
                {
                    StatusCode = httpResponseMessage.StatusCode,
                    Data = jsonDeserialized
                };
            }
            else
            {
                return new GetAllNationalHolidaysResponseDTO()
                {
                    StatusCode = httpResponseMessage.StatusCode,
                    ErrorMessage = jsonObject
                };
            }
        }
        #endregion
    }
}
