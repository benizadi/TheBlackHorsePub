using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace AzureFunctions.HttpTrigger;

public class Status
{
    private readonly ILogger _logger;

    public Status(ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<Status>();
    }

    [Function("Status")]
    public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req,
        FunctionContext executionContext)
    {
        var response = req.CreateResponse(HttpStatusCode.OK);
        return response;
    }
}