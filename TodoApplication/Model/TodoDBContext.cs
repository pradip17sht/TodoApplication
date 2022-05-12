using Microsoft.EntityFrameworkCore;
using TodoApplication.Model;

namespace TodoApplication.Model
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options):base(options)
        {

        }
        public DbSet<Todo> Todo { get; set; }
    }
}
