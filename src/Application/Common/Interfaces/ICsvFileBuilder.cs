using DesignPatterns.Api.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace DesignPatterns.Api.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
