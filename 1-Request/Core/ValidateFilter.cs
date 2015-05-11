using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;

namespace _1_Request.Core
{
    public class ValidateFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Exception is ValidationException)
            {
                throw new HttpResponseException(new HttpResponseMessage
                {
                    Content = new StringContent(actionExecutedContext.Exception.Message),
                    StatusCode = HttpStatusCode.BadRequest,
                    ReasonPhrase = "Validation Exception"
                });
            }
        }
    }
}