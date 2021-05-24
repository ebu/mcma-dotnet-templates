using System;
using System.Threading;
using System.Threading.Tasks;
using CloudNative.CloudEvents;
using Google.Cloud.Functions.Framework;
using Google.Cloud.Functions.Hosting;
using Mcma.GoogleCloud.Functions.Worker;
using Mcma.Worker;

namespace __mcmaNamespace__.Mcma.__moduleName__.GoogleCloud.Worker
{
    [FunctionsStartup(typeof(__moduleName__WorkerStartup))]
    public class __moduleName__Worker : ICloudEventFunction<McmaWorkerRequest>
    {
        public __moduleName__Worker(IMcmaWorker worker)
        {
            Worker = worker ?? throw new ArgumentNullException(nameof(worker));
        }
     
        private IMcmaWorker Worker { get; }

        public Task HandleAsync(CloudEvent cloudEvent, McmaWorkerRequest workerRequest, CancellationToken cancellationToken)
            => Worker.DoWorkAsync(new McmaWorkerRequestContext(workerRequest, cloudEvent.Id));
    }
}
