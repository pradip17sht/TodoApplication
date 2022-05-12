using TodoApplication.Model;

namespace TodoApplication.Service
{
    public interface ITodo
    {
        List<Todo> GetAllTodo();
        Todo AddTodo(Todo todo);
        Todo EditTodo(Todo todo);
        void DeleteTodo(Todo todo);

    }
}
