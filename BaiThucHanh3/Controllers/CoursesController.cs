using BaiThucHanh3.Models;
using BaiThucHanh3.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiThucHanh3.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        private readonly ApplicationDbContext _dbContext;
        private object Categories;

        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        //[Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
            var courses = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId= viewModel.Category,
                Plance = viewModel.Place
            };
            _dbContext.Courses.Add(courses);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}