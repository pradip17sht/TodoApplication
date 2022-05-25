using Microsoft.EntityFrameworkCore;
using TodoApplication.Model;

namespace TodoApplication.Model
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext()
        {

        }
        public TodoDBContext(DbContextOptions<TodoDBContext> options):base(options)
        {

        }
        public DbSet<Todo> Todo { get; set; }
        public DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot config = builder.Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("MyDbConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
