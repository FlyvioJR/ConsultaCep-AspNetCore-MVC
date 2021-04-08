using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCep.Controllers
{
    public class EnderecoController : Controller
    {
        // GET: EnderecoController
        public ActionResult Index()
        {
            return View();
        }
    }
}
