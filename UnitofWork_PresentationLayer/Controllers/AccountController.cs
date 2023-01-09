using BusinessLayer_Uow.Abstract;
using EntityLayer_Uow.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using UnitofWork_PresentationLayer.Models;

namespace UnitofWork_PresentationLayer.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ProcessViewModel model)
        {
            var value1 = _accountService.TGetByID(model.SenderID);
            var value2 = _accountService.TGetByID(model.ReceiverID);

            value1.Balance -= model.Amount;
            value2.Balance += model.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                value1,
                value2
            };

            _accountService.TMultiUpdate(modifiedAccounts);

            return View();
        }
    }
}
