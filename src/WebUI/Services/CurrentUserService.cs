using DesignPatterns.Api.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace DesignPatterns.Api.WebUI.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly HttpContext _http;
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            UserName = "TBD";
            _http = httpContextAccessor.HttpContext;
        }

        public string UserId { get; }
        public string UserName { get; }

        public bool IsInRole(string role) => _http.User.IsInRole(role);
    }
}
