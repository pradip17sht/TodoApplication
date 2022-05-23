using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LINQExercise
    {
        public void GetTeenAgeStudents()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };

            // LINQ Query Syntax to find out teenager students
            var teenAgerStudent = from s in studentList
                                  where s.Age > 12 && s.Age < 20
                                  select s;
            Console.WriteLine("Teen age Students:");

            foreach (Student std in teenAgerStudent)
            {
                Console.WriteLine(std.StudentName);
            }
        }


        public void GetOfType()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(5);
            mixedList.Add(6);
            mixedList.Add("Five");
            mixedList.Add("six");
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Ram", Age = 29 });

            var stringResult = from s in mixedList.OfType<string>()
                               select s;
            var intResult = from s in mixedList.OfType<int>()
                            select s;
            var stdResult = from s in mixedList.OfType<Student>()
                            select s;

            foreach (var str in stringResult)
            {
                Console.WriteLine(str);
            }

            foreach (var integer in intResult)
            {
                Console.WriteLine(integer);
            }

            foreach (var std in stdResult)
            {
                Console.WriteLine(std.StudentName);
                Console.WriteLine(std.Age);
            }
        }


        public void GetPersonWithOrderBy()
        {
            IList<Person> personList = new List<Person>()
            {
                new Person() { Id = 1, Name = "Jack", Email = "jack@gmail.com", Address = "kathamandu" },
                new Person() { Id = 2, Name = "Rose", Email = "rose.red@hotmail.com", Address = "Pokhara" },
                new Person() { Id = 3, Name = "Alice", Email = "alice@yahoo.com", Address = "Patan" },
                new Person() { Id = 4, Name = "Bob", Email = "bob@gmail.com", Address = "Bhaktapur" }
            };
            var orderByAsc = from p in personList
                             orderby p.Name //Sorts the studentList collection in ascending order
                             select p;

            //Sorts the studentList collection in ascending order
            var orderByDesc = from p in personList.OrderByDescending(p => p.Name)
                              select p;

            /*var orderByDesc = from p in personList
                                orderby p.Name descending //Sorts the studentList collection in ascending order
                                select p;*/

            Console.WriteLine(" -----* Ascending Order *-----");
            foreach (var person in orderByAsc)
            {
                Console.WriteLine(person.Name);
                Console.WriteLine(person.Email);
                Console.WriteLine(person.Address);
            }

            Console.WriteLine("-----* Descending Order *-----");
            foreach (var persons in orderByDesc)
            {
                Console.WriteLine(persons.Name);
                Console.WriteLine(persons.Email);
                Console.WriteLine(persons.Address);
            }
        }

        public void GetPersonThenBy()
        {
            IList<Person> personList = new List<Person>()
            {
                new Person() { Id = 1, Name = "Jack", Email = "jack@gmail.com", Address = "kathamandu" },
                new Person() { Id = 2, Name = "Rose", Email = "rose.red@hotmail.com", Address = "Pokhara" },
                new Person() { Id = 3, Name = "Alice", Email = "alice@yahoo.com", Address = "Patan" },
                new Person() { Id = 4, Name = "Bob", Email = "bob@gmail.com", Address = "Bhaktapur" }
            };
            var thenByResult = personList.OrderBy(p => p.Name).ThenBy(p => p.Address);

            var thenByDescResult = personList.OrderByDescending(p => p.Name).ThenByDescending(p => p.Address);

            Console.WriteLine("-----* thenByResult *-----");
            foreach (var person in thenByResult)
            {
                Console.WriteLine("Name: {0}, Email: {1}, Address: {2}", person.Name, person.Email, person.Address);
            }

            Console.WriteLine("-----* thenByDescResult *-----");
            foreach (var person in thenByDescResult)
            {
                Console.WriteLine("Name: {0}, Email: {1}, Address: {2}", person.Name, person.Email, person.Address);
            }
        }

    }
}
