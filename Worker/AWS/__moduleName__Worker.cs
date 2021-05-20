using Amazon.Lambda.Core;
using Mcma.Aws.Functions;
using Mcma.Aws.Functions.ApiHandler;
using Mcma.Aws.Functions.Worker;
using Mcma.Aws.Lambda;
using Mcma.Worker;
using Mcma.Worker.Common;
using Microsoft.Extensions.DependencyInjection;

[assembly: LambdaSerializer(typeof(McmaLambdaSerializer))]

namespace Mcma.Modules.__moduleName__.Aws.Worker
{
    public class __moduleName__Worker : McmaLambdaFunction<McmaLambdaWorker, McmaWorkerRequest>
    {
        protected override void Configure(IServiceCollection services)
            => services.AddMcmaAwsLambdaWorker(
                "__moduleNameSnake__-worker",
                builder =>
                {
                    // add job operations here
                });
    }
}
