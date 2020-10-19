using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BonusF.Models;

namespace Bonus.Controllers
{
        public class BonusController : Controller
        {

            private readonly ILogger<BonusController> _logger;

            public BonusController(ILogger<BonusController> logger)
            {
                _logger = logger;
            }

            public IActionResult Index()
            {
                 var model = new BonusC();
                model.Bank = " ";
                return View(model);
            }

            [HttpPost]
            public IActionResult Registrar(BonusC objBonus)
            {

                if (ModelState.IsValid)
                {

                    objBonus.Response = "Gracias. Formulario enviado";
                }

            return View("index", objBonus);
            }

           


        }
}