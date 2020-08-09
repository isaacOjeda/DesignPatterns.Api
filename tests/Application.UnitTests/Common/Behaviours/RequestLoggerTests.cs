using DesignPatterns.Api.Application.Common.Behaviours;
using DesignPatterns.Api.Application.Common.Interfaces;
using DesignPatterns.Api.Application.TodoItems.Commands.CreateTodoItem;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Api.Application.UnitTests.Common.Behaviours
{
    public class RequestLoggerTests
    {
        private readonly Mock<ILogger<CreateTodoItemCommand>> _logger;
        private readonly Mock<ICurrentUserService> _currentUserService;


        public RequestLoggerTests()
        {
            _logger = new Mock<ILogger<CreateTodoItemCommand>>();

            _currentUserService = new Mock<ICurrentUserService>();
        }

        [Test]
        public async Task ShouldCallGetUserNameAsyncOnceIfAuthenticated()
        {
            _currentUserService.Setup(x => x.UserId).Returns("Administrator");

            var requestLogger = new LoggingBehaviour<CreateTodoItemCommand>(_logger.Object, _currentUserService.Object);

            await requestLogger.Process(new CreateTodoItemCommand { ListId = 1, Title = "title" }, new CancellationToken());

            _currentUserService.Verify(i => i.UserId, Times.Once);
        }     
    }
}
