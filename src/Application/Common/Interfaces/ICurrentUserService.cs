namespace DesignPatterns.Api.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; }
        string Name { get; }
        string Email { get; }
        bool IsInRole(string role);
    }
}
