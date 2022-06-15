using JqueryDataTable.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JqueryDataTable.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _Db;
        public StudentController(ApplicationDbContext Db)
        {
            _Db = Db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudent()
        {
            var stud = _Db.students.ToList();
            return Json(stud);
        }
    }
}
