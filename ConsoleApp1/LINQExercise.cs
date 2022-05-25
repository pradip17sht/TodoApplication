using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApplication.Model;

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
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 20 }
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


            Console.WriteLine("-----* GroupBy *-----");
            //LINQ Query syntax for GroupBy
            var groupedResult = from s in studentList
                                group s by s.Age;
            //var groupedResult = studentList.GroupBy(s => s.Age);
            //iterate each group
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key);
                foreach (Student s in ageGroup)
                {
                    Console.WriteLine("Student Name: {0}", s.StudentName);
                }
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
                new Person() { PersonID = 1, Name = "Jack", Email = "jack@gmail.com", Address = "kathamandu" },
                new Person() { PersonID = 2, Name = "Rose", Email = "rose.red@hotmail.com", Address = "Pokhara" },
                new Person() { PersonID = 3, Name = "Alice", Email = "alice@yahoo.com", Address = "Patan" },
                new Person() { PersonID = 4, Name = "Bob", Email = "bob@gmail.com", Address = "Bhaktapur" }
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
                new Person() { PersonID = 1, Name = "Jack", Email = "jack@gmail.com", Address = "kathamandu" },
                new Person() { PersonID = 2, Name = "Rose", Email = "rose.red@hotmail.com", Address = "Pokhara" },
                new Person() { PersonID = 3, Name = "Alice", Email = "alice@yahoo.com", Address = "Patan" },
                new Person() { PersonID = 4, Name = "Bob", Email = "bob@gmail.com", Address = "Bhaktapur" }
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


        //join examples
        public void GetStudents()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, PersonID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, PersonID = 2 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, PersonID = 3 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, PersonID = 4 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            //Person Collection
            IList<Person> personList = new List<Person>()
            {
                new Person() { PersonID = 1, Name = "Jack", Email = "jack@gmail.com", Address = "kathamandu" },
                new Person() { PersonID = 2, Name = "Rose", Email = "rose.red@hotmail.com", Address = "Pokhara" },
                new Person() { PersonID = 3, Name = "Alice", Email = "alice@yahoo.com", Address = "Patan" },
                new Person() { PersonID = 4, Name = "Bob", Email = "bob@gmail.com", Address = "Bhaktapur" }
            };
            /*var innerJoinResult = studentList.Join(
                                    personList,
                                    student => student.PersonID,
                                    person => person.PersonID,
                                    (student, person) => new
                                    {
                                        StudentName = student.StudentName,
                                        Age = student.Age,
                                        Name = person.Name,
                                        Email = person.Email,
                                        Address = person.Address
                                    });*/
            var innerJoinResult = from student in studentList
                                  join person in personList
                                  on student.PersonID equals person.PersonID
                                  select new
                                  {
                                      StudentName = student.StudentName,
                                      Age = student.Age,
                                      Name = person.Name,
                                      Email = person.Email,
                                      Address = person.Address
                                  };
            foreach (var student in innerJoinResult)
            {
                Console.WriteLine(" {0}, {1}, {2}, {3}. {4}", student.StudentName, student.Age, student.Name, student.Email, student.Address);
            }


            //group join
            /*var groupJoin = personList.GroupJoin(studentList,
                                            person => person.PersonID,
                                            student => student.PersonID,
                                            (person, studentsGroup) => new
                                            {
                                                Students = studentsGroup,
                                                PersonFullName = person.Name
                                            });*/
            var groupJoin = from person in personList
                            join student in studentList
                            on person.PersonID equals student.PersonID
                            into studentGroup
                            select new
                            {
                                Students = studentGroup,
                                PersonFullName = person.Name
                            };
            foreach(var item in groupJoin)
            {
                Console.WriteLine(item.PersonFullName);
                foreach (var student in item.Students)
                {
                    Console.WriteLine(student.StudentName);
                }
            }
        }


        public void GetPersonName()
        {
            //Person Collection
            List<Person> personList = new List<Person>()
            {
                new Person() { PersonID = 1, Name = "Jack", Email = "jack@gmail.com", Address = "kathamandu" },
                new Person() { PersonID = 2, Name = "Rose", Email = "rose.red@hotmail.com", Address = "Pokhara" },
                new Person() { PersonID = 3, Name = "Alice", Email = "alice@yahoo.com", Address = "Patan" },
                new Person() { PersonID = 4, Name = "Bob", Email = "bob@gmail.com", Address = "Bhaktapur" }
            };
            /*var selectResult = from person in personList
                               select (person.Name, person.Email, person.Address);*/
            var selectResult = personList.Select(person => new 
                                                        { 
                                                            Name = person.Name, 
                                                            Email = person.Email,
                                                            Address = person.Address
                                                        });
            Console.WriteLine("-----* select *-----");
            foreach(var name in selectResult)
            {
                Console.WriteLine(name);
            }


            // IEnumerable query use
            IEnumerable<Person> query = from person in personList
                                        where person.PersonID == 1
                                        select person;
            foreach (var person in query)
            {
                Console.WriteLine("Id = " + person.PersonID + " Name = " + person.Name
                    + " Email = " + person.Email + " Address = " + person.Address);
            }


            //IQueryable query use
            IQueryable<Person> que = personList.AsQueryable().Where(x => x.PersonID == 2);
            foreach (var person in que)
            {
                Console.WriteLine("Id = " + person.PersonID + " Name = " + person.Name
                    + " Email = " + person.Email + " Address = " + person.Address);
            }

            TodoDBContext dbContext = new TodoDBContext();
            var students = dbContext.Student.AsEnumerable()
                                            .Where(x => x.StudentName == "Bill")
                                            //.OrderByDescending(x => x.Age)
                                            .Take(2);
            //IEnumerable<Student> students = dbContext.Student.Where(x => x.StudentName == "Rose");
            //students = students.Take(2).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student.StudentName + " " + student.Age);
            }

            /*TodoDBContext db = new TodoDBContext(); 
            IQueryable<Student> listStudents = db.Student.AsQueryable().Where(x => x.StudentName == "Rose");
            students = students.Take(2).ToList();
            foreach (var student in students)
            {
                Console.WriteLine(student.StudentName + " " + student.Age);
            }*/
        }


        //use of First and FirstOrDefault
        public void UseFirstAndLastQuery()
        {
            IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87};
            IList<string> stringList = new List<string>() { "one", null, "two", "five", "ten" };
            IList<string> emptyList = new List<string>();
            IList<int> oneElementList = new List<int>() { 7 };

            Console.WriteLine("1st element in intList: {0}", intList.First());
            Console.WriteLine("1st element in intList: {0}", intList.First(i => i % 2 == 0));
            Console.WriteLine("1st element in stringList: {0}", stringList.First());
            //Console.WriteLine("1st element in emptyList: {0}", emptyList.First());

            Console.WriteLine("1st element in intList: {0}", intList.FirstOrDefault());
            Console.WriteLine("1st element in intList: {0}", intList.FirstOrDefault(i => i % 2 == 0));
            Console.WriteLine("1st element in stringList: {0}", stringList.FirstOrDefault());
            Console.WriteLine("1st element in emptyList: {0}", emptyList.FirstOrDefault());

            Console.WriteLine("Last element in intList: {0}", intList.Last());
            Console.WriteLine("Last element in intList: {0}", intList.Last(i => i % 2 == 0));
            Console.WriteLine("Last element in stringList: {0}", stringList.Last());
            //Console.WriteLine("Last element in emptyList: {0}", emptyList.Last());

            Console.WriteLine("Last element in intList: {0}", intList.LastOrDefault());
            Console.WriteLine("Last element in intList: {0}", intList.LastOrDefault(i => i % 2 == 0));
            Console.WriteLine("Last element in stringList: {0}", stringList.LastOrDefault());
            Console.WriteLine("Last element in emptyList: {0}", emptyList.LastOrDefault());

            Console.WriteLine("One Element in oneElementList: {0}", oneElementList.Single());
            Console.WriteLine("One Element in oneElementList: {0}", oneElementList.SingleOrDefault());

            //concatenation operator use
            var result = intList.Concat(oneElementList);
            foreach (var item in result)
                Console.WriteLine(item);
        }


        public void GetDistinct()
        {
            IList<string> stringList = new List<string>() { "one", "two", "three", "one", "two"};
            var distinctList = (from list in stringList
                               select list).Distinct();
            //var distinctList = stringList.Distinct();
            foreach (var distinct in distinctList)
            {
                Console.WriteLine(distinct);
            }
        }

        
        //Converts a Generic list to a generic dictionary
        public void GetGenericDictionary()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve", Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            //following converts list into Dictionary where studentId is a key
            IDictionary<int, Student> stdDictionary = studentList.ToDictionary<Student, int>(s => s.StudentID);
            foreach (var key in stdDictionary.Keys)
            {
                Console.WriteLine("Key: {0}, Value: {1}", key, (stdDictionary[key] as Student).StudentName);
            }


            //use let in query 
            var lowerCaseStudentNames = from student in studentList 
                                        let lowerCaseStudenName = student.StudentName.ToLower()
                                        where lowerCaseStudenName.StartsWith("s")
                                        select lowerCaseStudenName;
            foreach (var name in lowerCaseStudentNames)
            {
                Console.WriteLine(name);
            }

            //immediate execution
            IList<Student> teenAgerStudents =
                studentList.Where(s => s.Age > 12 && s.Age < 20).ToList();
            /*IList<Student> teenAgerStudents = (from s in studentList
                                               where s.Age > 12 && s.Age < 20
                                               select s).ToList();*/
            foreach (var student in teenAgerStudents)
            {
                Console.WriteLine(student.StudentName);
            }
        }
    }
}
