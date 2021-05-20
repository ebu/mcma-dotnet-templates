using Mcma.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Startup))]

namespace __mcmaNamespace__.Mcma.Modules.__moduleName__.Azure.Worker
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
            => builder.Services.AddMcmaAzureFunctionWorker(
                "__moduleNameSnake__-worker",
                builder =>
                {
                    // add worker operations here
                });

    }
}