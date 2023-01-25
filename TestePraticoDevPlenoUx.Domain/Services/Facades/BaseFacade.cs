using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestePraticoDevPlenoUx.Domain.Services.Facades
{
    public class BaseFacade
    {
        #region Fields
        private static readonly HttpClient client = new HttpClient();
        #endregion

        #region Ctor
        public BaseFacade()
        {
        }
        #endregion

        #region Methods
        public async Task<HttpResponseMessage> Get(string url, IDictionary<string, string> headers)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url)
            };

            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }

            return await client.SendAsync(request);
        }
        #endregion
    }
}
