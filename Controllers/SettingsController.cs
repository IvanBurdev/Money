using Microsoft.AspNetCore.Mvc;

namespace Expense_Tracker.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}