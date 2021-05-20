using Mcma.Api.Routing.Defaults.Routes;
using Mcma.Azure.Functions.ApiHandler;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]

namespace __mcmaNamespace__.Mcma.Modules.__moduleName__.Azure.ApiHandler
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
            => builder.Services.AddMcmaAzureFunctionApiHandler(
                "__moduleNameSnake__-api-handler",
                builder =>
                {
                    // add routes here
                });
    }
}
