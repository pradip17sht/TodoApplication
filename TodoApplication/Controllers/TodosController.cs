using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApplication.Service;

namespace TodoApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodo _todo;
        public TodosController(ITodo todo)
        {
            _todo = todo;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetAllTodo()
        {
            return Ok(_todo.GetAllTodo());
        }
    }
}
