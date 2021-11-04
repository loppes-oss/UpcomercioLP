using ComercioLP.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComercioLP.Controllers
{
    public class VendedorController1 : Controller
    {
        private readonly ComercioLPContext _comercioLP;

        public VendedorController1(ComercioLPContext comercioLP)
        {
            _comercioLP = comercioLP;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
