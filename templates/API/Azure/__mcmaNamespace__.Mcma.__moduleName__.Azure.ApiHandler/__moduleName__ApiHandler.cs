using System;
using System.Threading.Tasks;
using Mcma.Azure.FunctionsApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;

namespace __mcmaNamespace__.Mcma.__moduleName__.Azure.ApiHandler
{
    public class __moduleName__ApiHandler
    {
        public __moduleName__ApiHandler(IAzureFunctionApiController controller)
        {
            Controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        private IAzureFunctionApiController Controller { get; }

        [FunctionName(nameof(__moduleName__ApiHandler))]
        public async Task<IActionResult> ExecuteAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, Route = "{*resourcePath}")] HttpRequest request,
            string resourcePath,
            ExecutionContext executionContext)
        {
            return await Controller.HandleRequestAsync(request, executionContext);
        }
    }
}