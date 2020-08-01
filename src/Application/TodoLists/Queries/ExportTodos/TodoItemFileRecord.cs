using DesignPatterns.Api.Application.Common.Mappings;
using DesignPatterns.Api.Domain.Entities;

namespace DesignPatterns.Api.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
