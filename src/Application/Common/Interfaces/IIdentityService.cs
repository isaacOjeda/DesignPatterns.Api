using DesignPatterns.Api.Application.Common.Models;
using System.Threading.Tasks;

namespace DesignPatterns.Api.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<string> GetUserNameAsync(string userId);

        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);

        Task<Result> DeleteUserAsync(string userId);
    }
}
