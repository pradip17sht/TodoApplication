using TodoApplication.Model;

namespace TodoApplication.Service
{
    public class TodoService : ITodo
    {
        public Todo AddTodo(Todo todo)
        {
            todo.Id = Guid.NewGuid();
            //todo.Add(todo);
            return todo;
        }

        public void DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Todo EditTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAllTodo()
        {
            throw new NotImplementedException();
        }
    }
}
