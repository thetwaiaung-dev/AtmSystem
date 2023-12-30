using ATM.Helper;
using ATM.Models;
using ATM.Service;
using Microsoft.AspNetCore.Mvc;

namespace ATM.Controllers
{
    public class AtmController : Controller
    {
        private readonly HelperService _helperService;
        private readonly AtmService _atmService;
        private readonly UserService _userService;

        public AtmController(AtmService atmService, HelperService helperService, UserService userService)
        {
            _helperService = helperService;
            _atmService = atmService;
            _userService = userService;
        }

        [ActionName("account-detail")]
        public IActionResult AccountDetail(int id)
        {
            UserModel user = _userService.GetUser(id);
            if (user == null)
            {
                return Redirect("/home/login");
            }

            AtmCardModel atmCard = _atmService.GetAtmCard(user.Id);
            atmCard.CardNo = DevCode.FormatAtmCard(atmCard.CardNo);
            AtmCardRequestModel model = ChangeModel.Change(user, atmCard);

            return View("AccountDetail", model);
        }

        public IActionResult WithDrawl()
        {
            return View();
        }

        public IActionResult Deposit()
        {
            return View();
        }
    }
}
