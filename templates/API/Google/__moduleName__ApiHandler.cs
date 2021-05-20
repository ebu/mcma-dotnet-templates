using System;
using System.Threading.Tasks;
using Google.Cloud.Functions.Framework;
using Google.Cloud.Functions.Hosting;
using Mcma.GoogleCloud.HttpFunctionsApi;
using Microsoft.AspNetCore.Http;

namespace __mcmaNamespace__.Mcma.Modules.__moduleName__.GoogleCloud.ApiHandler
{
    [FunctionsStartup(typeof(__moduleName__ApiHandlerStartup))]
    public class __moduleName__ApiHandler : IHttpFunction
    {
        public __moduleName__ApiHandler(IHttpFunctionApiController controller)
        {
            Controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        private IHttpFunctionApiController Controller { get; }

        public Task HandleAsync(HttpContext context) => Controller.HandleRequestAsync(context);
    }
}
