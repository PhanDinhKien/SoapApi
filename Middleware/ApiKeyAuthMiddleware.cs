using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoapApi.Middleware
{
    public class ApiKeyAuthMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly List<(string ApiKey, string ApiSecret)> _clients;

        public ApiKeyAuthMiddleware(RequestDelegate next, IConfiguration configuration)
        {
            _next = next;
            _clients = new List<(string, string)>();
            var section = configuration.GetSection("ApiAuth:Clients").GetChildren();
            foreach (var client in section)
            {
                var key = client["ApiKey"] ?? string.Empty;
                var secret = client["ApiSecret"] ?? string.Empty;
                if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(secret))
                    _clients.Add((key, secret));
            }
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue("X-Api-Key", out var apiKey) ||
                !context.Request.Headers.TryGetValue("X-Api-Secret", out var apiSecret) ||
                !_clients.Any(c => c.ApiKey == apiKey && c.ApiSecret == apiSecret))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Unauthorized: Invalid API Key or Secret");
                return;
            }
            await _next(context);
        }
    }
}
