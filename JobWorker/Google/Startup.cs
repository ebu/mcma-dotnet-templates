using Mcma.GoogleCloud.Functions.Worker;
using Mcma.Worker;
using Microsoft.Extensions.DependencyInjection;

namespace __mcmaNamespace__.Mcma.Modules.__moduleName__.GoogleCloud.Worker
{
    public class __moduleName__WorkerStartup : McmaJobAssignmentWorkerStartup<__jobType__Job>
    {
        protected override string ApplicationName => "__moduleNameSnake__-worker";

        protected override void AddProfiles(ProcessJobAssignmentOperationBuilder<__jobType__Job> builder)
        {
            // add worker operations here
        }
    }
}