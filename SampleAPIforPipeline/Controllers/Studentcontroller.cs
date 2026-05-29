using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleAPIforPipeline.Models;

namespace SampleAPIforPipeline.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class Studentcontroller : ControllerBase
    {
        public static List<Student> studentslist;

        public Studentcontroller() // constracter nase same as class name
        {
            studentslist = new List<Student>();
        }

        [HttpGet]
        [Route("api/allstudents")]

        public List<Student> GetAll()
        {
            List<Student> lst = GenerateInitialData(); 
            return lst;
        }

        [HttpGet]
        [Route("api/student/{id}")]
        public Student GetById(int id)
        {
            return GenerateInitialData().FirstOrDefault(s => s.StudentId == id);
        }

        [HttpGet]
        [Route("api/studentnamebyid/{id}")]
        public String GetNameById(int id)
        {
            Student st = GenerateInitialData().FirstOrDefault(s => s.StudentId == id);
            return st.Name;
        }


        [NonAction]
        public List<Student> GenerateInitialData()
        {
            studentslist.Add(new Student() { StudentId = 1, Name = "John", Qualification = "BSc", Percentage = 85.5f });
            studentslist.Add(new Student() { StudentId = 2, Name = "Alice", Qualification = "MSc", Percentage = 90.0f });
            studentslist.Add(new Student() { StudentId = 3, Name = "Bob", Qualification = "BSc", Percentage = 78.0f });
            studentslist.Add(new Student() { StudentId = 4, Name = "Zain", Qualification = "BBA", Percentage = 85.5f });
            studentslist.Add(new Student() { StudentId = 5, Name = "Om", Qualification = "BE", Percentage = 90.0f });
            studentslist.Add(new Student() { StudentId = 6, Name = "Prame", Qualification = "B.COM", Percentage = 78.0f });
            studentslist.Add(new Student() { StudentId = 7, Name = "NIshan", Qualification = "MBA", Percentage = 85.5f });
            studentslist.Add(new Student() { StudentId = 8, Name = "Ganesh", Qualification = "MCA", Percentage = 90.0f });
            studentslist.Add(new Student() { StudentId = 9, Name = "Pale", Qualification = "BE", Percentage = 78.0f });
            studentslist.Add(new Student() { StudentId = 10, Name = "Ajay", Qualification = "BE", Percentage = 85 });

            return studentslist;
        }

    }
}
