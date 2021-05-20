using Mcma.Api;
using Mcma.Api.Routing.Defaults.Routes;
using Mcma.GoogleCloud.Functions.ApiHandler;

namespace __mcmaNamespace__.Mcma.Modules.__moduleName__.GoogleCloud.ApiHandler
{
    public class Startup : McmaApiHandlerStartup
    {
        public override string ApplicationName => "__moduleNameSnake__-api-handler";

        public override void BuildApi(McmaApiBuilder apiBuilder)
        {
            // add routes here
        }
    }
}