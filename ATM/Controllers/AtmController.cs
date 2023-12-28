using ATM.Models;
using ATM.Service;
using Microsoft.AspNetCore.Mvc;

namespace ATM.Controllers
{
    public class AtmController : Controller
    {
        private readonly HelperService _helperService;
        private readonly AtmService _atmService;

        public AtmController(AtmService atmService, HelperService helperService)
        {
            _helperService = helperService;
            _atmService = atmService;
        }

        [ActionName("account-detail")]
        public IActionResult AccountDetail()
        {
            AtmCardRequestModel model = new AtmCardRequestModel();
            model.CardNo = _helperService.GetAtmCode();
            return View("AccountDetail", model);
        }
    }
}
