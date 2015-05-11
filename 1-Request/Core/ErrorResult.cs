using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace _1_Request.Core
{
    public class ErrorResult : IHttpActionResult
    {
        private readonly HttpRequestMessage _request;
        private readonly HttpResponseMessage _response;

        public ErrorResult(HttpRequestMessage request, HttpResponseMessage response)
        {
            _request = request;
            _response = response;
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            _response.RequestMessage = _request;
            _response.StatusCode = HttpStatusCode.InternalServerError;
            return Task.FromResult(_response);
        }
    }
}