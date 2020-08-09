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
            _http = httpContextAccessor.HttpContext;

            UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
            Name = httpContextAccessor.HttpContext?.User?.FindFirstValue("name");
            Email = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Email);
        }

        public string UserId { get; }
        public string Name { get; }
        public string Email { get; set; }

        public bool IsInRole(string role) => _http.User.IsInRole(role);
    }
}
