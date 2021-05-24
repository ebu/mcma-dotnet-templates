using Mcma.GoogleCloud.Functions.Worker;
using Mcma.Worker;
using Microsoft.Extensions.DependencyInjection;

namespace __mcmaNamespace__.Mcma.__moduleName__.GoogleCloud.Worker
{
    public class __moduleName__WorkerStartup : McmaWorkerStartup
    {
        protected override string ApplicationName => "__moduleNameKebab__-worker";

        protected override IServiceCollection ConfigureAdditionalServices(IServiceCollection services)
        {
            // add any additional services the worker needs here
        }

        
        protected override void BuildWorker(McmaWorkerBuilder workerBuilder)
        {
            // add worker operations here
        }
    }
}