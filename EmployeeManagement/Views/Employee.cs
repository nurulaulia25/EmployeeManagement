using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Views
{
    public class EmployeeViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
