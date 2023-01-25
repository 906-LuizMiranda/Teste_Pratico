using System.Net;

namespace TestePraticoDevPlenoUx.DTO.Response
{
    public class BaseResponseDTO
    {
        public HttpStatusCode StatusCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
