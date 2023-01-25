using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using TestePraticoDevPlenoUx.Application;
using TestePraticoDevPlenoUx.DTO.Response;

namespace TestePraticoDevPlenoUx.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class AgendaController : BaseController
    {
        #region Fields
        private AgendaApplication _agendaApplication;
        #endregion

        #region Ctor
        public AgendaController(AgendaApplication agendaApplication)
        {
            _agendaApplication = agendaApplication;
        }
        #endregion

        #region Methods
        [HttpGet("national-holidays/all")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(GetAllNationalHolidaysResponseDTO))]
        [ProducesResponseType((int)HttpStatusCode.InternalServerError, Type = typeof(BaseResponseDTO))]
        public async Task<IActionResult> GetAllNationalHolidays()
        {            
            var response = await _agendaApplication.GetAllNationalHolidays();
            return CreateResponse(response.StatusCode, response);
        }

        //[HttpGet]
        //[Route("national-holidays/{month}")]
        //public async Task<ActionResult<dynamic>> GetNationalHolidaysByMonth()
        //{
        //    var response = await _agendaApplication.GetNationalHolidaysByMonth();
        //    return CreateResponse(response.StatusCode, response);
        //}

        //[HttpPatch]
        //[Route("update/holiday/description")]
        //public async Task<ActionResult<dynamic>> UpdateHolidayDescription()
        //{
        //    var response = await _agendaApplication.UpdateHolidayDescription();
        //    return CreateResponse(response.StatusCode, response);
        //}
        #endregion
    }
}
