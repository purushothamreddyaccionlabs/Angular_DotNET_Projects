﻿using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        [HttpGet]
       public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "Purushotham", "Abdul", "Venu", "Hemanth", "Randeep" };
            return Ok(studentNames);
        }
    }
}
