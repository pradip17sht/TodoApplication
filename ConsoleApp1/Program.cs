using RestSharp;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //RestSharpExercise.GetNRBAPIs();
            //RestSharpExercise.GetMBLAPIs();

            //RestSharpExercise.PublicAPIs();
            //RestSharpExercise.GetCatFacts();
            //RestSharpExercise.GetPersons();
            //RestSharpExercise.GetNationality();
            //RestSharpExercise.GetIPAddress();
            //RestSharpExercise.GetUsers();

            LINQExercise objLINQExercise = new LINQExercise();
            //objLINQExercise.GetTeenAgeStudents();
            //objLINQExercise.GetOfType();
            //objLINQExercise.GetPersonWithOrderBy();
            //objLINQExercise.GetPersonThenBy();
            objLINQExercise.GetStudents();
            objLINQExercise.GetPersonName();
            objLINQExercise.UseFirstAndLastQuery();
            objLINQExercise.GetDistinct();

            Console.Read();
        }
        
    }
}