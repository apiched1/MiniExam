using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.Models;

namespace myapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        public static List<Students> Students = new List<Students>();

        [HttpPost]
        public void AddStudent(Students id)
        {
            Students.Add(id);
        }

        [HttpGet]
        public ActionResult<List<Students>> GetAllStudent()
        {
            return Students;
        }

        [HttpGet]
        public ActionResult<Students> CheckGrade()
        {
            var student = new Students();
            
            

            return student;
        }



    }
}
