using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: /Home/Contact (uses Partial View)
        public ActionResult Contact()
        {
            return View();
        }

        // GET: /Home/StudentFeedback
        public ActionResult StudentFeedback()
        {
            return View();
        }

        // POST: /Home/StudentFeedback (Validation and Display below form)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult StudentFeedback(StudentFeedbackModel model)
        {
            if (ModelState.IsValid)
            {
                // In C#: set ViewBag properties to display student details below the form
                ViewBag.StudentName = model.StudentName;
                ViewBag.Email = model.Email;
                ViewBag.Course = model.Course;
                ViewBag.FeedbackText = model.FeedbackText;
                ViewBag.IsSubmitted = true;

                // Clear model state so the input fields are reset for a fresh entry
                ModelState.Clear();
                return View(new StudentFeedbackModel());
            }

            return View(model);
        }
    }
}
