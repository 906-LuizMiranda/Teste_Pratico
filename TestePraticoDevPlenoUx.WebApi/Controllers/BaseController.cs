using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace TestePraticoDevPlenoUx.WebApi.Controllers
{
    [ApiController]
    public class BaseController : Controller
    {
        #region Fields
        #endregion

        #region Ctor
        protected BaseController()
        {
        }
        #endregion

        #region Methods
        protected IActionResult CreateResponse(HttpStatusCode statusCode, object result)
        {
            return new ObjectResult(result) { StatusCode = (int)statusCode };
        }
        #endregion
    }
}
