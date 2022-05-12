#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApplication.Model;

namespace TodoApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoDBContext _todoDBContext;

        public TodoController(TodoDBContext todoDBContext)
        {
            _todoDBContext = todoDBContext;
        }


        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var todos = await _todoDBContext.Todo.ToListAsync();
            return Ok(todos);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(Todo todo)
        {
            _todoDBContext.Todo.Add(todo);
            await _todoDBContext.SaveChangesAsync();
            return NoContent();
            //return Created($"/get-todo-by-id?id={todo.Id}", todo);
        }

        [HttpPut]
        public async Task<IActionResult> PutAsync(Todo todoToUpdate)
        {
            _todoDBContext.Todo.Update(todoToUpdate);
            await _todoDBContext.SaveChangesAsync();
            return NoContent();
        }

        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var todoToDelete = await _todoDBContext.Todo.FindAsync(id);
            if (todoToDelete == null)
            {
                return NotFound();
            }
            _todoDBContext.Todo.Remove(todoToDelete);
            await _todoDBContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
