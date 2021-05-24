using System;
using System.Threading.Tasks;
using Mcma.Worker;
using Mcma.Worker.Common;
using Microsoft.Azure.WebJobs;

namespace __mcmaNamespace__.Mcma.__moduleName__.Azure.Worker
{
    public class __moduleName__Worker
    {
        public __moduleName__Worker(IMcmaWorker worker)
        {
            Worker = worker ?? throw new ArgumentNullException(nameof(worker));
        }

        private IMcmaWorker Worker { get; }

        [FunctionName(nameof(__moduleName__Worker))]
        public Task ExecuteAsync(
            [QueueTrigger("__moduleNameKebab__-work-queue", Connection = "MCMA_WORK_QUEUE_STORAGE")] McmaWorkerRequest request,
            ExecutionContext executionContext)
        {
            return Worker.DoWorkAsync(request, executionContext.InvocationId.ToString());
        }
    }
}
