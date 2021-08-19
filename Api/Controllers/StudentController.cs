using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Api.Controllers
{
    #region StudentController
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students = new List<Student>()
            {
                new Student{StudentId =1, Firstname = "Aastha", Lastname="Chadha", UserName="aasthachadha1", Password ="123456"},
                new Student{StudentId =2, Firstname = "Raj", Lastname="KUMAR", UserName="Rajk", Password ="123456"},
                new Student{StudentId =3, Firstname = "Shayna", Lastname="VINCENT", UserName="Shaynaros", Password ="123456"},
                new Student{StudentId =4, Firstname = "Rachel", Lastname="Greene", UserName="Rachelg", Password ="123456"},
                new Student{StudentId =5, Firstname = "David", Lastname="MILLER", UserName="Davidj", Password ="123456"},
                new Student{StudentId =1, Firstname = "Viraj", Lastname="Chabra", UserName="Ragini", Password ="123456"},
                new Student{StudentId =2, Firstname = "Scott", Lastname="Andrews", UserName="Andrews1", Password ="123456"},
                new Student{StudentId =3, Firstname = "Stevens", Lastname="GILCHRIST", UserName="Steve", Password ="123456"},
                new Student{StudentId =4, Firstname = "AarifMuhammad", Lastname="RASHID", UserName="Muhammad", Password ="123456"},
                new Student{StudentId =5, Firstname = "Amanpreet", Lastname="Sandhu", UserName="Amanp", Password ="123456"}
            };


        [HttpGet]
        [Authorize]
        public List<Student> Get()
        {
            return students;
        }

        [Authorize]
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            Student s = null;
            students.ForEach(delegate (Student student)
            {
                if (student.StudentId == id)
                {
                    s = student;
                }
            });
            return s;
        }
    }
}
#endregion
