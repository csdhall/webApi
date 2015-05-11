using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using Newtonsoft.Json.Serialization;

namespace _1_Request.Core
{
    public class GlobalErrorHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            context.Result = new ErrorResult(context.Request, new HttpResponseMessage
            {
                Content = new StringContent("Custom Message " + context.Exception.Message),
                StatusCode = HttpStatusCode.BadRequest
            });
        }
    }
}