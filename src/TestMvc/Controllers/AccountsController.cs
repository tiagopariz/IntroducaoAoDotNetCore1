using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestMvc.Models;

namespace TestMvc.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }
        public IActionResult Register()
        {
            _logger.LogInformation("Register log");
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            _logger.LogInformation("Register log");
            if (ModelState.IsValid)
            {
                
            }
            else
            {
                _logger.LogError("Dados inválidos");
            }
            return View("RegisterCompleted");
        }
    }
}