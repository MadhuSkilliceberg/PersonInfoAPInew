using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PersonsInfoV2Api.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private readonly ILogger _logger;
        public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            // Get controller and action names
            var controllerName = context.ActionDescriptor.RouteValues["controller"];
            var actionName = context.ActionDescriptor.RouteValues["action"];


            _logger.LogError(context.Exception, "An unhandled exception occurred.");

            var result = new ObjectResult(new
            {

                Error = "An unexpected error occurred.",
                Controller = controllerName,
                Action = actionName,
                Message = context.Exception.Message.ToString(),
                LoggerMessage = context.Exception.ToString(),

            })
            {
                StatusCode = 500
            };

            context.Result = result;
            context.ExceptionHandled = true;
        }
    }
}
