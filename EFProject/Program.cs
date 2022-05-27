namespace EFProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeDBContext db = new EmployeeDBContext();

            // Use Enumerable query to get employee name from employee table
            IEnumerable<Employee> employees = db.Employee.AsEnumerable().Where(x => x.Name == "Ram");
            employees = employees.Take(1);
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.Name + " " + emp.Email + " " + emp.Address);
            }

            // Use Queryable query to get employee name from employee table
            IQueryable<Employee> employees2 = db.Employee.AsQueryable().Where(x => x.Name == "Hari");
            employees2 = employees2.Take(1);
            foreach (var emp in employees2)
            {
                Console.WriteLine(emp.Name + " " + emp.Email + " " + emp.Address);
            }

            Console.ReadKey();
        }
    }
}