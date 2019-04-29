using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PortalCVC.Models;

namespace PortalCVC.Controllers
{
    public class EmpreendimentoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(tb_empreendimento empreendimento)
        {
            return RedirectToAction("Index");
        }
    }
}