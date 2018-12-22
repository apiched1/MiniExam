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
        public static List<Students> Score = new List<Students>();

        [HttpPost]
        public void AddStudent(Students Name)
        {
            Students.Add(Name);
        }

        [HttpGet]
        public ActionResult<List<Students>> GetAllStudent()
        {
            return Students;
        }


            // [HttpGet("{score}")]
            // public ActionResult<int> checkScore(int score)
            // {


            //     return result;
            // }

          
          




            //  Students.Any(it => it.Score <= 30);
            //  Students.Any(it => it.Score <= 74 || it.Score >= 63);
            //  Students.Any(it => it.Score <= 63 || it.Score >= 51);
            //  Students.Any(it => it.Score <= 30);
            //  var result = Students;

          
        


}
}
