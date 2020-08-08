namespace DesignPatterns.Api.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        string UserName { get; }
        bool IsInRole(string role);
    }
}
