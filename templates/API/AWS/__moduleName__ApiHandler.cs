using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using Mcma.Api.Routing.Defaults.Routes;
using Mcma.Aws.Functions;
using Mcma.Aws.Functions.ApiHandler;
using Mcma.Aws.Lambda;
using Microsoft.Extensions.DependencyInjection;

[assembly: LambdaSerializer(typeof(McmaLambdaSerializer))]

namespace __mcmaNamespace__.Mcma.Aws.__moduleName__.ApiHandler
{
    public class __moduleName__ApiHandler : McmaLambdaFunction<McmaLambdaApiHandler, APIGatewayProxyRequest, APIGatewayProxyResponse>
    {
        protected override void Configure(IServiceCollection services)
            => services.AddMcmaLambdaApiHandler(
                "__moduleNameSnake__-api-handler",
                builder =>
                {
                    // add routes here
                });
    }
}
