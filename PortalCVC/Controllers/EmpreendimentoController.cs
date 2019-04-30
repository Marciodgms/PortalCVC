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
        private readonly Contexto _db;

        public EmpreendimentoController(Contexto Db)
        {
            _db = Db;
        }

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
            var teste = _db.tb_empreendimento.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(tb_empreendimento empreendimento)
        {
            _db.tb_empreendimento.Add(empreendimento);
            return RedirectToAction("Index");
        }
    }
}