using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.MVC.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();

            return View(model);
        }
    }
}
