using Microsoft.AspNetCore.Mvc;

namespace ATM.Controllers
{
    public class AtmController : Controller
    {
        [ActionName("account-detail")]
        public IActionResult AccountDetail()
        {
            return View("AccountDetail");
        }
    }
}
